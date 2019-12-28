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
using System.Collections;

namespace WindowsFormsApp1
{
	public partial class MaterialRequest : BaseForm
	{

		private NpgsqlConnection connection;

		List<String> materials;
		Dictionary<String, int> material2Id;
		int IdColumn = 0;
		int idRequset;		//Для табл строк



		public MaterialRequest(NpgsqlConnection connection, Form1 parent) : base(parent)
		{
			InitializeComponent();
			this.connection = connection;

			dataGridViewRowRequest.CellBeginEdit += new DataGridViewCellCancelEventHandler(OnBeginEdit);
			dataGridViewRowRequest.CellEndEdit += new DataGridViewCellEventHandler(OnEndEdit);

			dataGridViewMaterialRequest.ReadOnly = true;
			dataGridViewRowRequest.ReadOnly = true;
			buttonAddNewRowRequest.Enabled = false;

			if ((ConnectionSettings.LoggedUser.Role & AccessControl.Role.production_officer) != 0)
			{
				dataGridViewMaterialRequest.ReadOnly = false;
				dataGridViewRowRequest.ReadOnly = false;
				buttonAddNewRowRequest.Enabled = true;
			}

			InitTable(-1);
		}

		//Если нужны материалы по конкретному проекту
		public MaterialRequest(NpgsqlConnection connection, int idProject, Form1 parent) : base(parent)
		{
			InitializeComponent();
			this.connection = connection;
			InitTable(idProject);
		}


		private void InitTable(int idProject)
		{
			string query = "select \"MaterialRequest\".\"ID_MaterialRequest\", \"LastChange\", count(*) " +
				"from \"MaterialRequest\", \"RowMaterialRequest\"" +
				"where \"MaterialRequest\".\"ID_MaterialRequest\" = \"RowMaterialRequest\".\"ID_MaterialRequest\"";


            /*query = "select sum(mat.\"Cost\" * rmat.\"Amount\") from \"Material\" mat, \"RowMaterialRequest\" rmat,\"  where   mat.\"ID_Material\" = rmat.\"ID_Material\" and rmat.\"ID_MaterialRequest\" = req.\"ID_MaterialRequest\" ";
            new NpgsqlCommand(qu)*/
            if (idProject != -1)
				query += "and m.\"ID_Project\" = " + idProject;
			query += "group by \"MaterialRequest\".\"ID_MaterialRequest\"";

            

			NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, connection);
			NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
			if (npgSqlDataReader.HasRows)
			{
				dataGridViewMaterialRequest.Rows.Clear();
				object[] objects = new object[5];
				foreach (DbDataRecord oneRow in npgSqlDataReader)
				{
					oneRow.GetValues(objects);
					objects[3] = "просмотреть запрос";
                    objects[4] = 0;
					dataGridViewMaterialRequest.Rows.Add(objects);
				}
			}
			npgSqlDataReader.Close();

            

			materials = new List<string>();
			material2Id = new Dictionary<string, int>();

			npgSqlCommand = new NpgsqlCommand("Select \"Name\", \"ID_Material\" from \"Material\"", connection);
			NpgsqlDataReader npgSqlDataReader2 = npgSqlCommand.ExecuteReader();
			if (npgSqlDataReader2.HasRows)
				foreach (DbDataRecord oneRow in npgSqlDataReader2)
				{
					materials.Add(oneRow.GetValue(0).ToString());
					material2Id[oneRow.GetValue(0).ToString()] = Int32.Parse(oneRow.GetValue(1).ToString());
				}
			npgSqlDataReader2.Close();

			this.NameMaterialColumn1.Items.AddRange(materials.ToArray());

		}


