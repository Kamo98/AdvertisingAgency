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
			String login = textBoxLogin.Text;
			String pass = textBoxPass.Text;

			bool logIn = AccessControl.log_in(login, pass, out npgSqlConnection);

			if (logIn)
			{
				MessageBox.Show("Здравствуйте, " + login + "\nВы:  " + AccessControl.get_name_cur_role());
				panelAuthorization.Hide();
			}
			else
			{
				MessageBox.Show("Что-то пошло не так!");
			}

		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (npgSqlConnection != null)
				npgSqlConnection.Close();
		}
	}
}
