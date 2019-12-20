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
        static String[] ClientsFields = { "Email","Address","FIO","PhoneNumber" };
        static String[] OrdersFields = { "DateOfCreation", "PeriodOfExecution", "ExpirationDate", "Cost","ContractLink","ID_Client" };
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

        }



    }
}
