using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    //Это относится к далее
    enum FieldType
    {
        Integer,
        Id,
        Date,
        Text,
        Float,
        List
    }

    //Пока передумал использовать этот класс, но возможно потом, когда-нибудь)
    class ColumnDataGridViewWrapper
    {
        String nameAs;
        String fieldName;
        FieldType type;
        String sqlQuery;

        public FieldType Type
        {
            get => type;
            set => type = value;
        }

        //Отоброжение названия столбца в таблице
        public String NameAs
        {
            get => nameAs;
            set => nameAs = value;
        }

        //Название поля в бд
        public String FieldName
        {
            get => fieldName;
            set => fieldName = value;
        }

        public String SqlQuery
        {
            get => sqlQuery;
            set => sqlQuery = value;
        }

        public ColumnDataGridViewWrapper(String nameAs,String fieldName,FieldType type)
        {
            this.NameAs = nameAs;
            this.FieldName = fieldName;
            this.type = type;
        }

        public ColumnDataGridViewWrapper(String nameAs, String fieldName, FieldType type, String query) : this(nameAs,fieldName,type)
        {
            this.sqlQuery = query;
        }
    }

    //Wrapper для DataGridView, для удаления,обновления, добавления строк.
    class DataGridViewWrapper
    {
        DataGridView grid;
        NpgsqlConnection connection;
        //String[] fields;    //Поля таблицы
        ColumnDataGridViewWrapper[] fields;
        String tableName;   //Название таблицы
        DataGridViewColumn IdColumn;

        public DataGridViewWrapper(DataGridView grid, NpgsqlConnection connection, String tableName, ColumnDataGridViewWrapper[] fields)
        {
            this.grid = grid;
            this.connection = connection;
            this.fields = fields;
            this.tableName = tableName;
            Initialize();
        }

        private DataGridViewColumn CreateColumn(FieldType type)
        {
            switch (type)
            {
                case FieldType.Date: return new DataGridViewDateColumn();
                case FieldType.Integer: return new DataGridViewNumberColumn();
                case FieldType.Text:return new DataGridViewTextBoxColumn();
                case FieldType.List: return new DataGridViewComboBoxColumn();
                case FieldType.Id: return new DataGridViewTextBoxColumn();
            }
            return null;
        }


        private Dictionary<int, String> getComboBoxFromQuery(String query)
        {
            Dictionary<int, String> result = new Dictionary<int, String>();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, connection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
            {
                grid.Rows.Clear();
                object[] objects = fields;
                foreach (DbDataRecord oneRow in npgSqlDataReader)
                    result.Add((int)oneRow.GetValue(0), (String)oneRow.GetValue(1));
            }
            npgSqlDataReader.Close();
            return result;
        }

        Dictionary<int, Dictionary<int, String>> ComboBoxes;
        private void Initialize()
        {
            if (grid.Columns.Count != 0) grid.Columns.Clear();
            ComboBoxes = new Dictionary<int, Dictionary<int, String>>();

            int columnWidth = (grid.Width - grid.RowHeadersWidth) / (fields.Length - 1);
            int count = 0;

            foreach (ColumnDataGridViewWrapper field in fields)
            {
                DataGridViewColumn col = CreateColumn(field.Type);
                col.Name = field.NameAs;
                col.Width = columnWidth;
                if (field.Type == FieldType.List)
                {
                    Dictionary<int, String> ComboBox = getComboBoxFromQuery(field.SqlQuery);
                    ComboBoxes.Add(count,ComboBox);
                    foreach(var el in ComboBox)
                        ((DataGridViewComboBoxColumn)col).Items.Add(el.Value);
                }
                else if (field.Type == FieldType.Id)
                {
                    IdColumn = col;
                    col.Visible = false;
                }
                grid.Columns.Add(col);
                count++;
            }
        }

        //Заполняет DataGridView
        public void UpdateTable()
        {
            string query = "select ";
            int count = 0;
            foreach (ColumnDataGridViewWrapper column in fields)
            {
                query += "\"" + column.FieldName + "\"";
                if (++count != fields.Length) query += ",";
            }
            query += "from \"" + tableName + "\"";

            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, connection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
            {
                grid.Rows.Clear();
                object[] objects = new object[fields.Length];
                foreach (DbDataRecord oneRow in npgSqlDataReader)
                {
                    oneRow.GetValues(objects);
                    count = 0;
                    foreach(ColumnDataGridViewWrapper col in fields)
                    {
                        if(col.Type == FieldType.List)
                            objects[count] = ComboBoxes[count][(int)objects[count]];
                        count++;
                    }

                    grid.Rows.Add(objects);
                }
            }
            npgSqlDataReader.Close();
        }


    }
}
