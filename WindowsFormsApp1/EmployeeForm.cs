using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1
{
    /*
     * Форма добавления сотрудника
     */ 
    public partial class EmployeeForm : Form
    {
        private Employee currentEmployee;        //ID сотрудника, запись о котором планируется изменить

        /*
         * Дополнительная настройка объектов форм
         * Используется, так как автогенератор может перетереть ручные настройки
         */
        private void AdditionalInit()
        {
            firstNameInput.KeyPress     += UsefullFunctions.lettersOnly;
            lastNameInput.KeyPress    += UsefullFunctions.lettersOnly;
            pathronymicInput.KeyPress   += UsefullFunctions.lettersOnly;
            LoginBox.KeyPress           += UsefullFunctions.noSpaces;

            firstNameInput.Enter        += UsefullFunctions.OnSetFocus;
            lastNameInput.Enter       += UsefullFunctions.OnSetFocus;
            pathronymicInput.Enter      += UsefullFunctions.OnSetFocus;
            positionInput.Enter         += UsefullFunctions.OnSetFocus;
            departmentComboBox.Enter    += UsefullFunctions.OnSetFocus;
            LoginBox.Enter              += UsefullFunctions.OnSetFocus;
            PassBox.Enter               += UsefullFunctions.OnSetFocus;

            firstNameInput.Leave        += UsefullFunctions.OnDropFocus;
            lastNameInput.Leave       += UsefullFunctions.OnDropFocus;
            pathronymicInput.Leave      += UsefullFunctions.OnDropFocus;
            positionInput.Leave         += UsefullFunctions.OnDropFocus;
            departmentComboBox.Leave    += UsefullFunctions.OnDropFocus;
            LoginBox.Leave              += UsefullFunctions.OnDropFocus;
            PassBox.Leave               += UsefullFunctions.OnDropFocus;

        }

        public EmployeeForm()
        {
            InitializeComponent();
            AdditionalInit();
            SetDepartmentResource();
            currentEmployee = null;

            RoleLabel.Hide();
            rolePanel.Hide();
        }
        
        public EmployeeForm(int emp_id) : this() {
            if (emp_id > 0) {
                rolePanel.Show();
                RoleLabel.Show();
            }
            currentEmployee = DBWork.GetEmployee(emp_id);

            if ((currentEmployee.Role & AccessControl.Role.administrative_officer) != 0) {
                administratieOfficerCheck.CheckState = CheckState.Checked;
            }
            if ((currentEmployee.Role & AccessControl.Role.chief_of_agency) != 0)
            {
                chiefAgencyCheck.CheckState = CheckState.Checked;
            }
            if ((currentEmployee.Role & AccessControl.Role.chief_of_department) != 0)
            {
                chiefDepartmentCheck.CheckState = CheckState.Checked;
            }
            if ((currentEmployee.Role & AccessControl.Role.creative_officer) != 0)
            {
                creativeOfficerCheck.CheckState = CheckState.Checked;
            }
            if ((currentEmployee.Role & AccessControl.Role.production_officer) != 0)
            {
                productionOfficerCheck.CheckState = CheckState.Checked;
            }
            if ((currentEmployee.Role & AccessControl.Role.media_officer) != 0)
            {
                mediaOfficerCheck.CheckState = CheckState.Checked;
            }
            if ((currentEmployee.Role & AccessControl.Role.customer_relations_officer) != 0)
            {
                customerRelationsOfficerCheck.CheckState = CheckState.Checked;
            }

            string[] fio_p = currentEmployee.FIO.Split();
            firstNameInput.Text = fio_p[1];
            lastNameInput.Text = fio_p[0];
            if (fio_p.Length >= 3)
            {
                pathronymicInput.Text = "";
                int i;
                for (i = 2; i < fio_p.Length - 1; i++)
                    pathronymicInput.Text += fio_p[i] + " ";
                pathronymicInput.Text += fio_p[i];
            }
            positionInput.Text = currentEmployee.Position;
            departmentComboBox.SelectedValue = currentEmployee.ID_Dep;
            if (currentEmployee.Username != null) {
                LoginBox.Text = currentEmployee.Username;
            }
            if (currentEmployee.Active)
                BlockedFlag.CheckState = CheckState.Unchecked;
            else
                BlockedFlag.CheckState = CheckState.Checked;
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BlockedFlag.Checked.ToString());
            Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            /*
             * Проверка введенных данных
             * */
            if (!Validate())
            {
                MessageBox.Show("Некоректные данные", "Предупреждение");
                return;
            }

            AccessControl.Role role = 0;

            /*
             * регистрация сотрудника
             * */
            if (currentEmployee == null)
            {
                string login;
                if (LoginBox.Text != "")
                {
                    login = LoginBox.Text;

                    switch (departmentComboBox.SelectedValue) {
                        case 1: role = AccessControl.Role.customer_relations_officer; break;
                        case 2: role = AccessControl.Role.creative_officer; break;
                        case 3: role = AccessControl.Role.production_officer; break;
                        case 4: role = AccessControl.Role.media_officer; break;
                        case 5: role = AccessControl.Role.administrative_officer; break;
                    }
                    /*
                     * Проверим, что логин свободен
                     *
                     * Если занят, выдадим сообщение об ошибке
                     * */
                    if (DBWork.HasUser(LoginBox.Text))
                    {
                        MessageBox.Show("Логин занят", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        /*
                         * Иначе создадим пользователя БД с заданными логином и паролем
                         * */
                        DBWork.CreateUser(LoginBox.Text, PassBox.Text, role);
                    }
                }
                else
                {
                    login = null;
                }
                currentEmployee = new Employee(0, lastNameInput.Text + " " + firstNameInput.Text + " " + pathronymicInput.Text,
                    positionInput.Text, (int)departmentComboBox.SelectedValue, true, login);
                try
                {
                    currentEmployee.AddNew();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            /*
             *Редактирование данных о сотруднике
             */
            else {
                if (chiefAgencyCheck.Checked)
                    role |= AccessControl.Role.chief_of_agency;
                if (chiefDepartmentCheck.Checked)
                    role |= AccessControl.Role.chief_of_department;
                if (administratieOfficerCheck.Checked)
                    role |= AccessControl.Role.administrative_officer;
                if (creativeOfficerCheck.Checked)
                    role |= AccessControl.Role.creative_officer;
                if (customerRelationsOfficerCheck.Checked)
                    role |= AccessControl.Role.customer_relations_officer;
                if (mediaOfficerCheck.Checked)
                    role |= AccessControl.Role.media_officer;
                if (productionOfficerCheck.Checked)
                    role |= AccessControl.Role.production_officer;
            }

            
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

        private bool Validate()
        {
            bool valid = true;

            if (firstNameInput.Text == string.Empty) {
                valid = false;
                firstNameInput.BackColor = Color.LightCoral;
            }
            if (lastNameInput.Text == string.Empty)
            {
                valid = false;
                lastNameInput.BackColor = Color.LightCoral;
            }
            return valid;
        }

    }
}
