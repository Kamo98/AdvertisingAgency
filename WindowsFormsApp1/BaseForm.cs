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
        Form parentForm; 
        public BaseForm(Form parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void типыМатериаловToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void типыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из учётной записи?","Выход из учётной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                parentForm.Show();
            }
        }
    }
}
