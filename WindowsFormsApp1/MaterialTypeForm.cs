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
        static String qts(String val) => "\"" + val + "\"";
        static ColumnDataGridViewWrapper[] ClientsFields = { new ColumnDataGridViewWrapper("jff",qts("ID_Type"),FieldType.Id),
                                                             new ColumnDataGridViewWrapper("Наименование", qts("Name"), FieldType.Text) };
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
			gridWrapperTypeMaterials = new DataGridViewWrapper(dataGridViewTypeMaterials, connection, qts("MaterialType"), ClientsFields);
			UpdateTable();
		}


		private void UpdateTable ()
		{
			gridWrapperTypeMaterials.UpdateTable();
		}



	}
}
