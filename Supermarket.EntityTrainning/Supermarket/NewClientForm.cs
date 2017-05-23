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
    public partial class NewClientForm : Form
    {
        public NewClientForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.ToString().Length <= 10)
            {
                lblNameWarning.Visible = true;
            }
            else
            {
                lblNameWarning.Visible = false;
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void AddCustomer()
        {
            Customer customer = new Customer() {
                Name = txtName.Text.ToString(),
                Adress = txtAddress.Text.ToString(),
                Login = txtLogin.Text.ToString(),
                CreditCard = txtCreditCard.Text.ToString(),
                Password = Hash(txtPassword.Text.ToString()),
            };

            using(SupermarketContext context = new SupermarketContext())
            {
                try
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    MessageBox.Show("Cliente adicionado com sucesso");
                }
                catch
                {
                    MessageBox.Show("Cliente nao cadastrado");
                }
            }
        }

        public string Hash(string password)
        {
            SHA256 hash = new SHA256Managed();
            byte[] hashedPassword = hash.ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text.ToString()));
            return Encoding.UTF8.GetString(hashedPassword);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SupermarketContext context = new SupermarketContext())
            {
                Customer customer = context.Customers.Where(n => n.Login == "joao").FirstOrDefault();
                if(customer != null)
                {
                        MessageBox.Show("hash crtinho");
                }
                else
                {
                    MessageBox.Show("nao tem ninguem com esse login");
                }
            }
        }
    }
}
