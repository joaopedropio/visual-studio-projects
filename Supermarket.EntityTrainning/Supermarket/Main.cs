using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lsbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(SupermarketContext context = new SupermarketContext())
            {
                string itemSelected = cbProducts.SelectedItem.ToString();
                Product product = context.Products.Where(n => n.Name == itemSelected).FirstOrDefault();
                lblProductName.Text = product.Name;
                txtProductDescription.Text = product.Description;
                lblPrice.Text = product.Price.ToString() ;
                lblPrice.Visible = true;
                lblRs.Visible = true;
                lblProductName.Visible = true;
            }
        }

        private void btnRefreshProductList_Click(object sender, EventArgs e)
        {
            int count = cbProducts.Items.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    cbProducts.Items.RemoveAt(i);
                }
            }
     
            using (SupermarketContext context = new SupermarketContext())
            {
                List<Product> productList = context.Products.ToList();
                int n = context.Products.Count();
                int i = 0;
                string[] nameList = new string[n];
                while (i < n)
                {
                    nameList[i] = productList[i].Name;
                    i++;
                }
                this.cbProducts.Items.AddRange(nameList);
            }
        }
    }
}
