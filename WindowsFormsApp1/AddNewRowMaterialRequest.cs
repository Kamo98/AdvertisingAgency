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

namespace WindowsFormsApp1
{
	public partial class AddNewRowMaterialRequest : Form
	{
		private NpgsqlConnection connection;

		List<String> materials;
		Dictionary<String, int> material2Id;
		Form parent;
		int idRequest;

		public AddNewRowMaterialRequest(NpgsqlConnection connection, Form parent, int idRequest)
		{
			InitializeComponent();

			this.connection = connection;
			this.parent = parent;
			this.idRequest = idRequest;

			materials = new List<string>();
			material2Id = new Dictionary<string, int>();

			NpgsqlCommand npgSqlCommand = new NpgsqlCommand("Select \"Name\", \"ID_Material\" from \"Material\"", connection);
			NpgsqlDataReader npgSqlDataReader2 = npgSqlCommand.ExecuteReader();
			if (npgSqlDataReader2.HasRows)
				foreach (DbDataRecord oneRow in npgSqlDataReader2)
				{
					materials.Add(oneRow.GetValue(0).ToString());
					material2Id[oneRow.GetValue(0).ToString()] = Int32.Parse(oneRow.GetValue(1).ToString());
				}
			npgSqlDataReader2.Close();

			this.comboBoxMaterial.Items.AddRange(materials.ToArray());
		}

		private void btn_AddNewRowMaterial_Click(object sender, EventArgs e)
		{
			int amount  = 0;
			bool parse = Int32.TryParse(textBoxAmount.Text, out amount);
			if (parse)
			{
				if (textBoxUnit.Text != "")
				{
					if (comboBoxMaterial.Text != "")
					{
						String query = "insert into \"RowMaterialRequest\" " +
							"(\"Amount\", \"Unit\", \"ID_Material\", \"ID_MaterialRequest\", \"Ready\")" +
							" values ('" + amount + "', '" + textBoxUnit.Text + "', '"
							+ material2Id[comboBoxMaterial.Text] + "', '" + idRequest + "', 'false')";

						new NpgsqlCommand(query, connection).ExecuteNonQuery();
						this.Close();
						parent.Show();
					}
					else
						MessageBox.Show("Не заполнено поле материал");
				} else
					MessageBox.Show("Не заполнено поле еденица измерения");
			}
			else
				MessageBox.Show("Количество не является целым числом");
		}

		private void AddNewRowMaterialRequest_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Close();
			parent.Show();
		}
	}
}
