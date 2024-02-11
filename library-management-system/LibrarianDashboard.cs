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

        void AddBook(string title, string isbn, string authors)
        {
            Book book = new Book(isbn, title, authors);
            int status = book.Save();
            if(status > 0)
            {
                MessageBox.Show("Book Added");
                RetriveBooks();
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
    }
}
