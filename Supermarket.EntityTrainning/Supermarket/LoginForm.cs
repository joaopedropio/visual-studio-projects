﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (SupermarketContext context = new SupermarketContext())
            {
                string hashedPassword = Hash(txtPassword.Text.ToString());
                if (context.Customers.Any(n => n.Login == txtLogin.Text.ToString() && n.Password == hashedPassword))
                {
                    lblLoginWarning.Visible = false;
                    this.Visible = false;
                    Main main = new Main(txtLogin.Text.ToString());
                    main.ShowDialog();
                    main.Close();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos");
                    lblLoginWarning.Visible = true;
                }
            }

        }

        public string Hash(string password)
        {
            SHA256 hash = new SHA256Managed();
            byte[] hashedPassword = hash.ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text.ToString()));
            return Encoding.UTF8.GetString(hashedPassword);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewClientForm newclientform = new NewClientForm();
            newclientform.ShowDialog();
            this.Visible = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
