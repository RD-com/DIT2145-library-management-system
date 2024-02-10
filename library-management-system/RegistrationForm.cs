using library_management_system.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace library_management_system
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        
        void Register(string name, string nic, string password, string gender)
        {
            var default_role = "user";
            int status = Database.Instance.insert_user(name, nic, password, default_role, gender);

            if (status > 0)
            {
                MessageBox.Show("Registration Successful");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var nic = txtNic.Text;
            var password = txtPassword.Text;
            var gender = rbMale.Checked ? "male" : "female";

            Register(name, nic, password, gender );
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
