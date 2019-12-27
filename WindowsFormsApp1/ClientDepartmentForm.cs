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
        static String qts(String val) => "\"" + val + "\"";
        static ColumnDataGridViewWrapper[] ClientsFields = { new ColumnDataGridViewWrapper("fdf",qts("ID_Client"),FieldType.Id),
                                                             new ColumnDataGridViewWrapper("Почта",qts("Email"),FieldType.Text),
                                                             new ColumnDataGridViewWrapper("Адрес",qts("Address"),FieldType.Text),
                                                             new ColumnDataGridViewWrapper("Ф.И.О" , qts("FIO"),FieldType.Text),
                                                             new ColumnDataGridViewWrapper("Телефон" , qts("PhoneNumber"),FieldType.Integer) };
        static ColumnDataGridViewWrapper[] OrdersFields = {  new ColumnDataGridViewWrapper("ID_Orders",qts("ID_Order"),FieldType.Id),
                                                             new ColumnDataGridViewWrapper("Дата создания" ,qts("DateOfCreation"),FieldType.Date),
                                                             new ColumnDataGridViewWrapper("Период выполнения",qts("PeriodOfExecution"),FieldType.Text),
                                                             new ColumnDataGridViewWrapper("Дата окончания", qts("ExpirationDate"),FieldType.Date),
                                                             new ColumnDataGridViewWrapper("Цена", qts("Cost"),FieldType.Integer),
                                                             new ColumnDataGridViewWrapper("Договор",qts("ContractLink"),FieldType.Text),
                                                             new ColumnDataGridViewWrapper("Клиент",qts("ID_Client"),FieldType.List,"select \"ID_Client\",\"FIO\" from  \"Client\"")};
        static ColumnDataGridViewWrapper[] ProjectsFields = {   new ColumnDataGridViewWrapper("ID_Project",qts("ID_Project"),FieldType.Id),
                                                                new ColumnDataGridViewWrapper("Дата создания" ,qts("DateOfCreation"),FieldType.Date),
                                                                new ColumnDataGridViewWrapper("Концепт",qts("Concept"),FieldType.Text),
                                                                new ColumnDataGridViewWrapper("Дата окончания", qts("ExpirationDate"),FieldType.Date),
                                                                new ColumnDataGridViewWrapper("Этап выполнения", qts("ExecutionStage"),FieldType.Integer),
                                                                new ColumnDataGridViewWrapper("Тех. задание",qts("TechnicalTask"),FieldType.Text),
                                                                new ColumnDataGridViewWrapper("Заказ",qts("ID_Order"),FieldType.List,"select \"ID_Order\",\"ContractLink\" from  \"AdvertisingOrder\"")};
        DataGridViewWrapper gridWrapperClients;
        DataGridViewWrapper gridWrapperOrders;
        DataGridViewWrapper gridWrapperProjects;
        public ClientDepartmentForm()
        {
            InitializeComponent();
            InitTables();
        }

        public ClientDepartmentForm(Form1 parent) : base(parent)
        {           
            InitializeComponent();
            InitTables();
        }

        private void InitTables()
        {
            gridWrapperClients = new DataGridViewWrapper(dataGridViewClients,ParentLoginForm.Connection, qts("Client"), ClientsFields);
            gridWrapperOrders = new DataGridViewWrapper(dataGridViewOrders, ParentLoginForm.Connection, qts("AdvertisingOrder"), OrdersFields);
            gridWrapperProjects = new DataGridViewWrapper(dataGridViewProjects, ParentLoginForm.Connection, qts("PromotionalProject"), ProjectsFields);

            gridWrapperClients.UpdateTable();
            gridWrapperOrders.UpdateTable();
            gridWrapperProjects.UpdateTable();

            dataGridViewOrders.Columns["Дата окончания"].ReadOnly = true;
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClientsSave_Click(object sender, EventArgs e)
        {
            gridWrapperClients.Commit();
            MessageBox.Show("Таблица сохранена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.Rows.Add();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            dataGridViewClients.Rows.Add();
        }

        private void buttonOrdersSave_Click(object sender, EventArgs e)
        {
            gridWrapperOrders.Commit();
            MessageBox.Show("Таблица сохранена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClientsUpdate_Click(object sender, EventArgs e)
        {
            gridWrapperClients.UpdateTable();
            MessageBox.Show("Таблица обновлена","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonOrdersUpdate_Click(object sender, EventArgs e)
        {
            gridWrapperOrders.UpdateTable();
            MessageBox.Show("Таблица обновлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonProjectUpdate_Click(object sender, EventArgs e)
        {
            gridWrapperProjects.UpdateTable();
            MessageBox.Show("Таблица обновлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonProjectSave_Click(object sender, EventArgs e)
        {
            gridWrapperProjects.Commit();
            MessageBox.Show("Таблица сохранена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonProjectAdd_Click(object sender, EventArgs e)
        {
            AddProjectForm form = new AddProjectForm(gridWrapperProjects.getComboBox(6));
            form.ShowDialog();
            if (form.AddRow) 
                dataGridViewProjects.Rows.Add(form.RowToInsert);
        }
    }
}
