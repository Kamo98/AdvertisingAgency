using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1
{
    class DBWork
    {
        private static string queue;
        private static NpgsqlCommand command;
        private static NpgsqlDataReader reader;

        /*
         * Проверяем наличие пользователя в БД
         */
        public static bool HasUser(string username) {
            bool result;
            queue = "Select * from \"pg_roles\" where \"rolname\" = \'" + username + "\';";
            command = new NpgsqlCommand(queue, ConnectionSettings.npgSqlConnection);
            reader = command.ExecuteReader();
            result = reader.HasRows;
            reader.Close();
            return result;
        }

        /*
         * Создаем пользователя в БД
         */
        public static void CreateUser(string username, string password, AccessControl.Role role = 0) {
            queue = "Create user " + username + " with password \'" + password + "\'";
            command = new NpgsqlCommand(queue, ConnectionSettings.npgSqlConnection);
            command.ExecuteNonQuery();
            for (int i = 1; i <= 128; i *= 2) {
                
                string roleName = AccessControl.idRole2nameRole[(AccessControl.Role)i];
                if ((i & (int)role) != 0) {
                    queue = "grant \"" + roleName + "\" To \"" + username + "\"";
                    command = new NpgsqlCommand(queue, ConnectionSettings.npgSqlConnection);
                    command.ExecuteNonQuery();
                }
            }

        }

        /*
         * Получить сотрудника по ID
         * */
        public static Employee GetEmployee(int id) {
            Employee emp = null;
            queue = "Select * from \"Employee\" where \"ID_Employee\" = " + id;
            command = new NpgsqlCommand(queue, ConnectionSettings.npgSqlConnection);
            reader = command.ExecuteReader();
            if (reader.HasRows) {
                foreach (DbDataRecord record in reader)
                {
                    reader.Close();
                    emp = new Employee(
                        id,
                        record["FIO"],
                        record["Position"],
                        record["ID_Department"],
                        record["Active"],
                        record["Username"]);
                }
            }
            //reader.Close();
            return emp;
        }
    }
}
