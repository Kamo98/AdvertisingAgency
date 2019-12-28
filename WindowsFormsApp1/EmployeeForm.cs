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
            FIOInput.KeyPress           += UsefullFunctions.lettersOnly;
            FIOInput.KeyPress           += UsefullFunctions.SpaceController;
            LoginBox.KeyPress           += UsefullFunctions.noSpaces;
            LoginBox.KeyPress           += UsefullFunctions.SpaceController;

            FIOInput.Enter              += UsefullFunctions.OnSetFocus;
            positionInput.Enter         += UsefullFunctions.OnSetFocus;
            departmentComboBox.Enter    += UsefullFunctions.OnSetFocus;
            LoginBox.Enter              += UsefullFunctions.OnSetFocus;
            PassBox.Enter               += UsefullFunctions.OnSetFocus;

            FIOInput.Leave              += UsefullFunctions.OnDropFocus;
            FIOInput.Leave              += UsefullFunctions.DelLastSpace;
            positionInput.Leave         += UsefullFunctions.OnDropFocus;
            departmentComboBox.Leave    += UsefullFunctions.OnDropFocus;
            LoginBox.Leave              += UsefullFunctions.OnDropFocus;
            LoginBox.Leave              += UsefullFunctions.DelLastSpace;
            PassBox.Leave               += UsefullFunctions.OnDropFocus;

        }

        public EmployeeForm()
        {
            InitializeComponent();
            AdditionalInit();
            SetDepartmentResource();
            currentEmployee = null;

            RoleLabel.Visible = false;
            rolePanel.Visible = false;

            this.Height = 500;
            BlockedFlag.Visible = false;
        }
        
        /*
         * Конструктор формы для редактирования
         */
        public EmployeeForm(int emp_id) : this() {
            if (emp_id > 0) {
                rolePanel.Visible = RoleLabel.Visible = BlockedFlag.Visible = true;
                Height = 620;
            }
            currentEmployee = DBWork.GetEmployee(emp_id);

            /*
             * Считываем роли и устанавливаем соответствующие флаги
             * */
            if ((currentEmployee.Role & AccessControl.Role.administrative_officer) != 0) {
                administrativeOfficerCheck.CheckState = CheckState.Checked;
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

            /*
             * Устанавливаем остальные данные
             * */
            FIOInput.Text = currentEmployee.FIO;
            positionInput.Text = currentEmployee.Position;
            departmentComboBox.SelectedValue = currentEmployee.ID_Dep;
            if (currentEmployee.Username != null) {
                LoginBox.Text = currentEmployee.Username;
            }
            if (currentEmployee.Active)
                BlockedFlag.CheckState = CheckState.Unchecked;
            else
                BlockedFlag.CheckState = CheckState.Checked;

            /*
             * Заблокируемвозможность смены логина
             * */
            if (currentEmployee.Username != null)
                LoginBox.Enabled = false;
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
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
                currentEmployee = new Employee(0, FIOInput.Text,
                    positionInput.Text, (int)departmentComboBox.SelectedValue, true, login);
                try
                {
                    currentEmployee.AddNew();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Clear();
                MessageBox.Show("Сотрудник зарегистрировани", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*
             *Редактирование данных о сотруднике
             */
            else {
                if (chiefAgencyCheck.CheckState == CheckState.Checked)
                    role |= AccessControl.Role.chief_of_agency;
                if (chiefDepartmentCheck.CheckState == CheckState.Checked)
                    role |= AccessControl.Role.chief_of_department;
                if (administrativeOfficerCheck.CheckState == CheckState.Checked)
                    role |= AccessControl.Role.administrative_officer;
                if (creativeOfficerCheck.CheckState == CheckState.Checked)
                    role |= AccessControl.Role.creative_officer;
                if (customerRelationsOfficerCheck.CheckState == CheckState.Checked)
                    role |= AccessControl.Role.customer_relations_officer;
                if (mediaOfficerCheck.CheckState == CheckState.Checked)
                    role |= AccessControl.Role.media_officer;
                if (productionOfficerCheck.CheckState == CheckState.Checked)
                    role |= AccessControl.Role.production_officer;

                currentEmployee.FIO = FIOInput.Text;
                currentEmployee.Position = positionInput.Text;
                currentEmployee.ID_Dep = (int)departmentComboBox.SelectedValue;
                currentEmployee.Role = role;
                if (LoginBox.Text == "") {
                    currentEmployee.Username = null;
                }
                if (PassBox.Text != "") {
                    DBWork.ChangeUserPassword(currentEmployee.Username, PassBox.Text);
                }
                currentEmployee.Save();
                MessageBox.Show("Изменения внесены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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
            if (FIOInput.Text == string.Empty)
            {
                valid = false;
                FIOInput.BackColor = Color.LightCoral;
            }
            return valid;
        }

        private void Clear() {
            FIOInput.Clear();
            positionInput.Clear();
            LoginBox.Clear();
            PassBox.Clear();
        }

    }
}
