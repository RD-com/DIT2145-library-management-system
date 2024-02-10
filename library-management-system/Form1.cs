﻿using library_management_system.api;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        void Login(string nic, string password)
        {
            DataSet ds = Database.Instance.get_user(nic, password);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string name = ds.Tables[0].Rows[0].Field<string>("Name");
                string role = ds.Tables[0].Rows[0].Field<string>("Role");
                string gender = ds.Tables[0].Rows[0].Field<string>("Gender");

                btnLogin.Text = role;

                AuthContext.Instance.Login(name, nic, role, gender, this);
            }
            else
            {
                MessageBox.Show("Login Faild");
            }
           
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var nic = txtNic.Text;
            var password = txtPassword.Text;

            Login(nic, password);
        }
    }
}
