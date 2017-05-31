using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public static class OrderQueFunciona
    {
        public static Order Order;
    }
    public partial class Main : Form
    {
        private List<Product> _productCatalog;
        public Main(string login)
        {
            InitializeComponent();
            InitializeCart(login);
            InitializeProductDB();
            InitializeProductsList();
        }
        private void InitializeProductDB()
        {
            using (SupermarketContext context = new SupermarketContext())
            {
                this._productCatalog = context.Products.ToList();
            }
        }
        private void InitializeCart(string login)
        {
            OrderQueFunciona.Order = new Order();
            using (SupermarketContext context = new SupermarketContext())
            {
                OrderQueFunciona.Order.Customer = context.Customers.Where(n => n.Login == login).FirstOrDefault();
            }
            OrderQueFunciona.Order.Date = new DateTime();
            OrderQueFunciona.Order.List = new Dictionary<Product, int>();
        }
        private void InitializeProductsList()
        {
            using (SupermarketContext context = new SupermarketContext())
            {
                int n = _productCatalog.Count();
                int i = 0;
                string[] nameList = new string[n];
                while (i < n)
                {
                    nameList[i] = _productCatalog[i].Name;
                    i++;
                }
                this.cbProducts.Items.AddRange(nameList);
            }
        }
        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProductAdded.Visible = false;
            using (SupermarketContext context = new SupermarketContext())
            {
                string itemSelected = cbProducts.SelectedItem.ToString();
                Product product = context.Products.Where(n => n.Name == itemSelected).FirstOrDefault();
                lblProductName.Text = product.Name;
                lblProductId.Text = product.Id.ToString();
                txtProductDescription.Text = product.Description;
                lblPrice.Text = product.Price.ToString() ;
                lblPrice.Visible = true;
                lblRs.Visible = true;
                lblProductName.Visible = true;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(txtQuantity.Text.ToString());
            Product product = _productCatalog.Where(n => n.Id == int.Parse(lblProductId.Text.ToString())).FirstOrDefault();
            lblProductAdded.Visible = true;
            try
            {
                OrderQueFunciona.Order.List.Add(product, qtd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto já ineserido! Para adicionar mais, vá em cart e aumente a quantidade de items");
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartForm cartform = new CartForm();
            cartform.ShowDialog();
            cartform.Close();
            this.Show();
        }
    }
}
