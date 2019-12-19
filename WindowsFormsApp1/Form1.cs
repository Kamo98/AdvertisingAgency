using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using System.Collections;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		NpgsqlConnection npgSqlConnection;		//Соединение с БД


		public Form1()
		{
			InitializeComponent();

			npgSqlConnection = null;
		}


		/*Авторизация*/
		private void btnSignIn_Click(object sender, EventArgs e)
		{
			//Ввод логина и пароля
			string login = textBoxLogin.Text;
			string pass = textBoxPass.Text;

			bool logIn = AccessControl.log_in(login, pass, out npgSqlConnection);

			if (logIn)
			{

				/*Получить из БД имя и должность сотрудника*/
				string query = "select \"FIO\", \"Position\" from \"Employee\" where \"Username\" = '" + login + "';";
				NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, npgSqlConnection);
				NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
				if (npgSqlDataReader.HasRows)
				{
					foreach (DbDataRecord oneEmploye in npgSqlDataReader)
					{
						this.Text += "  | " + oneEmploye["FIO"] + "  |  " + oneEmploye["Position"];
						break;
					}
				}


				MessageBox.Show("Здравствуйте, " + login + "\nВы: " + AccessControl.get_name_cur_role());
				panelAuthorization.Hide();      //Спрятать панель авторизаци
					
					//и создать меню
				create_menu();
			}
			else
			{
				MessageBox.Show("Что-то пошло не так!");
			}

		}




		/*
		 * Обработчики нажатий на пункты меню*
		 */
		private void menuItemTest_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Test1 menu item");
		}

		/*********************/



		/*
		 * Метод для создания меню
		 * Создаёт меню для авторизированного пользователя
		 * */
		public void create_menu()
		{

			//Инициализируем подпукнты меню
			ToolStripMenuItem test1item = new ToolStripMenuItem("Test11", null, menuItemTest_Click);
			ToolStripMenuItem test2item = new ToolStripMenuItem("Test12");


			//Создаём массивы для основных пунктов меню
			List<ToolStripMenuItem> arrForTest1 = new List<ToolStripMenuItem>();


			//Заполняем эти массивы
			if (AccessControl.CurentRole == 0)
				return;

			if ((AccessControl.CurentRole & AccessControl.Role.customer_relations_officer) != 0)
				//Добавить пункы меню для сотрудника отдела по работе с клиентами
				arrForTest1.Add(test1item);
			if ((AccessControl.CurentRole & AccessControl.Role.chief_of_department) != 0)
				//Добавить пункы меню для руководителя отдела
				arrForTest1.Add(test2item);

			//и так далее
			

			mainMenuStrip.Items.Add(new ToolStripMenuItem("Test1", null, arrForTest1.ToArray()));
		}


		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (npgSqlConnection != null)
				npgSqlConnection.Close();
		}
		
	}
}
