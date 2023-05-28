namespace eShop
{
    partial class CartInfo
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
            this.lstCartItems = new System.Windows.Forms.ListBox();
            this.lblCartSummary = new System.Windows.Forms.Label();
            this.btnCartRemove = new System.Windows.Forms.Button();
            this.btnCartCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCartItems
            // 
            this.lstCartItems.FormattingEnabled = true;
            this.lstCartItems.Location = new System.Drawing.Point(12, 12);
            this.lstCartItems.Name = "lstCartItems";
            this.lstCartItems.Size = new System.Drawing.Size(636, 277);
            this.lstCartItems.TabIndex = 0;
            this.lstCartItems.SelectedIndexChanged += new System.EventHandler(this.lstCartItems_SelectedIndexChanged);
            // 
            // lblCartSummary
            // 
            this.lblCartSummary.AutoSize = true;
            this.lblCartSummary.Location = new System.Drawing.Point(24, 309);
            this.lblCartSummary.Name = "lblCartSummary";
            this.lblCartSummary.Size = new System.Drawing.Size(35, 13);
            this.lblCartSummary.TabIndex = 1;
            this.lblCartSummary.Text = "label1";
            // 
            // btnCartRemove
            // 
            this.btnCartRemove.Location = new System.Drawing.Point(573, 295);
            this.btnCartRemove.Name = "btnCartRemove";
            this.btnCartRemove.Size = new System.Drawing.Size(75, 23);
            this.btnCartRemove.TabIndex = 2;
            this.btnCartRemove.Text = "Remove";
            this.btnCartRemove.UseVisualStyleBackColor = true;
            this.btnCartRemove.Click += new System.EventHandler(this.btnCartRemove_Click);
            // 
            // btnCartCheckout
            // 
            this.btnCartCheckout.Location = new System.Drawing.Point(573, 427);
            this.btnCartCheckout.Name = "btnCartCheckout";
            this.btnCartCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCartCheckout.TabIndex = 3;
            this.btnCartCheckout.Text = "Checkout";
            this.btnCartCheckout.UseVisualStyleBackColor = true;
            // 
            // CartInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 462);
            this.Controls.Add(this.btnCartCheckout);
            this.Controls.Add(this.btnCartRemove);
            this.Controls.Add(this.lblCartSummary);
            this.Controls.Add(this.lstCartItems);
            this.Name = "CartInfo";
            this.Text = "CartInfo";
            this.Load += new System.EventHandler(this.CartInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCartItems;
        private System.Windows.Forms.Label lblCartSummary;
        private System.Windows.Forms.Button btnCartRemove;
        private System.Windows.Forms.Button btnCartCheckout;
    }
}