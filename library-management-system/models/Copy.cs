using library_management_system.api;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system.models
{
    public class Copy
    {
        public int Id { get; set; }
        public int BookID { get; set; }
        public string Publisher { get; set; }
        public string Status { get; set; }

        public Copy(int id, int bookID, string publisher, string status)
        {
            Id = id;
            BookID = bookID;
            Publisher = publisher;
            Status = status;
        }

        public Copy(int bookID, string publisher, string status)
        {
            BookID = bookID;
            Publisher = publisher;
            Status = status;
        }

        public int Save()
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Copy] (BookID, Publisher, Status) VALUES (@bookID, @publisher, @status)", connection);

            cmd.Parameters.AddWithValue("@bookID", BookID);
            cmd.Parameters.AddWithValue("@publisher", Publisher);
            cmd.Parameters.AddWithValue("@status", Status);

            int affectedRows = cmd.ExecuteNonQuery();

            connection.Close();

            return affectedRows;
        }

        public static Copy Get(int id)
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Copy] WHERE Id = @Id", connection);
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            Copy copy = null;

            if (reader.Read())
            {
                int bookID = Convert.ToInt32(reader["BookID"]);
                string publisher = reader["Publisher"].ToString();
                string status = reader["Status"].ToString();

                copy = new Copy(id, bookID, publisher, status);
            }

            reader.Close();
            connection.Close();

            return copy;
        }

        public static List<Copy> GetAll()
        {
            List<Copy> copies = new List<Copy>();
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Copy]", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                int bookID = Convert.ToInt32(reader["BookID"]);
                string publisher = reader["Publisher"].ToString();
                string status = reader["Status"].ToString();

                Copy copy = new Copy(id, bookID, publisher, status);
                copies.Add(copy);
            }

            reader.Close();
            connection.Close();

            return copies;
        }

        public static DataSet get_copies()
        {
            return Database.Instance.GetDataSet("SELECT * FROM [Copy]");
        }
    }

}
