using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

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

        public int insert_user(string name, string nic, string password, string default_role, string gender)
        {

            connection.Open();

            SqlCommand cmd = new SqlCommand(@"INSERT INTO user(name, nic, password, role, gender) VALUES(@name, @nic, @password, @role, @gender)", connection);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", default_role);
            cmd.Parameters.AddWithValue("@gender", gender);

            int affected_rows = cmd.ExecuteNonQuery();

            return affected_rows;
        }

    }
}
