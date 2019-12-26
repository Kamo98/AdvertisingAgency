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
        //static String[] ClientsFields = { "Email","Address","FIO","PhoneNumber" };
        //static String[] OrdersFields = { "DateOfCreation", "PeriodOfExecution", "ExpirationDate", "Cost","ContractLink","ID_Client" };
        static ColumnDataGridViewWrapper[] ClientsFields = { new ColumnDataGridViewWrapper("fdf","ID_Client",FieldType.Id),
                                                             new ColumnDataGridViewWrapper("Почта","Email",FieldType.Text),
                                                             new ColumnDataGridViewWrapper("Адрес","Address",FieldType.Text),
                                                             new ColumnDataGridViewWrapper("Ф.И.О" , "FIO",FieldType.Text),
                                                             new ColumnDataGridViewWrapper("Телефон" , "PhoneNumber",FieldType.Integer) };
        static ColumnDataGridViewWrapper[] OrdersFields = {  new ColumnDataGridViewWrapper("Дата создания" ,"DateOfCreation",FieldType.Date),
                                                             new ColumnDataGridViewWrapper("Период выполнения","PeriodOfExecution",FieldType.Text),
                                                             new ColumnDataGridViewWrapper("Дата окончания", "ExpirationDate",FieldType.Date),
                                                             new ColumnDataGridViewWrapper("Цена", "Cost",FieldType.Integer),
                                                             new ColumnDataGridViewWrapper("Договор","ContractLink",FieldType.Text),
                                                             new ColumnDataGridViewWrapper("Клиент","ID_Client",FieldType.List,"select \"ID_Client\",\"FIO\" from  \"Client\"")};  
        DataGridViewWrapper gridWrapperClients;
        DataGridViewWrapper gridWrapperOrders;
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
            gridWrapperClients = new DataGridViewWrapper(dataGridViewClients,ParentLoginForm.Connection, "Client", ClientsFields);
            gridWrapperOrders = new DataGridViewWrapper(dataGridViewOrders, ParentLoginForm.Connection, "AdvertisingOrder", OrdersFields);

            UpdateClientsTable();
            UpdateOrdersTable();
        }

        private void UpdateClientsTable()
        {
            gridWrapperClients.UpdateTable();
        }

        private void UpdateOrdersTable()
        {
            gridWrapperOrders.UpdateTable();
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClientsSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());
        }
    }
}
