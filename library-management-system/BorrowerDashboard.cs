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
    public partial class BorrowerDashboard : Form
    {
        private DataSet Replies;

        public BorrowerDashboard()
        {
            InitializeComponent();
            RetriveMessages();
        }

        void RetriveMessages()
        {
            DataSet ds = models.Message.get_messages(AuthContext.Instance.userID);
            dgvMessages.DataSource = ds.Tables[0];
        }

        void RetriveReplies()
        {
            DataSet ds = Reply.get_replies(AuthContext.Instance.userID);
            Replies = ds;
            dgvReply.DataSource = ds.Tables[0];
        }

        void SendMessage()
        {
            var title = txtTitle.Text;
            var message = txtMessage.Text;

            models.Message msg = new models.Message(title, message, AuthContext.Instance.userID);
            int status = msg.Save();

            if(status > 0)
            {
                MessageBox.Show("Message was sent");
                RetriveMessages();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthContext.Instance.Logout();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
                RetriveReplies();
        }

        private void dgvReply_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Replies.Tables[0].Rows.Count == 0) { return; }
            txtReplyTitle.Text = Replies.Tables[0].Rows[e.RowIndex].Field<string>("Title");
            txtReplyMessage.Text = Replies.Tables[0].Rows[e.RowIndex].Field<string>("Description");
        }
    }
}
