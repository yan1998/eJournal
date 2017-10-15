using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace JournalLibrary
{
    public class Grups:ConnectionDB
    {
        
        public void InsertGrups(string name)    //Вставка группы в БД
        {
            string sql = "Insert Into Grups" + $"(name) Values (N'{name}')";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }
        public void DeleteGrup(string name)  //Удаление группы из БД
        {
            string sql =  $"delete from grups where name=N'{name}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }

        public String[] GetAllGrups()   //получение всех групп в виде массива строк
        {
            List<string> grups = new List<string>();//создание списка
            string sql = "Select name from Grups order by name";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        grups.Add((string)reader["name"]);//добавление групп в список
                }
            }
            string[] temp = new string[grups.Count];
            for (int i = 0; i < temp.Length; i++)   
                temp[i] = grups[i]; // перезапись со списка в массив строк
            return temp;    //возврат массива строк
        }

        public int GetIdByName(string name) //Получение id-группы по имени
        {   
            int idgr = -1;
            string sql = $"Select idgr from Grups where name=N'{name}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                       idgr=((int)reader["idgr"]); //запись id в переменную
                }
            }
            if (idgr == -1)
                throw new Exception("Группы не существует!");
            return idgr;    //возврат id
        }

        public int GetIdByNzach(int nzach) //Получение id-группы по номеру зачетки
        {
            int idgr=-1;
            string sql = $"Select grups.idgr from Grups,students where students.nzach={nzach} and students.idgr=grups.idgr";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        idgr = ((int)reader["idgr"]); //запись id в переменную
                }
            }
            return idgr;    //возврат id
        }
    }
}
