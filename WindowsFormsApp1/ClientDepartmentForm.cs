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
    //Интерфейс для отдела клиентов
    public partial class ClientDepartmentForm : BaseForm
    {
        public ClientDepartmentForm()
        {
            InitializeComponent();
        }

        public ClientDepartmentForm(Form1 parent) : base(parent)
        {
            InitializeComponent();
        }
    }
}
