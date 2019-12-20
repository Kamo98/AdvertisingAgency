using Npgsql;
using System.Collections.Generic;
using System.Data.Common;

namespace WindowsFormsApp1.Entity
{
    /*
     * Класс-сущность для отдела
     */ 
    class Department : IEntity
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public int BossID { get; set; }

        public Department(int id, string name, int boss){
            ID = id;
            Name = name;
            BossID = boss;
        }

        // Функция сохранения сущности в БД
        public void Save()
        {
            string queue = "Update \"Department\" set \"Name\" = \'" + Name
                            + "\', \"ID_EmployeeBoss\" = " + BossID
                            + " where \"ID_Department\" = " + ID + ";";
            NpgsqlCommand command = new NpgsqlCommand(queue, ConnectionSettings.npgSqlConnection);
            command.ExecuteNonQuery();
        }

        public void AddNew()
        {
            throw new System.NotImplementedException();
        }
    }
}
