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
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }

        public Book(int id, string isbn, string title, string authors)
        {
            Id = id;
            ISBN = isbn;
            Title = title;
            Authors = authors;
        }

        public Book(string isbn, string title, string authors)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
        }

        public int Save()
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Book] (ISBN, Title, Authors) VALUES (@isbn, @title, @authors)", connection);

            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.Parameters.AddWithValue("@title", Title);
            cmd.Parameters.AddWithValue("@authors", Authors);

            int affectedRows = cmd.ExecuteNonQuery();

            connection.Close();

            return affectedRows;
        }

        public static Book Get(int id)
        {
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Book] WHERE Id = @Id", connection);
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            Book book = null;

            if (reader.Read())
            {
                string isbn = reader["ISBN"].ToString();
                string title = reader["Title"].ToString();
                string authors = reader["Authors"].ToString();

                book = new Book(id, isbn, title, authors);
            }

            reader.Close();
            connection.Close();

            return book;
        }

        public static List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            var connection = Database.Instance.GetConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Book]", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string isbn = reader["ISBN"].ToString();
                string title = reader["Title"].ToString();
                string authors = reader["Authors"].ToString();

                Book book = new Book(id, isbn, title, authors);
                books.Add(book);
            }

            reader.Close();
            connection.Close();

            return books;
        }

        public static DataSet get_books()
        {
            return Database.Instance.GetDataSet("SELECT * FROM [Book]");
        }
    }

}
