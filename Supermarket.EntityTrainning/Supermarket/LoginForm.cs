using System;
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
            string login = txtLogin.Text.ToString();

            byte[] hashedPassword = Hash(txtPassword.Text.ToString());
            MessageBox.Show(System.Text.Encoding.UTF8.GetString(hashedPassword));
        }

        private byte[] Hash(string password)
        {
            UnicodeEncoding ue = new UnicodeEncoding();
            byte[] uePasswd = ue.GetBytes(password);
            SHA1Managed sha = new SHA1Managed();
            
            return sha.ComputeHash(uePasswd);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newClient = new NewClientForm();
            newClient.Show();
        }
    }
}
