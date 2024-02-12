using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.models
{
    public partial class SendReplyForm : Form
    {
        private int messageId;
        private int userId;

        public SendReplyForm(int messageId, int userId)
        {
            InitializeComponent();
            this.messageId = messageId;
            this.userId = userId;
        }

        void SendReply()
        {
            var title = txtTitle.Text;
            var desc = txtDescription.Text;

            Reply reply = new Reply(title, desc, messageId, userId);
            int status = reply.Save();
            if(status > 0)
            {
                MessageBox.Show("Reply was sent");
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            SendReply();
        }
    }
}
