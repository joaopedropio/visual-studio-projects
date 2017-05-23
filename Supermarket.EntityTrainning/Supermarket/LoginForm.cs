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
            using (SupermarketContext context = new SupermarketContext())
            {
                Customer customer = context.Customers.Where(n => n.Login == txtLogin.Text.ToString()).FirstOrDefault();
                if (customer != null && customer.Password == Hash(txtPassword.Text.ToString()))
                {
                    MessageBox.Show("logou co sucess");
                }
                else
                {
                    MessageBox.Show("Deu ruim");
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
    }
}
