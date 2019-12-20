using Npgsql;
using System;

namespace WindowsFormsApp1.Entity
{
    /*
     * Класс-сущность сотрудника
     */
    class Employee : IEntity
    {
        public int ID { get; private set; }
        public string FIO { get; set; }
        public string Position { get; set; }
        public int ID_Dep { get; set; }
        public bool Active { get; set; }
        public string Username { get; set; }

        public Employee(
                int id,
                string fio,
                string position,
                int id_dep,
                bool active = true,
                string username = null)
        {
            ID = id;
            FIO = fio;
            Position = position;
            ID_Dep = id_dep;
            Active = active;
            Username = username;
        }

        public void Save()
        {
            string queue = "Update \"Employee\" set \"FIO\" = \'" + FIO
                            + "\', \"Position\" = \'" + Position
                            + "\', \"ID_Department\" = " + ID_Dep 
                            + ", \"Active\" = " + Active.ToString() 
                            + ", \"Username\" = " + Username + " where \"ID_Employee = " + ID + ";";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(queue, ConnectionSettings.npgSqlConnection);
            npgsqlCommand.ExecuteNonQuery();
        }

        public void AddNew()
        {
            string queue = "Insert into \"Employee\"(\"FIO\", \"Position\", \"ID_Department\", \"Active\") values(\'"
                + FIO + "\', \'" + Position + "\', " + ID_Dep + ", " + Active.ToString() + ");";
            NpgsqlCommand command = new NpgsqlCommand(queue, ConnectionSettings.npgSqlConnection);
            command.ExecuteNonQuery();
        }
    }
}
