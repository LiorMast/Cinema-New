namespace Cinema
{
    partial class WelcomePage
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
            this.components = new System.ComponentModel.Container();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.tTitle = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateAccount.Location = new System.Drawing.Point(350, 163);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(111, 30);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Create an Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            this.btnCreateAccount.MouseEnter += new System.EventHandler(this.btnCreateAccount_MouseEnter);
            this.btnCreateAccount.MouseLeave += new System.EventHandler(this.btnCreateAccount_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(73, 63);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(718, 53);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome to our C#inema!";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(350, 260);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(111, 30);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tTitle
            // 
            this.tTitle.Enabled = true;
            this.tTitle.Interval = 600;
            this.tTitle.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 321);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreateAccount);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomePage";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Timer tTitle;
    }
}

