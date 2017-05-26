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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordCheck = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.lblNameWarning = new System.Windows.Forms.Label();
            this.lblLoginWarning = new System.Windows.Forms.Label();
            this.lblAddressWarning = new System.Windows.Forms.Label();
            this.lblCreditCardWarning = new System.Windows.Forms.Label();
            this.lblPasswordWarning = new System.Windows.Forms.Label();
            this.lblPasswordCheckWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Digite novamente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cartao de crédito";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(255, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(255, 158);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(255, 192);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(196, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(255, 221);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(196, 20);
            this.txtCreditCard.TabIndex = 4;
            this.txtCreditCard.TextChanged += new System.EventHandler(this.txtCreditCard_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(255, 253);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPasswordCheck
            // 
            this.txtPasswordCheck.Location = new System.Drawing.Point(255, 290);
            this.txtPasswordCheck.Name = "txtPasswordCheck";
            this.txtPasswordCheck.PasswordChar = '*';
            this.txtPasswordCheck.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordCheck.TabIndex = 6;
            this.txtPasswordCheck.TextChanged += new System.EventHandler(this.txtPasswordCheck_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monaco", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 51);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cadastro";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(141, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 52);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(431, 350);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(168, 52);
            this.btnSubscribe.TabIndex = 7;
            this.btnSubscribe.Text = "Cadastrar";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // lblNameWarning
            // 
            this.lblNameWarning.AutoSize = true;
            this.lblNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lblNameWarning.Location = new System.Drawing.Point(509, 123);
            this.lblNameWarning.Name = "lblNameWarning";
            this.lblNameWarning.Size = new System.Drawing.Size(90, 13);
            this.lblNameWarning.TabIndex = 15;
            this.lblNameWarning.Text = "Nome muito curto";
            this.lblNameWarning.Visible = false;
            // 
            // lblLoginWarning
            // 
            this.lblLoginWarning.AutoSize = true;
            this.lblLoginWarning.ForeColor = System.Drawing.Color.Red;
            this.lblLoginWarning.Location = new System.Drawing.Point(509, 158);
            this.lblLoginWarning.Name = "lblLoginWarning";
            this.lblLoginWarning.Size = new System.Drawing.Size(0, 13);
            this.lblLoginWarning.TabIndex = 17;
            // 
            // lblAddressWarning
            // 
            this.lblAddressWarning.AutoSize = true;
            this.lblAddressWarning.Location = new System.Drawing.Point(509, 192);
            this.lblAddressWarning.Name = "lblAddressWarning";
            this.lblAddressWarning.Size = new System.Drawing.Size(0, 13);
            this.lblAddressWarning.TabIndex = 18;
            // 
            // lblCreditCardWarning
            // 
            this.lblCreditCardWarning.AutoSize = true;
            this.lblCreditCardWarning.ForeColor = System.Drawing.Color.Red;
            this.lblCreditCardWarning.Location = new System.Drawing.Point(509, 221);
            this.lblCreditCardWarning.Name = "lblCreditCardWarning";
            this.lblCreditCardWarning.Size = new System.Drawing.Size(0, 13);
            this.lblCreditCardWarning.TabIndex = 19;
            // 
            // lblPasswordWarning
            // 
            this.lblPasswordWarning.AutoSize = true;
            this.lblPasswordWarning.Location = new System.Drawing.Point(509, 253);
            this.lblPasswordWarning.Name = "lblPasswordWarning";
            this.lblPasswordWarning.Size = new System.Drawing.Size(0, 13);
            this.lblPasswordWarning.TabIndex = 20;
            // 
            // lblPasswordCheckWarning
            // 
            this.lblPasswordCheckWarning.AutoSize = true;
            this.lblPasswordCheckWarning.Location = new System.Drawing.Point(509, 290);
            this.lblPasswordCheckWarning.Name = "lblPasswordCheckWarning";
            this.lblPasswordCheckWarning.Size = new System.Drawing.Size(0, 13);
            this.lblPasswordCheckWarning.TabIndex = 21;
            // 
            // NewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 443);
            this.Controls.Add(this.lblPasswordCheckWarning);
            this.Controls.Add(this.lblPasswordWarning);
            this.Controls.Add(this.lblCreditCardWarning);
            this.Controls.Add(this.lblAddressWarning);
            this.Controls.Add(this.lblLoginWarning);
            this.Controls.Add(this.lblNameWarning);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPasswordCheck);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewClientForm";
            this.Text = "NewClient";
            this.Load += new System.EventHandler(this.NewClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label lblNameWarning;
        private System.Windows.Forms.Label lblLoginWarning;
        private System.Windows.Forms.Label lblAddressWarning;
        private System.Windows.Forms.Label lblCreditCardWarning;
        private System.Windows.Forms.Label lblPasswordWarning;
        private System.Windows.Forms.Label lblPasswordCheckWarning;
    }
}