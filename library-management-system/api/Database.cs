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

        public int insert_user(string name, string nic, string password, string default_role, string gender)
        {

            connection.Open();

            System.Console.WriteLine(gender);

            SqlCommand cmd = new SqlCommand("INSERT INTO [User] (Name, NIC, Password, Role, Gender) VALUES (@name, @nic, @password, @role, @gender)", connection);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", default_role);
            cmd.Parameters.AddWithValue("@gender", gender);

            int affected_rows = cmd.ExecuteNonQuery();

            connection.Close();

            return affected_rows;
        }

        public DataSet get_user(int id)
        {
            SqlDataAdapter sqlDataAdapter;
            DataSet ds = new DataSet();

            connection.Open();
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE id=@Id", connection);

            cmd.Parameters.AddWithValue("@Id", id);

            sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(ds);
            connection.Close();

            return ds;
        }

        public DataSet get_user(string nic, string password)
        {
            SqlDataAdapter sqlDataAdapter;
            DataSet ds = new DataSet();

            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE NIC=@nic AND Password=@password", connection);

            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@password", password);

            sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(ds);
            connection.Close();

            return ds;
        }

        public DataSet get_users()
        {
            SqlDataAdapter sqlDataAdapter;
            DataSet ds = new DataSet();

            connection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [User]", connection);
            sqlDataAdapter.Fill(ds);
            connection.Close();

            return ds;
        }

    }
}
