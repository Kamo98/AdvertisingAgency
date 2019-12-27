using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{

        public Form1()
		{
			InitializeComponent();
            ConnectionSettings.npgSqlConnection = null;
		}



		/*Авторизация*/
		private void btnSignIn_Click(object sender, EventArgs e)
		{
			//Ввод логина и пароля
			string login = textBoxLogin.Text;
			string pass = textBoxPass.Text;

			string message = AccessControl.log_in(login, pass);

			if (ConnectionSettings.npgSqlConnection != null)
			{

				/*Получить из БД данные сотрудника*/
				string query = "select * from \"Employee\" where \"Username\" = '" + login + "';";
				NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, ConnectionSettings.npgSqlConnection);
				NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
				if (npgSqlDataReader.HasRows)
				{
					foreach (DbDataRecord oneEmployee in npgSqlDataReader)
					{
                        npgSqlDataReader.Close();
                        //this.Text += "  | " + oneEmployee["FIO"] + "  |  " + oneEmployee["Position"];
                        ConnectionSettings.LoggedUser = new Employee(
                                                                oneEmployee["ID_Employee"],
                                                                oneEmployee["FIO"],
                                                                oneEmployee["Position"],
                                                                oneEmployee["ID_Department"],
                                                                oneEmployee["Active"],
                                                                oneEmployee["Username"]);
						break;
					}
				}
                

				MessageBox.Show("Здравствуйте, " + login + "\nВы: " + AccessControl.get_name_cur_role());
				panelAuthorization.Hide();      //Спрятать панель авторизаци

					//и создать меню
				create_menu();


                this.Controls.Add(ButtonBuilder.Get_AddEmployeeBtn());
            }
			else
			{
				MessageBox.Show(message);
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
			ToolStripMenuItem test1item = new ToolStripMenuItem("Some text", null, menuItemTest_Click);
			ToolStripMenuItem test2item = new ToolStripMenuItem("Test12");


			//Создаём массивы для основных пунктов меню
			List<ToolStripMenuItem> arrForTest1 = new List<ToolStripMenuItem>();


			//Заполняем эти массивы
			if (AccessControl.CurrentRole == 0)
				return;

			if ((AccessControl.CurrentRole & AccessControl.Role.customer_relations_officer) != 0)
				//Добавить пункы меню для сотрудника отдела по работе с клиентами
				arrForTest1.Add(test1item);
			if ((AccessControl.CurrentRole & AccessControl.Role.chief_of_department) != 0)
				//Добавить пункы меню для руководителя отдела
				arrForTest1.Add(test2item);

			//и так далее

			mainMenuStrip.Items.Add(new ToolStripMenuItem("My text", null, arrForTest1.ToArray()));
		}


		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (ConnectionSettings.npgSqlConnection != null)
                ConnectionSettings.npgSqlConnection.Close();
		}

	}
}