		//Переход к просмотру строк запроса
		private void dataGridViewMaterialRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataGridViewMaterialRequest.ColumnCount - 2)
			{       //Клик по ссылке посмотреть запрос


				idRequset = Int32.Parse(dataGridViewMaterialRequest.Rows[e.RowIndex].Cells[0].Value.ToString());

				//Получить все строки, относящиеся к заданному запросу
				string query = "select \"RowMaterialRequest\".\"ID_MaterialRequestString\", \"Material\".\"Name\", \"MaterialType\".\"Name\", \"Amount\", \"Unit\", \"Ready\"" +
				"from \"Material\", \"RowMaterialRequest\", \"MaterialType\"" +
				"where \"Material\".\"ID_Material\" = \"RowMaterialRequest\".\"ID_Material\"" +
				"and \"MaterialType\".\"ID_Type\" = \"Material\".\"ID_Type\"" +
				"and \"RowMaterialRequest\".\"ID_MaterialRequest\" = " + idRequset;

				
				NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, connection);
				NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
				if (npgSqlDataReader.HasRows)
				{
					dataGridViewRowRequest.Rows.Clear();
					object[] objects = new object[6];
					foreach (DbDataRecord oneRow in npgSqlDataReader)
					{
						oneRow.GetValues(objects);
						dataGridViewRowRequest.Rows.Add(objects);
					}
				}
				npgSqlDataReader.Close();

				tabControl1.SelectedIndex = 1;
			}
		}


		object value; //Сюда ловим значение из ячейки
					  //Сохраняем текущее значение ячейки, при старте редактирования её
		void OnBeginEdit(object sender, DataGridViewCellCancelEventArgs args)
		{
			value = dataGridViewRowRequest.Rows[args.RowIndex].Cells[args.ColumnIndex].Value;
		}


		void OnEndEdit(object sender, DataGridViewCellEventArgs args)
		{
			int index;
			if (dataGridViewRowRequest.Rows[args.RowIndex].Cells[args.ColumnIndex].Value != value)
			{
				index = Int32.Parse(dataGridViewRowRequest.Rows[args.RowIndex].Cells[IdColumn].Value.ToString());
				if (index < 0)
				{
					//insertQueries[index] = makeInsertQuery(grid.Rows[args.RowIndex]);
				}
				else
				{
					string query = "";
					if (args.ColumnIndex == 1)
					{       //Изменение материала
						query = "update \"RowMaterialRequest\" set "
						+ "\"ID_Material\" = " + material2Id[dataGridViewRowRequest.Rows[args.RowIndex].Cells[1].Value.ToString()] +
						" where \"ID_MaterialRequestString\" = " + index;

						new NpgsqlCommand(query, connection).ExecuteNonQuery();
					} else if (args.ColumnIndex == 3)
					{       //Изменение кол-ва
						query = "update \"RowMaterialRequest\" set "
						+ "\"Amount\" = " + dataGridViewRowRequest.Rows[args.RowIndex].Cells[3].Value.ToString() +
						" where \"ID_MaterialRequestString\" = " + index;
						new NpgsqlCommand(query, connection).ExecuteNonQuery();
					} else if (args.ColumnIndex == 4)
					{       //Изменение ед изм
						query = "update \"RowMaterialRequest\" set "
						+ "\"Unit\" = " + dataGridViewRowRequest.Rows[args.RowIndex].Cells[4].Value.ToString() +
						" where \"ID_MaterialRequestString\" = " + index;
						new NpgsqlCommand(query, connection).ExecuteNonQuery();
					} else if (args.ColumnIndex == 5)
					{       //Выполнено
						query = "update \"RowMaterialRequest\" set "
						+ "\"Ready\" = " + Boolean.Parse(dataGridViewRowRequest.Rows[args.RowIndex].Cells[5].Value.ToString()) +
						" where \"ID_MaterialRequestString\" = " + index;
						new NpgsqlCommand(query, connection).ExecuteNonQuery();
					}
				}
			}
		}

		private void buttonAddNewRowRequest_Click(object sender, EventArgs e)
		{
			AddNewRowMaterialRequest modal = new AddNewRowMaterialRequest(connection, this, idRequset);
			this.Hide();
			modal.ShowDialog();
		}
	}
}
