using library_management_system.api;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace library_management_system.models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nic {  get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }

        public User(int id, string name, string nic, string password, string role, string gender)
        {
            Id = id;
            Name = name;
            Nic = nic;
            Password = password;
            Role = role;
            Gender = gender;
        }

        public User(string name, string nic, string password, string role, string gender)
        {
            Name = name;
            Nic = nic;
            Password = password;
            Role = role;
            Gender = gender;
        }

        public int Save()
        {
            var connection = Database.Instance.GetConnection();

            connection.Open();


            SqlCommand cmd = new SqlCommand("INSERT INTO [User] (Name, NIC, Password, Role, Gender) VALUES (@name, @nic, @password, @role, @gender)", connection);

            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@nic", Nic);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@role", Role);
            cmd.Parameters.AddWithValue("@gender", Gender);

            int affected_rows = cmd.ExecuteNonQuery();

            connection.Close();

            return affected_rows;
        }

        public int Update()
        {
            // ToDo
            return 0;
        }

        public static User Get(int id)
        {
            var connection = Database.Instance.GetConnection();

            SqlDataAdapter sqlDataAdapter;
            DataSet ds = new DataSet();

            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE id=@Id", connection);

            cmd.Parameters.AddWithValue("@Id", id);

            sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(ds);
            connection.Close();

            var row = ds.Tables[0].Rows[0];

            var _id = Convert.ToInt32(row.Field<int>("Id"));
            var _name = row.Field<string>("Name").Trim();
            var _nic = row.Field<string>("NIC").Trim();
            var _password = row.Field<string>("Password").Trim();
            var _role = row.Field<string>("Role").Trim();
            var _gender = row.Field<string>("Gender").Trim();

            return new User(_id, _name, _nic, _password, _role, _gender);
        }


        public static List<User> GetAll()
        {
            List<User> users = new List<User>();
            var connection = Database.Instance.GetConnection();

            SqlDataAdapter sqlDataAdapter;
            DataSet ds = new DataSet();

            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", connection);


            sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(ds);
            connection.Close();


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var row = ds.Tables[0].Rows[i];

                var _id = Convert.ToInt32(row.Field<int>("Id"));
                var _name = row.Field<string>("Name").Trim();
                var _nic = row.Field<string>("NIC").Trim();
                var _password = row.Field<string>("Password").Trim();
                var _role = row.Field<string>("Role").Trim();
                var _gender = row.Field<string>("Gender").Trim();

                User user = new User(_id, _name, _nic, _password, _role, _gender);
                users.Add(user);
            }
            return users;
        }

        public static DataSet get_users()
        {
            SqlDataAdapter sqlDataAdapter;
            DataSet ds = new DataSet();

            var connection = Database.Instance.GetConnection();

            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", connection);


            sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(ds);
            connection.Close();

            return ds;
        }

        public static DataSet get_user(string nic, string password)
        {
            SqlDataAdapter sqlDataAdapter;
            DataSet ds = new DataSet();

            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE NIC=@nic AND Password=@password", connection);

            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@password", password);

            sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(ds);
            connection.Close();

            return ds;
        }
    }
}
