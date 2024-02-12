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
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }

        public Message(int id, string title, string description, int userID)
        {
            Id = id;
            Title = title;
            Description = description;
            UserID = userID;
        }

        public Message(string title, string description, int userID)
        {
            Title = title;
            Description = description;
            UserID = userID;
        }

        public int Save()
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Message] (Title, Description, UserID) VALUES (@title, @description, @userID)", connection);

            cmd.Parameters.AddWithValue("@title", Title);
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@userID", UserID);

            int affectedRows = cmd.ExecuteNonQuery();

            connection.Close();

            return affectedRows;
        }

        public static Message Get(int id)
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Message] WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            Message message = null;

            if (reader.Read())
            {
                string title = reader["Title"].ToString();
                string description = reader["Description"].ToString();
                int userID = Convert.ToInt32(reader["UserID"]);

                message = new Message(id, title, description, userID);
            }

            reader.Close();
            connection.Close();

            return message;
        }

        public static List<Message> GetAll()
        {
            List<Message> messages = new List<Message>();
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Message]", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string title = reader["Title"].ToString();
                string description = reader["Description"].ToString();
                int userID = Convert.ToInt32(reader["UserID"]);

                Message message = new Message(id, title, description, userID);
                messages.Add(message);
            }

            reader.Close();
            connection.Close();

            return messages;
        }

        public static DataSet get_messages()
        {
            return Database.Instance.GetDataSet("SELECT * FROM [Message]");
        }

        public static DataSet get_messages(int userId)
        {
            return Database.Instance.GetDataSet("SELECT * FROM [Message] WHERE UserID = " + userId.ToString());
        }
    }

}
