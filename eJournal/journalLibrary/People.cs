using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalLibrary
{
    public class People //класс для хранения информации о человеке(преподе или студенте)
    {
        public string name;
        public string surname;
        public string patronumic;
        public string information;
        public string login;
        public string phonenumber;
        public DateTime birthday;

        public string ConvertDate()// конвертирование даты в формат БД
        {
            string temp = String.Empty;
            temp = birthday.Year+ "." + birthday.Month + "." + birthday.Day.ToString(); 
            return temp;
        }
        public static string ConvertDate(DateTime t)
        {
            return t.Year + "." + t.Month + "." + t.Day;
        }

        public override string ToString()
        {
            return surname + " " + name + " " + patronumic;
        }
    }
}
