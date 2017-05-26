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
            if (txtName.Text.ToString().Length < (int) Requirements.Name)
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
            if (txtLogin.Text.ToString().Length < (int)Requirements.Login)
            {
                lblLoginWarning.Text = "Login muito curto";
            }
            else
            {
                lblLoginWarning.Text = "";
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (txtCreditCard.Text.ToString().Length < (int)Requirements.CreditCard ||
                txtLogin.Text.ToString().Length < (int)Requirements.Login ||
                txtName.Text.ToString().Length < (int)Requirements.Name ||
                txtPasswordCheck.Text.ToString() != txtPassword.Text.ToString() ||
                txtPassword.Text.ToString().Length < (int)Requirements.Password)
            {
                MessageBox.Show("Dados inconsistentes!");
                return;
            }
            if(!NewClienteExists())
            {
                AddCustomer();
            }
            else
            {
                MessageBox.Show("Usuário já existente!");
            }
        }

        private bool NewClienteExists()
        {
            using(SupermarketContext context = new SupermarketContext())
            {
                if(context.Customers.Any(n => n.Login == txtLogin.Text.ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
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


        private void NewClientForm_Load(object sender, EventArgs e)
        {

        }

        private void txtCreditCard_TextChanged(object sender, EventArgs e)
        {
            if(txtCreditCard.Text.ToString().Length < (int)Requirements.CreditCard)
            {
                lblCreditCardWarning.Text = "Cartao de credito inválido";
            }
            else
            {
                lblCreditCardWarning.Text = "";
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text.ToString().Length < (int)Requirements.Password)
            {
                lblPasswordWarning.Text = "Senha muito curta";
            }
            else
            {
                lblPasswordWarning.Text = "";
            }
        }

        private void txtPasswordCheck_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtPasswordCheck.Text)
            {
                lblPasswordCheckWarning.Text = "Senhas não conferem!";
            }
            else
            {
                lblPasswordCheckWarning.Text = "";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
