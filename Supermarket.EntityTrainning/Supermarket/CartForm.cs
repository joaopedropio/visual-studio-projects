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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
            InitializaCart();
        }

        private void InitializaCart()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Qtd.");
            table.Columns.Add("Produto");
            table.Columns.Add("Vlr. Uni.");
            table.Columns.Add("Sub Total");
            table.Columns["Produto"].ReadOnly = true;
            table.Columns["Vlr. Uni."].ReadOnly = true;

            foreach (var item in OrderQueFunciona.Order.List)
            {
                DataRow dataRow = table.NewRow();
                dataRow["Qtd."] = item.Value.ToString();
                dataRow["Produto"] = item.Key.Name.ToString();
                dataRow["Vlr. Uni."] = item.Key.Price.ToString();
                dataRow["Sub Total"] = item.Key.Price * item.Value;
                table.Rows.Add(dataRow);
            }
            //table.Columns.Add("Name".ToString());
            //table.Columns.Add("Color".ToString());
            //DataRow dr = table.NewRow();
            //dr["Name"] = "Mike";
            //dr["Color"] = "blue";
            //table.Rows.Add(dr);

            dgwCart.DataSource = table;
            this.dgwCart.Columns["Sub Total"].ReadOnly = true;
            double total = 0;
            foreach (var item in OrderQueFunciona.Order.List)
            {
                total += item.Value * item.Key.Price;
            }
            lblPurchaseTotalPrice.Text = total.ToString();
            lblPurchaseTotalPrice.Visible = true;

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int qtd = int.Parse(this.dgwCart.Rows[index].Cells["Qtd."].Value.ToString());
            string productName = this.dgwCart.Rows[index].Cells["Produto"].Value.ToString();
            if(qtd == 0)
            {
                OrderQueFunciona.Order.List.Remove(OrderQueFunciona.Order.List.Where(p => p.Key.Name == productName).FirstOrDefault().Key);
                this.dgwCart.Rows.RemoveAt(index);
                return;
            }
            double price = double.Parse(this.dgwCart.Rows[index].Cells["Vlr. Uni."].Value.ToString());
            this.dgwCart.Columns["Sub Total"].ReadOnly = false;
            this.dgwCart.Rows[index].Cells["Sub Total"].Value = (qtd * price).ToString();
            this.dgwCart.Columns["Sub Total"].ReadOnly = true;
            //OrderQueFunciona.Order.List.(OrderQueFunciona.Order.List.Where(p => p.Key.Name == productName).FirstOrDefault().Key);
            Product product = OrderQueFunciona.Order.List.Where(p => p.Key.Name == productName).FirstOrDefault().Key;
            OrderQueFunciona.Order.List.Remove(OrderQueFunciona.Order.List.Where(p => p.Key.Name == productName).FirstOrDefault().Key);
            OrderQueFunciona.Order.List.Add(product, qtd);

            double total = 0;
            foreach (var item in OrderQueFunciona.Order.List)
            {
                total += item.Value * item.Key.Price; 
            }
            lblPurchaseTotalPrice.Text = total.ToString();
        }
        private void ckbBankSlip_CheckedChanged(object sender, EventArgs e)
        {
            ckbCreditCard.Checked = false;
            txtCreditCardNumber.Enabled = false;
        }

        private void ckbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            ckbBankSlip.Checked = false;
            txtCreditCardNumber.Enabled = true;
        }

        private void btnFinalizePurchase_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
