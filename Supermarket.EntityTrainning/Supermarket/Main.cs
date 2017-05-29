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
    public partial class Main : Form
    {
        private Order _order;
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
            this._order = new Order();
            using (SupermarketContext context = new SupermarketContext())
            {
                this._order.Customer = context.Customers.Where(n => n.Login == login).FirstOrDefault();
            }
            this._order.Date = new DateTime();
            this._order.List = new Dictionary<int, Product>();
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
            Product product = new Product();
            product = _productCatalog.Where(n => n.Id == int.Parse(lblProductId.Text.ToString())).FirstOrDefault();
            lblProductAdded.Visible = true;
            try
            {
                this._order.List.Add(qtd, product);
            }
            catch
            {
                MessageBox.Show("Produto já inserido! Para adicionar mais, vá em cart e aumente a quantidade de items");
            }
        }
    }
}
