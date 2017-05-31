using System;
using System.Windows.Forms;

namespace Supermarket
{
    partial class CartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwCart = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFinalizePurchase = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceRs = new System.Windows.Forms.Label();
            this.lblPurchaseTotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbBankSlip = new System.Windows.Forms.CheckBox();
            this.ckbCreditCard = new System.Windows.Forms.CheckBox();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCart
            // 
            this.dgwCart.AllowUserToAddRows = false;
            this.dgwCart.AllowUserToDeleteRows = false;
            this.dgwCart.AllowUserToResizeColumns = false;
            this.dgwCart.AllowUserToResizeRows = false;
            this.dgwCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCart.Location = new System.Drawing.Point(39, 79);
            this.dgwCart.Name = "dgwCart";
            this.dgwCart.ShowCellErrors = false;
            this.dgwCart.ShowCellToolTips = false;
            this.dgwCart.ShowEditingIcon = false;
            this.dgwCart.ShowRowErrors = false;
            this.dgwCart.Size = new System.Drawing.Size(588, 227);
            this.dgwCart.TabIndex = 0;
            this.dgwCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(500, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 56);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFinalizePurchase
            // 
            this.btnFinalizePurchase.Location = new System.Drawing.Point(500, 425);
            this.btnFinalizePurchase.Name = "btnFinalizePurchase";
            this.btnFinalizePurchase.Size = new System.Drawing.Size(127, 76);
            this.btnFinalizePurchase.TabIndex = 3;
            this.btnFinalizePurchase.Text = "Finalizar Compra!";
            this.btnFinalizePurchase.UseVisualStyleBackColor = true;
            this.btnFinalizePurchase.Click += new System.EventHandler(this.btnFinalizePurchase_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(39, 444);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(104, 37);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total:";
            // 
            // lblTotalPriceRs
            // 
            this.lblTotalPriceRs.AutoSize = true;
            this.lblTotalPriceRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceRs.Location = new System.Drawing.Point(131, 444);
            this.lblTotalPriceRs.Name = "lblTotalPriceRs";
            this.lblTotalPriceRs.Size = new System.Drawing.Size(59, 37);
            this.lblTotalPriceRs.TabIndex = 5;
            this.lblTotalPriceRs.Text = "R$";
            // 
            // lblPurchaseTotalPrice
            // 
            this.lblPurchaseTotalPrice.AutoSize = true;
            this.lblPurchaseTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseTotalPrice.Location = new System.Drawing.Point(180, 444);
            this.lblPurchaseTotalPrice.Name = "lblPurchaseTotalPrice";
            this.lblPurchaseTotalPrice.Size = new System.Drawing.Size(171, 37);
            this.lblPurchaseTotalPrice.TabIndex = 6;
            this.lblPurchaseTotalPrice.Text = "TotalPrice";
            this.lblPurchaseTotalPrice.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Forma de Pagamento:";
            // 
            // ckbBankSlip
            // 
            this.ckbBankSlip.AutoSize = true;
            this.ckbBankSlip.Checked = true;
            this.ckbBankSlip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbBankSlip.Location = new System.Drawing.Point(49, 346);
            this.ckbBankSlip.Name = "ckbBankSlip";
            this.ckbBankSlip.Size = new System.Drawing.Size(56, 17);
            this.ckbBankSlip.TabIndex = 8;
            this.ckbBankSlip.Text = "Boleto";
            this.ckbBankSlip.UseVisualStyleBackColor = true;
            this.ckbBankSlip.CheckedChanged += new System.EventHandler(this.ckbBankSlip_CheckedChanged);
            // 
            // ckbCreditCard
            // 
            this.ckbCreditCard.AutoSize = true;
            this.ckbCreditCard.Location = new System.Drawing.Point(49, 369);
            this.ckbCreditCard.Name = "ckbCreditCard";
            this.ckbCreditCard.Size = new System.Drawing.Size(108, 17);
            this.ckbCreditCard.TabIndex = 9;
            this.ckbCreditCard.Text = "Cartão de Crédito";
            this.ckbCreditCard.UseVisualStyleBackColor = true;
            this.ckbCreditCard.CheckedChanged += new System.EventHandler(this.ckbCreditCard_CheckedChanged);
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Enabled = false;
            this.txtCreditCardNumber.Location = new System.Drawing.Point(49, 393);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(160, 20);
            this.txtCreditCardNumber.TabIndex = 10;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 513);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.ckbCreditCard);
            this.Controls.Add(this.ckbBankSlip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPurchaseTotalPrice);
            this.Controls.Add(this.lblTotalPriceRs);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnFinalizePurchase);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgwCart);
            this.Name = "CartForm";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.DataGridView dgwCart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFinalizePurchase;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceRs;
        private System.Windows.Forms.Label lblPurchaseTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbBankSlip;
        private System.Windows.Forms.CheckBox ckbCreditCard;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
    }
}