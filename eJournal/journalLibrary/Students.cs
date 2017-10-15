using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalLibrary
{
    public class Students:ConnectionDB
    {
        public void InsertStudent(People p,int idgr)    //Вставка студента в БД
        {
            string sql = "Insert Into Students" + $"(name,surname,patronumic,idgr,information,birthday,phonenumber,login) Values (N'{p.name}',N'{p.surname}',N'{p.patronumic}',{idgr},N'{p.information}','{p.ConvertDate()}','{p.phonenumber}','{p.login}')";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }

        public People Autorization(string login, string password)//Авторизация студента и получения данных
        {
            int i = 0;
            People student = new People();
            string sql = $"Select * from students where login='{login}' and password='{password}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())//Если студент есть в базе, то получаем его данные
                    {
                        student.name = (string)reader["name"];
                        student.surname = (string)reader["surname"];
                        student.patronumic = (string)reader["patronumic"];
                        student.birthday = (DateTime)reader["birthday"];
                        student.information = (string)reader["information"];
                        student.phonenumber = (string)reader["phonenumber"];
                        i++;
                    }
                }
            }
            if (i == 0)
                throw new Exception("Логин или пароль неверны!");
            return student; //Возврат данных о студенте в форму
        }

        public void ChangeNewPassword(string login, string newpas)//Изменение пароля при первом входе
        {
            string sql = $"Update students set password='{newpas}' where login='{login}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }

        public void DeleteStudentByFIO(string name, string surname, string patronumic)//Удаление студента по ФИО
        {
            string sql = $"Delete from students where name=N'{name}' and surname=N'{surname}' and patronumic=N'{patronumic}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }

        public string GetAllStudents()
        {
            string temp = "";
            string sql = $"select * from students order by surname,name,patronumic";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        temp += (string)reader["surname"] +" " + (string)reader["name"]+" "+ (string)reader["patronumic"]+"\n";
                    }
                }
            }
            temp = temp.TrimEnd('\n');
            return temp;
        }

        public Dictionary<int, People> GetStudentsInGroup(string nameGroup)
        {
            Dictionary<int, People> temp = new Dictionary<int, People>();
            string sql = $"select nzach, name, surname, patronumic from students where students.idgr = (select top(1) idgr from grups where name=N'{nameGroup}') order by surname,name,patronumic";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        People p = new People();
                        p.name = (string)reader["name"];
                        p.surname = (string)reader["surname"];
                        p.patronumic = (string)reader["patronumic"];
                        temp.Add((int)reader["nzach"],p);
                    }
                }
            }
            return temp;
        }

        public People GetStudentByFIO(string FIO)
        {
            String[] str = FIO.Split(' ');
            People p = new People();
            string sql = $"select name, surname, patronumic,information,birthday,phonenumber from students where name=N'{str[1]}' and surname=N'{str[0]}' and patronumic=N'{str[2]}'  ";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        p.name = (string)reader["name"];
                        p.patronumic = (string)reader["patronumic"];
                        p.surname = (string)reader["surname"];
                        p.information = (string)reader["information"];
                        p.birthday = (DateTime)reader["birthday"];
                        p.phonenumber = (string)reader["phonenumber"];
                    }
                }
            }
            return p;
        }

        public int GetNzachByFIO(string surname, string name, string patronumic)
        {
            int nzach = -1;
            string sql = $"select nzach from students where name=N'{name}' and surname=N'{surname}' and patronumic=N'{patronumic}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nzach = (int)reader["nzach"];
                    }
                }
            }
            return nzach;
        }
    }
}
