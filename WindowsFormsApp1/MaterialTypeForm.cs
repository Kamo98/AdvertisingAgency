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
    public partial class MaterialTypeForm : Form
    {

		static ColumnDataGridViewWrapper[] MaterialTypeFields = {
			new ColumnDataGridViewWrapper("ID_Type", "\"ID_Type\"",FieldType.Id),
			new ColumnDataGridViewWrapper("Тип материала", "\"Name\"",FieldType.Text)
		};

		static String[] ClientsFields = { "Name" };
		NpgsqlConnection connection;

		DataGridViewWrapper gridWrapperTypeMaterials;

		public MaterialTypeForm(NpgsqlConnection conn)
        {
            InitializeComponent();
			connection = conn;
			InitTable();
        }

		private void InitTable()
		{
			gridWrapperTypeMaterials = new DataGridViewWrapper(dataGridViewTypeMaterials, connection, "\"MaterialType\"", MaterialTypeFields);
			UpdateTable();

			dataGridViewTypeMaterials.ReadOnly = true;

			if ((ConnectionSettings.LoggedUser.Role & AccessControl.Role.production_officer) != 0)
				dataGridViewTypeMaterials.ReadOnly = false;
		}


		private void UpdateTable ()
		{
			gridWrapperTypeMaterials.UpdateTable();
		}

		private void buttonTypeMaterialsSave_Click(object sender, EventArgs e)
		{
			gridWrapperTypeMaterials.Commit();
		}
	}
}
