using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{



    partial class Main
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
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lblRs = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblProductAdded = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(69, 46);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(306, 21);
            this.cbProducts.TabIndex = 2;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(63, 113);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(180, 31);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "ProductName";
            this.lblProductName.Visible = false;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(494, 399);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(148, 66);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Comprar";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(522, 25);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(138, 60);
            this.btnCart.TabIndex = 7;
            this.btnCart.Text = "Carrinho";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(51, 159);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.ReadOnly = true;
            this.txtProductDescription.Size = new System.Drawing.Size(406, 306);
            this.txtProductDescription.TabIndex = 8;
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRs.Location = new System.Drawing.Point(491, 159);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(41, 25);
            this.lblRs.TabIndex = 9;
            this.lblRs.Text = "R$";
            this.lblRs.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(536, 159);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 25);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            this.lblPrice.Visible = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(494, 323);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 25);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Qtd.:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(564, 327);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(65, 20);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.Text = "1";
            // 
            // lblProductAdded
            // 
            this.lblProductAdded.AutoSize = true;
            this.lblProductAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAdded.Location = new System.Drawing.Point(110, 490);
            this.lblProductAdded.Name = "lblProductAdded";
            this.lblProductAdded.Size = new System.Drawing.Size(393, 25);
            this.lblProductAdded.TabIndex = 13;
            this.lblProductAdded.Text = "Product sucessful added to the cart!";
            this.lblProductAdded.Visible = false;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(322, 128);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(18, 13);
            this.lblProductId.TabIndex = 14;
            this.lblProductId.Text = "ID";
            this.lblProductId.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 536);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblProductAdded);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRs);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.cbProducts);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblProductAdded;
        private System.Windows.Forms.Label lblProductId;
    }
}