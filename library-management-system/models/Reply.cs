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
    public class Reply
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MessageID { get; set; }
        public int UserID { get; set; }

        public Reply(int id, string title, string description, int messageID, int userID)
        {
            Id = id;
            Title = title;
            Description = description;
            MessageID = messageID;
            UserID = userID;
        }

        public Reply(string title, string description, int messageID, int userID)
        {
            Title = title;
            Description = description;
            MessageID = messageID;
            UserID = userID;
        }

        public int Save()
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Reply] (Title, Description, MessageID, UserID) VALUES (@title, @description, @messageID, @userID)", connection);

            cmd.Parameters.AddWithValue("@title", Title);
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@messageID", MessageID);
            cmd.Parameters.AddWithValue("@userID", UserID);

            int affectedRows = cmd.ExecuteNonQuery();

            connection.Close();

            return affectedRows;
        }

        public static Reply Get(int id)
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Reply] WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            Reply reply = null;

            if (reader.Read())
            {
                string title = reader["Title"].ToString();
                string description = reader["Description"].ToString();
                int messageID = Convert.ToInt32(reader["MessageID"]);
                int userID = Convert.ToInt32(reader["UserID"]);

                reply = new Reply(id, title, description, messageID, userID);
            }

            reader.Close();
            connection.Close();

            return reply;
        }

        public static List<Reply> GetAll()
        {
            List<Reply> replies = new List<Reply>();
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Reply]", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string title = reader["Title"].ToString();
                string description = reader["Description"].ToString();
                int messageID = Convert.ToInt32(reader["MessageID"]);
                int userID = Convert.ToInt32(reader["UserID"]);

                Reply reply = new Reply(id, title, description, messageID, userID);
                replies.Add(reply);
            }

            reader.Close();
            connection.Close();

            return replies;
        }

       public static DataSet get_replies(int userId)
        {
            return Database.Instance.GetDataSet("SELECT * FROM [Reply] WHERE UserID = " + userId.ToString());
        }
    }

}
