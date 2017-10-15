using System;
using System.Data;
using System.Data.SqlClient;

namespace JournalLibrary
{
    public class ConnectionDB
    {
        protected SqlConnection sqlConection = null;    //обїект подключения к БД

        public void OpenConnection(string connectionString) // Установление соединения с БД
        {
            try
            {
                sqlConection = new SqlConnection(connectionString);// СОздание объекта соединения со стр. подключения
                sqlConection.Open();// Открытие соединения
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    //исключение в случае проблемы
            }
        }

        public void CloseConnection()   //закрытие соединения с БД 
        {
            sqlConection.Close();   
        }

        public DataTable SelectSQL(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }
}
