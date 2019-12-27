﻿using Npgsql;
using System;
using System.Data.Common;
using System.Windows.Forms;

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
        public AccessControl.Role Role { get; set; }

        public Employee(
                object id,
                object fio,
                object position,
                object id_dep,
                object active,
                object username = null)
        {
            ID = (int)id;
            FIO = (string)fio;
            Position = (string)position;
            ID_Dep = (int)id_dep;
            Active = (bool)active;
            if (username != DBNull.Value)
                Username = (string)username;
            else
                username = null;
            if (ID != 0 && username != null) {
                string query_roles = "select \"role_name\" from \"information_schema\".\"applicable_roles\" where \"grantee\" = '" + username + "';";
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query_roles, ConnectionSettings.npgSqlConnection);
                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
                
                if (npgSqlDataReader.HasRows)
                {
                    //Проходим по всем ролям авторизированного пользователя и заполняем Role
                    foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                        if (AccessControl.nameRole2idRole.ContainsKey(dbDataRecord["role_name"].ToString()))
                            Role |= AccessControl.nameRole2idRole[dbDataRecord["role_name"].ToString()];
                }
                npgSqlDataReader.Close();
            }
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