using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace JournalLibrary
{
    public class Prepods : ConnectionDB
    {
        public People Autorization(string login, string password)// авторизация преподавателя
        {
            int i = 0;
            People prepod = new People();   //создание обхекта преподавателя
            string sql = $"Select * from prepods where login='{login}' and password='{password}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())// если был найден, то мдет запись в класс его данных с БД
                    {
                        prepod.name = (string)reader["name"];
                        prepod.surname = (string)reader["surname"];
                        prepod.patronumic = (string)reader["patronumic"];
                        prepod.birthday = (DateTime)reader["birthday"];
                        prepod.information = (string)reader["information"];
                        i++;
                    }
                }
            }
            if (i == 0)
                throw new Exception("Логин или пароль неверны!");
            return prepod;//данные возвращаются в форму
        }
        public void InsertPrepod(People p)  //Вставка препода в БД
        {
            string sql = "Insert Into Prepods" + $"(name,surname,patronumic,information,birthday,login) Values (N'{p.name}',N'{p.surname}',N'{p.patronumic}',N'{p.information}','{p.ConvertDate()}','{p.login}')";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }

        public int GetIdByName(string info) // ПОлучение id преподователя по имени и фамилии
        {
            string[] name=info.Split(' ');
            int idpr = -1;
            string sql = $"Select idprep from Prepods where name=N'{name[1]}' and surname=N'{name[0]}' and patronumic=N'{name[2]}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        idpr = ((int)reader["idprep"]);
                }
            }
            if (idpr == -1)
                throw new Exception("Преподавателя нет в базе!");
            return idpr;    //Возврат id
        }

        public int GetIdByFIO(string name,string surname,string patronumic) // ПОлучение id преподователя по имени и фамилии
        {
            int idpr = -1;
            string sql = $"Select idprep from Prepods where name=N'{name}' and surname=N'{surname}' and patronumic=N'{patronumic}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        idpr = ((int)reader["idprep"]);
                }
            }
            if (idpr == -1)
                throw new Exception("Преподавателя нет в базе!");
            return idpr;    //Возврат id
        }

        public String[] GetAllPrepods() //Получение фамилии и имени всех преподавателй в виде массива строк
        {
            List<string> prepods = new List<string>();
            string sql = "Select name,surname, patronumic from Prepods order by surname,name,patronumic";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        prepods.Add((string)reader["surname"]+" "+(string)reader["name"]+" " + (string)reader["patronumic"]);
                }
            }
            string[] temp = new string[prepods.Count];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = prepods[i];
            return temp;
        }

        public void ChangeNewPassword(string login, string newpas)  //Изменение пароля при первом входе
        {
            string sql = $"Update prepods set password='{newpas}' where login='{login}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }

        public void DeletePrepodByFIO(string name, string surname, string patronumic) //Удаление из БД препода по ФИО
        {
            string sql = $"Delete from prepods where name=N'{name}' and surname=N'{surname}' and patronumic=N'{patronumic}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }

        public People GetPrepodByFIO(string FIO)
        {
            String[] str = FIO.Split(' ');
            People p = new People();
            string sql = $"select name, surname, patronumic,information,birthday from prepods where name=N'{str[1]}' and surname=N'{str[0]}' and patronumic=N'{str[2]}'  ";
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
                    }
                }
            }
            return p;
        }
    }
}
