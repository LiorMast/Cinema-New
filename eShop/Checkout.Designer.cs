namespace eShop
{
    partial class Checkout
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
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtExpiration = new System.Windows.Forms.TextBox();
            this.lblCCN = new System.Windows.Forms.Label();
            this.txtCCN = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPayer = new System.Windows.Forms.TextBox();
            this.lblPayer = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.grpPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.Controls.Add(this.cmbBrand);
            this.grpPaymentDetails.Controls.Add(this.lblBrand);
            this.grpPaymentDetails.Controls.Add(this.lblCVV);
            this.grpPaymentDetails.Controls.Add(this.lblExpiration);
            this.grpPaymentDetails.Controls.Add(this.txtCVV);
            this.grpPaymentDetails.Controls.Add(this.txtExpiration);
            this.grpPaymentDetails.Controls.Add(this.lblCCN);
            this.grpPaymentDetails.Controls.Add(this.txtCCN);
            this.grpPaymentDetails.Controls.Add(this.lblPhone);
            this.grpPaymentDetails.Controls.Add(this.txtPhone);
            this.grpPaymentDetails.Controls.Add(this.lblEmail);
            this.grpPaymentDetails.Controls.Add(this.txtEmail);
            this.grpPaymentDetails.Controls.Add(this.txtPayer);
            this.grpPaymentDetails.Controls.Add(this.lblPayer);
            this.grpPaymentDetails.Location = new System.Drawing.Point(12, 12);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Size = new System.Drawing.Size(325, 242);
            this.grpPaymentDetails.TabIndex = 0;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Details";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            "Mastercard",
            "Visa",
            "American Express"});
            this.cmbBrand.Location = new System.Drawing.Point(83, 115);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(219, 21);
            this.cmbBrand.TabIndex = 13;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(18, 118);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 12;
            this.lblBrand.Text = "Brand";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(18, 198);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(31, 13);
            this.lblCVV.TabIndex = 11;
            this.lblCVV.Text = "CVV:";
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Location = new System.Drawing.Point(18, 172);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(56, 13);
            this.lblExpiration.TabIndex = 10;
            this.lblExpiration.Text = "Expiration:";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(83, 195);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(219, 20);
            this.txtCVV.TabIndex = 9;
            // 
            // txtExpiration
            // 
            this.txtExpiration.Location = new System.Drawing.Point(83, 169);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Size = new System.Drawing.Size(219, 20);
            this.txtExpiration.TabIndex = 8;
            // 
            // lblCCN
            // 
            this.lblCCN.AutoSize = true;
            this.lblCCN.Location = new System.Drawing.Point(18, 146);
            this.lblCCN.Name = "lblCCN";
            this.lblCCN.Size = new System.Drawing.Size(62, 13);
            this.lblCCN.TabIndex = 7;
            this.lblCCN.Text = "Credit Card:";
            // 
            // txtCCN
            // 
            this.txtCCN.Location = new System.Drawing.Point(83, 143);
            this.txtCCN.Name = "txtCCN";
            this.txtCCN.Size = new System.Drawing.Size(219, 20);
            this.txtCCN.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(18, 94);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(83, 87);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(219, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(83, 61);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPayer
            // 
            this.txtPayer.Location = new System.Drawing.Point(83, 35);
            this.txtPayer.Name = "txtPayer";
            this.txtPayer.ReadOnly = true;
            this.txtPayer.Size = new System.Drawing.Size(219, 20);
            this.txtPayer.TabIndex = 1;
            // 
            // lblPayer
            // 
            this.lblPayer.AutoSize = true;
            this.lblPayer.Location = new System.Drawing.Point(18, 38);
            this.lblPayer.Name = "lblPayer";
            this.lblPayer.Size = new System.Drawing.Size(37, 13);
            this.lblPayer.TabIndex = 0;
            this.lblPayer.Text = "Payer:";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(262, 352);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            this.btnPay.MouseEnter += new System.EventHandler(this.btnPay_MouseEnter);
            this.btnPay.MouseLeave += new System.EventHandler(this.btnPay_MouseLeave);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(33, 283);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(56, 13);
            this.lblSummary.TabIndex = 2;
            this.lblSummary.Text = "Summary: ";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(349, 387);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.grpPaymentDetails);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.TextBox txtPayer;
        private System.Windows.Forms.Label lblPayer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCCN;
        private System.Windows.Forms.TextBox txtCCN;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpiration;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSummary;
    }
}