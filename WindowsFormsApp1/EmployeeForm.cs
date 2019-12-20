using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entity;

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
            SetDepartmentResource();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Employee newEmp = new Employee(0, secondNameInput.Text + " " + firstNameInput.Text + " " + pathronymicInput.Text,
                positionInput.Text, (int)departmentComboBox.SelectedValue);
            newEmp.AddNew();
            // Нужно продумать как создавать юзера в БД
        }

        private void SetDepartmentResource() {
            string query = "select * from \"Department\";";
            List<Department> departments = new List<Department>();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, ConnectionSettings.npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows) {
                foreach (DbDataRecord oneDep in npgSqlDataReader) {
                    departments.Add(new Department((int)oneDep[0], oneDep[1].ToString(), (int)oneDep[2]));
                }
                departmentComboBox.DataSource = departments;
                departmentComboBox.DisplayMember = "Name";
                departmentComboBox.ValueMember = "ID";
            }
            npgSqlDataReader.Close();
        }

    }
}
