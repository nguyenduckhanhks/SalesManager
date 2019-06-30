using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    public class DataProvider
    {
        private string ConnectionStr = @"Data Source=.\sqlexpress;Initial Catalog=BANHANGKT;Integrated Security=True";

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        public DataTable ExcuteQuery(string query)
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionStr);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(table);

            connection.Close();

            return table;
        }

        public void DeleteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(ConnectionStr);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
