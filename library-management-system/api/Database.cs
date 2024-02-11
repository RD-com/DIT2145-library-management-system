using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace library_management_system.api
{
    public class Database
    {
        private static Database instance;

        private SqlConnection connection;

        public static Database Instance
        {
            get
            {
                if(instance == null)
                    instance = new Database();

                return instance;
            }
        }

        private Database()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\RavanaDevs\\Projects\\Other\\c#-library\\library-management-system\\library-management-system\\library-db.mdf;Integrated Security=True");
        }

        public SqlConnection GetConnection() { return connection; }

        public DataSet GetDataSet(string query)
        {
            SqlDataAdapter sqlDataAdapter;
            DataSet ds = new DataSet();

            var connection = Database.Instance.GetConnection();
            connection.Open();

            sqlDataAdapter = new SqlDataAdapter(query, connection);
            sqlDataAdapter.Fill(ds);
            connection.Close();

            return ds;
        }

    }
}
