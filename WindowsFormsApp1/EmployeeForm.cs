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
    /*
     * Форма добавления сотрудника
     */ 
    public partial class EmployeeForm : Form
    {
        
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
