using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalLibrary
{
    public class Predmets : ConnectionDB
    {
        public void InsertPredmet(string name, string prepodname,string con)//вставка предмета в БД
        {
            Prepods p = new Prepods();  //создание объекта- препода
            p.OpenConnection(con);// открытие соединения
            string sql = "Insert Into predmets" + $"(name,idprep) Values (N'{name}',{p.GetIdByName(prepodname)})";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
            p.CloseConnection();
        }

        public void DeletePredmet(string name)  //Удаление предмета из БД
        {
            string sql = $"delete from predmets where name=N'{name}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }

        public String[] GetAllPredmets()    //Получение всех предметов мз БД в виде массива строк
        {
            List<string> predmets = new List<string>();
            string sql = "Select name from predmets order by predmets.name";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        predmets.Add((string)reader["name"]);
                }
            }
            string[] temp = new string[predmets.Count];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = predmets[i];
            return temp;
        }

        public int GetIdByName(string name) //Получение id предмета по имени
        {
            int idgr = -1;
            string sql = $"Select idprd from predmets where name=N'{name}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        idgr = ((int)reader["idprd"]);
                }
            }
            if (idgr == -1)
                throw new Exception("Предмета не существует!");
            return idgr;
        }

        public String[] GetPredmetsByPrepodId(int id)    //Получение всех предметов данного преподователя
        {
            List<string> predmets = new List<string>();
            string sql = $"Select predmets.name from predmets,prepods where prepods.idprep={id} and predmets.idprep=prepods.idprep order by name";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        predmets.Add((string)reader["name"]);
                }
            }
            string[] temp = new string[predmets.Count];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = predmets[i];
            return temp;
        }

        public String[] GetPredmetsByNzach(int nzach)
        {
            List<string> predmets = new List<string>();
            string sql = $"Select distinct(predmets.name) from predmets,students, marks where students.nzach={nzach} and students.nzach = marks.nzach and marks.idprd = predmets.idprd";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        predmets.Add((string)reader["name"]);
                }
            }
            string[] temp = new string[predmets.Count];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = predmets[i];
            return temp;
        }
    }
}
