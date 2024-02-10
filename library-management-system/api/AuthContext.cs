using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.api
{
    public class AuthContext
    {
        private static AuthContext instance;

        public string name;
        public string nic;
        public string role;
        public string gender;
        public bool isLoggedIn = false;

        LoginForm loginForm;
        Form dashboard;

        public static AuthContext Instance
        {
            get
            {
                if(instance == null)
                    instance = new AuthContext();

                return instance;
            }
        }

        private AuthContext()
        {

        }

        public void Login(string name, string nic, string role, string gender, LoginForm form)
        {
            this.name = name;
            this.nic = nic;
            this.role = role;
            this.gender = gender;
            this.loginForm = form;

            isLoggedIn = true;

            if (true)
            {
                dashboard = new LibrarianDashboard();
                dashboard.Show();
                loginForm.Hide();
            }
            else
            {
                MessageBox.Show("You are not an admin");
            }
        }

        public void Logout()
        {
            isLoggedIn = false;

            name = null;
            nic = null;
            role = null;
            gender = null;


            dashboard.Close();
            loginForm.Show();

        }

        public bool IsAdmin()
        {
            if (role == "admin")
                return true;

            return false;
        }
    }
}
