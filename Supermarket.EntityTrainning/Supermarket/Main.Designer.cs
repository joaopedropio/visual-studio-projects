﻿using System;
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
            this.btnRefreshProductList = new System.Windows.Forms.Button();
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
            this.lblRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRs.Location = new System.Drawing.Point(491, 159);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(39, 25);
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
            // btnRefreshProductList
            // 
            this.btnRefreshProductList.Location = new System.Drawing.Point(396, 46);
            this.btnRefreshProductList.Name = "btnRefreshProductList";
            this.btnRefreshProductList.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshProductList.TabIndex = 11;
            this.btnRefreshProductList.Text = "Refresh";
            this.btnRefreshProductList.UseVisualStyleBackColor = true;
            this.btnRefreshProductList.Click += new System.EventHandler(this.btnRefreshProductList_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 536);
            this.Controls.Add(this.btnRefreshProductList);
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
        private System.Windows.Forms.Button btnRefreshProductList;
    }
}