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
        bool borrowable = false;
        Borrow borrow = null;
        Copy borrowableCopy = null;


        DataSet messages = null;

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

        void RetriveBorrows()
        {
            DataSet borrows = Borrow.get_borrows();
            dgvBorrow.DataSource = borrows.Tables[0];
        }

        void RetriveMessages()
        {
            messages = library_management_system.models.Message.get_messages();
            dgvMessage.DataSource = messages.Tables[0];
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

            Copy copy = new Copy(bookId, publisher, status, true);
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

        void CheckBorrow()
        {
            var bookId = Convert.ToInt32(txtBorrowBookId.Text);
            var userId = Convert.ToInt32(txtBorrowUserId.Text);

            var borrowDate = dateBorrow.Value.ToString();
            var returnDate = dateReturn.Value.ToString();

            var remarks = txtRemarks.Text;


            var borrows = Borrow.GetNotReturned(userId);
            var borrowableCopies = Copy.GetBorrowable(bookId);

            if (!(borrows.Count < 5 && borrowableCopies.Count > 0))
            {
                labelStatus.Text = "Rejected";
                btnBorrow.Enabled = false;
                borrowable = false;
                return;
            }

            labelStatus.Text = "OK";
            btnBorrow.Enabled = true;

            borrowableCopy = borrowableCopies[0];
            int copyId = borrowableCopy.Id;

            borrow = new Borrow(userId, bookId,copyId, borrowDate, returnDate, false, remarks);
            borrowable = true;
        }

        void BorrowBook()
        {
            if(borrowable)
            {
                borrowableCopy.Available = false;
                borrowableCopy.Update();
                int status = borrow.Save();
                if(status > 0)
                {
                    MessageBox.Show("Book borrowed");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        void ReturnBook()
        {
            var borrowId = Convert.ToInt32(txtReturnBorrowID.Text);

            Borrow toReturn = Borrow.Get(borrowId);

            if (toReturn != null)
            {
                Copy borrowedCopy = Copy.Get(toReturn.CopyID);
                if (borrowedCopy != null)
                {
                    borrowedCopy.Available = true;
                    borrowedCopy.Update();
                }
                else
                {
                    MessageBox.Show("Error");
                }


                toReturn.Returned = true;
                toReturn.Update();

                MessageBox.Show("Book Returned");
                RetriveBorrows();
            }
 
        }

        void SendReply(int messageId, int userId)
        {
            SendReplyForm form = new SendReplyForm(messageId, userId);
            form.ShowDialog();
        }


        #region Events

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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckBorrow();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
                RetriveCopies();
            else if(e.TabPageIndex == 2)
                RetriveBorrows();
            else if(e.TabPageIndex == 3)
                RetriveMessages();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowBook();
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBook();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMessageTitle.Text = messages.Tables[0].Rows[e.RowIndex].Field<string>("Title");
            txtMessageDescription.Text = messages.Tables[0].Rows[e.RowIndex].Field<string>("Description");
        }

        private void dgvMessage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var messageId = messages.Tables[0].Rows[e.RowIndex].Field<int>("Id");
            var userId = messages.Tables[0].Rows[e.RowIndex].Field<int>("UserID");

            SendReply(messageId, userId);
        }
        #endregion
    }
}
