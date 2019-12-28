using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //В этой форме указываем все общие элементы для всех интерфейсов
    public partial class BaseForm : Form
    {   
        /*Указатель на форму, породившую данную (форма с логином). Это поле предназаначено для того, 
         *чтобы вызвать форму логина при выходе из текущей учётной записи* */
        Form1 parentForm; 

        //Форма логина, породившая данную.
        public Form1 ParentLoginForm
        {
            get => parentForm;
            set => parentForm = value;
        }

        public BaseForm(Form1 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        protected override void OnClosed(EventArgs e)
        {
            parentForm.Show();
        }

        public BaseForm()
        {
            InitializeComponent();
        }

        private void типыМатериаловToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void типыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Close();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из учётной записи?", "Выход из учётной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ConnectionSettings.npgSqlConnection.Close();
                ConnectionSettings.npgSqlConnection = null;
                this.Close();
            }
        }

        private void текущийПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ФИО: " + ConnectionSettings.LoggedUser.FIO + "\n" +
                            "Должность: " + ConnectionSettings.LoggedUser.Position + "\n" +
                            "Участник групп: " + AccessControl.get_name_cur_role());
        }
        
		private void типыМатериаловToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MaterialTypeForm form = new MaterialTypeForm(ConnectionSettings.npgSqlConnection);
			form.ShowDialog();
		}

    }
}
