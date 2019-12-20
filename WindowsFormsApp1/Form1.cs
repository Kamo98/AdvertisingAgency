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
        Employee employee;


		public Form1()
		{
			InitializeComponent();
			npgSqlConnection = null;
		}

        //Свойство сотрудника, для передачи дочерним формам 
        public Employee Employee
        {
            get => employee;
            set => employee = value;
        }

        public NpgsqlConnection Connection
        {
            get => npgSqlConnection;
        }


		/*Авторизация*/
		private void btnSignIn_Click(object sender, EventArgs e)
		{
			//Ввод логина и пароля
			string login = textBoxLogin.Text;
			string pass = textBoxPass.Text;

			string message = AccessControl.log_in(login, pass, out npgSqlConnection);

			if (npgSqlConnection != null)
			{
                
				/*Получить из БД имя и должность сотрудника*/
				string query = "select \"FIO\", \"Position\" from \"Employee\" where \"Username\" = '" + login + "';";
				NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, npgSqlConnection);
				NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
				if (npgSqlDataReader.HasRows)
				{
					foreach (DbDataRecord oneEmployee in npgSqlDataReader)
					{
                        //this.Text += "  | " + oneEmployee["FIO"] + "  |  " + oneEmployee["Position"];
                        employee = new Employee(oneEmployee);
						break;
					}
				}
                npgSqlDataReader.Close();


				MessageBox.Show("Здравствуйте, " + login + "\nВы: " + AccessControl.get_name_cur_role());
				//panelAuthorization.Hide();      //Спрятать панель авторизаци

                this.Hide();
                ClientDepartmentForm form = new ClientDepartmentForm(this);
                form.ShowDialog();
                npgSqlConnection.Close();
                

                //и создать меню
                //create_menu();
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
			if (npgSqlConnection != null)
				npgSqlConnection.Close();
		}
		
	}
}
