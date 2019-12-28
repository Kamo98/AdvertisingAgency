using Npgsql;
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
	public partial class TypeOfProduct : Form
	{
		static ColumnDataGridViewWrapper[] ProductTypeFields = {
			new ColumnDataGridViewWrapper("ID_Type", "\"ID_Type\"",FieldType.Id),
			new ColumnDataGridViewWrapper("Тип продукта", "\"Name\"",FieldType.Text)
		};

		static String[] ClientsFields = { "Name" };
		NpgsqlConnection connection;

		DataGridViewWrapper gridWrapperTypeProduct;

		public TypeOfProduct(NpgsqlConnection conn)
		{
			InitializeComponent();
			connection = conn;
			InitTable();
		}

		private void InitTable()
		{
			gridWrapperTypeProduct = new DataGridViewWrapper(dataGridViewTypeProducts, connection, "\"ProductType\"", ProductTypeFields);
			UpdateTable();

			dataGridViewTypeProducts.ReadOnly = true;

			if ((ConnectionSettings.LoggedUser.Role & AccessControl.Role.media_officer) != 0)
				dataGridViewTypeProducts.ReadOnly = false;
		}


		private void UpdateTable()
		{
			gridWrapperTypeProduct.UpdateTable();
		}

		private void buttonTypeMaterialsSave_Click(object sender, EventArgs e)
		{
			gridWrapperTypeProduct.Commit();
		}
	}
}
