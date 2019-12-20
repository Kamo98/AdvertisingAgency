using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace WindowsFormsApp1
{
    /*
     * Класс для настроек соединения
     */ 
    class ConnectionSettings
    {
        public static NpgsqlConnection npgSqlConnection { get; set; }
    }
}
