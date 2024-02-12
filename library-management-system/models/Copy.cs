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
        public bool Available { get; set; } = true;

        public Copy(int id, int bookID, string publisher, string status, bool available)
        {
            Id = id;
            BookID = bookID;
            Publisher = publisher;
            Status = status;
            Available = available;
        }

        public Copy(int bookID, string publisher, string status, bool available)
        {
            BookID = bookID;
            Publisher = publisher;
            Status = status;
            Available = available;
        }

        public int Save()
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Copy] (BookID, Publisher, Status, Available) VALUES (@bookID, @publisher, @status, @available)", connection);

            cmd.Parameters.AddWithValue("@bookID", BookID);
            cmd.Parameters.AddWithValue("@publisher", Publisher);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@available", Available);

            int affectedRows = cmd.ExecuteNonQuery();

            connection.Close();

            return affectedRows;
        }

        public int Update()
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("UPDATE [Copy] SET BookID = @bookID, Publisher = @publisher, Status = @status, Available = @available WHERE Id = @id", connection);

            cmd.Parameters.AddWithValue("@bookID", BookID);
            cmd.Parameters.AddWithValue("@publisher", Publisher);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@available", Available);
            cmd.Parameters.AddWithValue("@id", Id);

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
                bool available = Convert.ToBoolean(reader["Available"]);

                copy = new Copy(id, bookID, publisher, status, available);
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
                bool available = Convert.ToBoolean(reader["Available"]);

                Copy copy = new Copy(id, bookID, publisher, status, available);
                copies.Add(copy);
            }

            reader.Close();
            connection.Close();

            return copies;
        }


        public static List<Copy> GetBorrowable(int bookId)
        {
            List<Copy> copies = new List<Copy>();
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Copy] WHERE BookID = @bookId AND Available = 1 AND Status = 'borrowable'", connection);
            cmd.Parameters.AddWithValue("@bookId", bookId);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                int bookID = Convert.ToInt32(reader["BookID"]);
                string publisher = reader["Publisher"].ToString();
                string status = reader["Status"].ToString();
                bool available = Convert.ToBoolean(reader["Available"]);

                Copy copy = new Copy(id, bookID, publisher, status, available);
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
