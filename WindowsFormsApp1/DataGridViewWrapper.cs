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
    public enum FieldType
    {
        Integer,
        Id,
        Date,
        Text,
        Float,
        List,
        Bool
    }

    //Пока передумал использовать этот класс, но возможно потом, когда-нибудь)
    public class ColumnDataGridViewWrapper
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
    public class DataGridViewWrapper
    {
        DataGridView grid;
        NpgsqlConnection connection;
        ColumnDataGridViewWrapper[] fields; //Поля таблицы
        String tableName;   //Название таблицы
        int IdColumn = -1;  //Индекс колонки,где есть id
        Dictionary<int, Dictionary<int, String>> ComboBoxes; //Комбо-боксы нормальные
        Dictionary<int, Dictionary<String, int>> ComboBoxesInverted; //Комбо-боксы инвертированные
        //List<String> updateQueries; //Запросы на обновление
        Dictionary<int, String> updateQueries;
        Dictionary<int, String> insertQueries; //Запросы на добавление
        Dictionary<int, String> deleteQueries; //Запросы на удаление
        int insertedSeq; //Индексация для новых строк, находится в отрицательных значениях для их индентификации
        String where = "";

        public DataGridViewWrapper(DataGridView grid, NpgsqlConnection connection, String tableName, ColumnDataGridViewWrapper[] fields)
        {
            this.grid = grid;
            this.connection = connection;
            this.fields = fields;
            this.tableName = tableName;
            Initialize();
        }

        public DataGridViewWrapper(DataGridView grid, NpgsqlConnection connection, String tableName, ColumnDataGridViewWrapper[] fields,String where)
            :this(grid,connection,tableName,fields)
        {
            this.where = where;
        }

        //Создаёт столбец указанного типа
        private DataGridViewColumn CreateColumn(FieldType type)
        {
            switch (type)
            {
                case FieldType.Date: return new DataGridViewDateColumn();
                case FieldType.Integer: return new DataGridViewNumberColumn();
                case FieldType.Text:return new DataGridViewTextBoxColumn();
                case FieldType.List: return new DataGridViewComboBoxColumn();
                case FieldType.Id: return new DataGridViewTextBoxColumn();
                case FieldType.Bool: return new DataGridViewCheckBoxColumn();
                default: return null;
            }
        }

        /*Возвращает словарь комбо-бокса по строке sql запроса,
         * где ключ содержимое первого столбца, а значение - второго*/
        private Dictionary<int, String> getComboBoxFromQuery(String query)
        {
            Dictionary<int, String> result = new Dictionary<int, String>();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, connection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
            {
                foreach (DbDataRecord oneRow in npgSqlDataReader)
                    result.Add((int)oneRow.GetValue(0), (String)oneRow.GetValue(1));
            }
            npgSqlDataReader.Close();
            return result;
        }
        
        private void Initialize()
        {
            //Ставим хендлеры обработки событии редактирования
            grid.CellBeginEdit += new DataGridViewCellCancelEventHandler(OnBeginEdit);
            grid.CellEndEdit += new DataGridViewCellEventHandler(OnEndEdit);
            grid.RowsAdded += new DataGridViewRowsAddedEventHandler(OnInsert);
            grid.UserDeletingRow += new DataGridViewRowCancelEventHandler(OnDelete);

            if (grid.Columns.Count != 0) grid.Columns.Clear();
            ComboBoxes = new Dictionary<int, Dictionary<int, String>>();
            ComboBoxesInverted = new Dictionary<int, Dictionary<String, int>>();
            insertedSeq = 0;
            grid.AllowUserToAddRows = false;

            //Устанавливаем одинаковую ширину для каждого столбца
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

                    /*Получаем по два Dictionary для одного комбо-бокса,
                     * один нормальный, другой инвертированный (Согласен, не много костыльно, но так надо)*/
                    ComboBoxes.Add(count,ComboBox);
                    ComboBoxesInverted.Add(count,ComboBox.ToDictionary(x => x.Value, y => y.Key));

                    //Заливаем в столбец значения комбо-бокса
                    foreach (var el in ComboBox)
                        ((DataGridViewComboBoxColumn)col).Items.Add(el.Value);
                }
                else if (field.Type == FieldType.Id)
                {
                    IdColumn = count;
                    col.Visible = false;
                }
                grid.Columns.Add(col);
                count++;
            }
        }

        object value; //Сюда ловим значение из ячейки
        //Сохраняем текущее значение ячейки, при старте редактирования её
        void OnBeginEdit(object sender,DataGridViewCellCancelEventArgs args)
        {
            value = grid.Rows[args.RowIndex].Cells[args.ColumnIndex].Value;
        }

        //Оборачивает строку в апострофы
        String atp(String val) => "'" + val + "'";

        //Возвращает id из комбо-бокса, указанной ячейки
        int getComboBoxValue(int row, int col)
        {
            return ComboBoxesInverted[col][grid.Rows[row].Cells[col].Value.ToString()];
        }

        void OnEndEdit(object sender, DataGridViewCellEventArgs args)
        {
            int index;
            if (grid.Rows[args.RowIndex].Cells[args.ColumnIndex].Value != value)
            {
                index = Int32.Parse(grid.Rows[args.RowIndex].Cells[IdColumn].Value.ToString());
                if (index < 0)
                {
                    insertQueries[index] = makeInsertQuery(grid.Rows[args.RowIndex]);
                }
                else
                {
                    String update = "update " + tableName + " set "
                            + fields[args.ColumnIndex].FieldName + " = " +
                            (fields[args.ColumnIndex].Type == FieldType.List ?
                            getComboBoxValue(args.RowIndex, args.ColumnIndex).ToString() :
                            atp(grid.Rows[args.RowIndex].Cells[args.ColumnIndex].Value.ToString())) +
                            " where " + fields[IdColumn].FieldName + " = " + index + "; ";


                    if (!updateQueries.ContainsKey(index)) 
                        updateQueries.Add(index, update);
                    else
                        updateQueries[index] += update;

                    //updateQueries.Add("update " + tableName + " set "
                    //    + fields[args.ColumnIndex].FieldName + " = " +
                    //    ( fields[args.ColumnIndex].Type == FieldType.List ?
                    //    getComboBoxValue(args.RowIndex, args.ColumnIndex).ToString() :
                    //    atp(grid.Rows[args.RowIndex].Cells[args.ColumnIndex].Value.ToString())) +
                    //    " where " + fields[IdColumn].FieldName + " = " + index);
                }
            }
        }

        //формирует строку запроса на вставку
        String makeInsertQuery(DataGridViewRow row)
        {
            int ind = 0;
            int add = HasIdColumn ? -1 : 0;
            String values = " values (";
            String columns = "insert into " + tableName + "(";
            bool hasForInsert = false;
            foreach (ColumnDataGridViewWrapper col in fields)
            {
                object value = row.Cells[ind++].Value;
                if (col.Type == FieldType.Id ||value  == null) continue;
                hasForInsert = true;
                values += atp(col.Type == FieldType.List? ComboBoxesInverted[ind][value.ToString()].ToString() : value.ToString()) + ",";
                columns += col.FieldName + ",";
                ind++;
            }
            values = values.Trim(',');
            columns = columns.Trim(',');
            if (!hasForInsert) return null;
            values += ")";
            columns += ")";
            return columns + values;
        }

        void OnInsert(object sender, DataGridViewRowsAddedEventArgs args)
        {
            if (updateQueries == null) return;
            for (int i = 0; i < args.RowCount; i++)
            {
                insertQueries.Add(--insertedSeq, makeInsertQuery(grid.Rows[args.RowIndex + i]));
                grid.Rows[args.RowIndex + i].Cells[IdColumn].Value = insertedSeq;
            }
        }

        void OnDelete(object sender, DataGridViewRowCancelEventArgs args)
        {
            if (deleteQueries == null) return;
            int index = Int32.Parse(args.Row.Cells[IdColumn].Value.ToString());
            if (index < 0)
                insertQueries.Remove(index);
            else
            {
                try
                {
                    updateQueries.Remove(index);
                }
                catch
                {

                }
                deleteQueries.Add(index, "delete from " + tableName + " where " + fields[IdColumn].FieldName + " = " + index);
            }
        }

        //Заполняет DataGridView
        public void UpdateTable()
        {
            string query = "select ";
            int count = 0;
            foreach (ColumnDataGridViewWrapper column in fields)
            {
                query += column.FieldName;
                if (++count != fields.Length) query += ",";
            }
            query += "from " + tableName + " "+ where;

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
            updateQueries = new Dictionary<int, String>();
            insertQueries = new Dictionary<int, String>();
            deleteQueries = new Dictionary<int, String>();
            npgSqlDataReader.Close();
        }

        //Коммит, все запросы отправляются в бд
        public void Commit()
        {
            foreach (var query in updateQueries)
                if (query.Value != null)
                    new NpgsqlCommand(query.Value,connection).ExecuteNonQuery();

            foreach (var query in insertQueries)
                if (query.Value != null)
                    new NpgsqlCommand(query.Value, connection).ExecuteNonQuery();

            foreach(var query in deleteQueries)
                if (query.Value != null)
                    new NpgsqlCommand(query.Value,connection).ExecuteNonQuery();

            updateQueries.Clear();
            insertQueries.Clear();
            deleteQueries.Clear();
            updateQueries = null;
            insertQueries = null;
            deleteQueries = null;
        }

        //Возвращает true, если у таблицы есть колонка с id
        public bool HasIdColumn => IdColumn != -1;
    }
}
