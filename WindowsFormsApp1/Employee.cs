using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace WindowsFormsApp1
{
    //Класс для сотрудников, содержит все поля что и в бд
    public class Employee
    {
        String name;
        String position;

        public String Position
        {
            get => position;
            set => position = value;
        }

        public String FIO
        {
            get => name;
            set => name = value;
        }

        public Employee(DbDataRecord record)
        {
            this.FIO = record["FIO"].ToString(); 
            this.Position = record["Position"].ToString();
        }

        public Employee(String FIO,String position)
        {
            this.FIO = FIO;
            this.Position = position;
        }
    }
}
