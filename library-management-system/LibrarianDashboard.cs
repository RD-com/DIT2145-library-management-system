using library_management_system.api;
using library_management_system.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system
{
    public partial class LibrarianDashboard : Form
    {
        public LibrarianDashboard()
        {
            InitializeComponent();
            RetriveBooks();
        }

        void RetriveBooks()
        {
            DataSet books = Book.get_books();
            dgvBooks.DataSource = books.Tables[0];
        }

        void RetriveCopies()
        {
            DataSet copies = Copy.get_copies();
            dgvCopy.DataSource = copies.Tables[0];
        }

        void AddBook(string title, string isbn, string authors)
        {
            Book book = new Book(isbn, title, authors, 0);
            int status = book.Save();
            if(status > 0)
            {
                MessageBox.Show("Book Added");
                RetriveBooks();
                RetriveCopies();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        void AddCopy(int bookId, string publisher, string status)
        {
            Book book = Book.Get(bookId);
            if(book == null)
            {
                MessageBox.Show("Invalid Book ID");
                return;
            }

            if (book.Copies >= 10)
            {
                MessageBox.Show("Maximum Copy Count!");
                return;
            }

            book.Copies = book.Copies + 1;
            int update_status = book.Update();

            if(update_status <= 0)
            {
                MessageBox.Show("Error on updating book");
                return;
            }

            RetriveBooks();

            Copy copy = new Copy(bookId, publisher, status);
            int rc = copy.Save();

            if (rc > 0)
            {
                MessageBox.Show("Copy Added");
                RetriveCopies();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthContext.Instance.Logout();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var  isbn = txtIsbn.Text;
            var title = txtTitle.Text;
            var authors = txtAuthors.Text;

            AddBook(title, isbn, authors );
        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            var bookId = Convert.ToInt32(txtBookID.Text);
            var publisher = txtPublisher.Text;
            var status = rbBorrow.Checked ? "borrowable" : "reference";

            AddCopy(bookId, publisher, status );
        }
    }
}
