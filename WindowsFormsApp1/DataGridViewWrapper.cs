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
        Date,
        Char,
        Float
    }

    //Пока передумал использовать этот класс, но возможно потом, когда-нибудь)
    class ColumnDataGridViewWrapper
    {
        String nameAs;
        String fieldName;
        FieldType type;

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


        public ColumnDataGridViewWrapper(String nameAs,String fieldName,FieldType type)
        {
            this.NameAs = nameAs;
            this.FieldName = fieldName;
            this.type = type;
        }
    }

    //Wrapper для DataGridView, для удаления,обновления, добавления строк.
    class DataGridViewWrapper
    {
        DataGridView grid;
        NpgsqlConnection connection; 
        String[] fields;    //Поля таблицы
        String tableName;   //Название таблицы

        public DataGridViewWrapper(DataGridView grid, NpgsqlConnection connection, String tableName ,String[] fields)
        {
            this.grid = grid;
            this.connection = connection;
            this.fields = fields;
            this.tableName = tableName;
        }

        //private DataGridViewColumn CreateColumn(FieldType type,String name)
        //{
        //    switch (type)
        //    {
        //        case FieldType.Date: return new DataGridViewColumn
        //    }
        //}

        //Заполняет DataGridView
        public void UpdateTable()
        {
            string query = "select ";
            int count = 0;
            foreach (String column in fields)
            {
                query += "\"" + column + "\"";
                if (++count != fields.Length) query += ",";
            }
            query += "from \"" + tableName + "\"";

            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, connection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
            {
                grid.Rows.Clear();
                object[] objects = fields;
                foreach (DbDataRecord oneRow in npgSqlDataReader)
                {           
                    oneRow.GetValues(objects);
                    grid.Rows.Add(objects);
                }
            }
            npgSqlDataReader.Close();
        }


    }
}
