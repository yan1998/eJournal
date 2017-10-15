using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JournalLibrary
{
    public class Marks:ConnectionDB
    {
        public void InsertMark(int nzach,int idprd,int idprep,char mark,DateTime date)
        {
            string sql = "Insert Into Marks" + $"(nzach,idprd,idprep,mark,date) Values ({nzach},{idprep},{idprd},N'{mark}','{People.ConvertDate(date)}')";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }

        public void DeleteMarksByPredmetId(int id)
        {
            string sql = $"delete from marks where idprd=N'{id}'";
            using (SqlCommand com = new SqlCommand(sql, sqlConection))
            {
                com.ExecuteNonQuery();
            }
        }

        public DataTable GetMarksByNzachStudent(int nzach)
        {
            string sql = $"select predmets.name as 'Название предмета' ,mark as 'Отметка',date as 'Дата',concat(prepods.surname,' ',prepods.name,' ',prepods.patronumic) as 'Имя преподавателя' from marks,prepods,predmets where nzach={nzach} and prepods.idprep=marks.idprep and predmets.idprd=marks.idprd order by marks.date desc, predmets.name, prepods.surname";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public DataTable GetMarksByGroupAndPredmet(int idgr,int idprd)
        {
            string sql = $"select concat(students.surname,' ',students.name) as 'Фамилия и имя' ,mark as 'Оценка',date as 'Дата' from marks,prepods,predmets, students where students.nzach=marks.nzach and prepods.idprep=marks.idprep and predmets.idprd=marks.idprd and marks.idprd={idprd} and students.idgr={idgr} order by marks.date desc, students.surname, students.name";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public DataTable GetMarksSQL(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }
}
