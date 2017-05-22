namespace Supermarket
{
    partial class NewClientForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordCheck = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordCheck = new System.Windows.Forms.TextBox();
            this.lblSubscription = new System.Windows.Forms.Label();
            this.btnCancelSubscription = new System.Windows.Forms.Button();
            this.txtConfirmSubscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(60, 181);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Endereço:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(60, 140);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login:";
            this.lblLogin.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Location = new System.Drawing.Point(60, 219);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(92, 13);
            this.lblCreditCard.TabIndex = 4;
            this.lblCreditCard.Text = "Cartão de Crédito:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(60, 258);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(38, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Senha";
            // 
            // lblPasswordCheck
            // 
            this.lblPasswordCheck.AutoSize = true;
            this.lblPasswordCheck.Location = new System.Drawing.Point(60, 292);
            this.lblPasswordCheck.Name = "lblPasswordCheck";
            this.lblPasswordCheck.Size = new System.Drawing.Size(97, 13);
            this.lblPasswordCheck.TabIndex = 6;
            this.lblPasswordCheck.Text = "Senha novamente:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(161, 133);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(161, 174);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(291, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(161, 212);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(291, 20);
            this.txtCreditCard.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(161, 251);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // txtPasswordCheck
            // 
            this.txtPasswordCheck.Location = new System.Drawing.Point(161, 285);
            this.txtPasswordCheck.Name = "txtPasswordCheck";
            this.txtPasswordCheck.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordCheck.TabIndex = 11;
            // 
            // lblSubscription
            // 
            this.lblSubscription.AutoSize = true;
            this.lblSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscription.Location = new System.Drawing.Point(87, 9);
            this.lblSubscription.Name = "lblSubscription";
            this.lblSubscription.Size = new System.Drawing.Size(293, 73);
            this.lblSubscription.TabIndex = 12;
            this.lblSubscription.Text = "Cadastro";
            // 
            // btnCancelSubscription
            // 
            this.btnCancelSubscription.Location = new System.Drawing.Point(114, 336);
            this.btnCancelSubscription.Name = "btnCancelSubscription";
            this.btnCancelSubscription.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSubscription.TabIndex = 13;
            this.btnCancelSubscription.Text = "Cancelar";
            this.btnCancelSubscription.UseVisualStyleBackColor = true;
            // 
            // txtConfirmSubscription
            // 
            this.txtConfirmSubscription.Location = new System.Drawing.Point(264, 335);
            this.txtConfirmSubscription.Name = "txtConfirmSubscription";
            this.txtConfirmSubscription.Size = new System.Drawing.Size(75, 23);
            this.txtConfirmSubscription.TabIndex = 14;
            this.txtConfirmSubscription.Text = "Confirmar!";
            this.txtConfirmSubscription.UseVisualStyleBackColor = true;
            // 
            // NewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 403);
            this.Controls.Add(this.txtConfirmSubscription);
            this.Controls.Add(this.btnCancelSubscription);
            this.Controls.Add(this.lblSubscription);
            this.Controls.Add(this.txtPasswordCheck);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPasswordCheck);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "NewClientForm";
            this.Text = "NewClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordCheck;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordCheck;
        private System.Windows.Forms.Label lblSubscription;
        private System.Windows.Forms.Button btnCancelSubscription;
        private System.Windows.Forms.Button txtConfirmSubscription;
    }
}