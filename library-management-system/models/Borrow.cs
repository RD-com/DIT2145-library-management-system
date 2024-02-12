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
    public class Borrow
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public int CopyID { get; set; }
        public string BorrowDate { get; set; }
        public string ReturnDate { get; set; }
        public bool Returned { get; set; }
        public string Remarks { get; set; }

        public Borrow(int id, int userID, int bookID, int copyID, string borrowDate, string returnDate, bool returned, string remarks)
        {
            Id = id;
            UserID = userID;
            BookID = bookID;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
            Returned = returned;
            Remarks = remarks;
            CopyID = copyID;
        }

        public Borrow(int userID, int bookID, int copyID, string borrowDate, string returnDate, bool returned, string remarks)
        {
            UserID = userID;
            BookID = bookID;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
            Returned = returned;
            Remarks = remarks;
            CopyID = copyID;
        }

        public int Save()
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Borrow] (UserID, BookID, CopyID, BorrowDate, ReturnDate, Returned, Remarks) VALUES (@userID, @bookID, @copyID, @borrowDate, @returnDate, @returned, @remarks)", connection);

            cmd.Parameters.AddWithValue("@userID", UserID);
            cmd.Parameters.AddWithValue("@bookID", BookID);
            cmd.Parameters.AddWithValue("@copyID", CopyID);
            cmd.Parameters.AddWithValue("@borrowDate", BorrowDate);
            cmd.Parameters.AddWithValue("@returnDate", ReturnDate);
            cmd.Parameters.AddWithValue("@returned", Returned);
            cmd.Parameters.AddWithValue("@remarks", Remarks);

            int affectedRows = cmd.ExecuteNonQuery();

            connection.Close();

            return affectedRows;
        }

        public int Update()
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("UPDATE [Borrow] SET UserID = @userID, BookID = @bookID, CopyID = @copyID, BorrowDate = @borrowDate, ReturnDate = @returnDate, Returned = @returned, Remarks = @remarks WHERE Id = @id", connection);

            cmd.Parameters.AddWithValue("@userID", UserID);
            cmd.Parameters.AddWithValue("@bookID", BookID);
            cmd.Parameters.AddWithValue("@copyID", CopyID);
            cmd.Parameters.AddWithValue("@borrowDate", BorrowDate);
            cmd.Parameters.AddWithValue("@returnDate", ReturnDate);
            cmd.Parameters.AddWithValue("@returned", Returned);
            cmd.Parameters.AddWithValue("@remarks", Remarks);
            cmd.Parameters.AddWithValue("@id", Id);

            int affectedRows = cmd.ExecuteNonQuery();

            connection.Close();

            return affectedRows;
        }

        public static Borrow Get(int id)
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Borrow] WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            Borrow borrow = null;

            if (reader.Read())
            {
                int userID = Convert.ToInt32(reader["UserID"]);
                int bookID = Convert.ToInt32(reader["BookID"]);
                int copyID = Convert.ToInt32(reader["CopyID"]);
                string borrowDate = reader["BorrowDate"].ToString();
                string returnDate = reader["ReturnDate"].ToString();
                bool returned = Convert.ToBoolean(reader["Returned"]);
                string remarks = reader["Remarks"].ToString();

                borrow = new Borrow(id, userID, bookID, copyID, borrowDate, returnDate, returned, remarks);
            }

            reader.Close();
            connection.Close();

            return borrow;
        }

        public static List<Borrow> GetAll()
        {
            List<Borrow> borrows = new List<Borrow>();
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Borrow]", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                int userID = Convert.ToInt32(reader["UserID"]);
                int bookID = Convert.ToInt32(reader["BookID"]);
                int copyID = Convert.ToInt32(reader["CopyID"]);
                string borrowDate = reader["BorrowDate"].ToString();
                string returnDate = reader["ReturnDate"].ToString();
                bool returned = Convert.ToBoolean(reader["Returned"]);
                string remarks = reader["Remarks"].ToString();

                Borrow borrow = new Borrow(id, userID, bookID, copyID, borrowDate, returnDate, returned, remarks);
                borrows.Add(borrow);
            }

            reader.Close();
            connection.Close();

            return borrows;
        }

        public static List<Borrow> GetNotReturned(int userId)
        {
            List<Borrow> borrows = new List<Borrow>();
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Borrow] WHERE UserID = @userid AND Returned = 0", connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                int userID = Convert.ToInt32(reader["UserID"]);
                int bookID = Convert.ToInt32(reader["BookID"]);
                int copyID = Convert.ToInt32(reader["CopyID"]);
                string borrowDate = reader["BorrowDate"].ToString();
                string returnDate = reader["ReturnDate"].ToString();
                bool returned = Convert.ToBoolean(reader["Returned"]);
                string remarks = reader["Remarks"].ToString();

                Borrow borrow = new Borrow(id, userID, bookID, copyID, borrowDate, returnDate, returned, remarks);
                borrows.Add(borrow);
            }

            reader.Close();
            connection.Close();

            return borrows;
        }

        public static DataSet get_borrows()
        {
            return Database.Instance.GetDataSet("SELECT * FROM [Borrow]");
        }

    }

}
