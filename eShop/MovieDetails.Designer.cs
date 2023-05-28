namespace eShop
{
    partial class MovieDetails
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
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblMovieDetails = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(13, 13);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(297, 541);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            this.picPoster.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblMovieTitle.Location = new System.Drawing.Point(316, 13);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(156, 44);
            this.lblMovieTitle.TabIndex = 1;
            this.lblMovieTitle.Text = "label1";
            // 
            // lblMovieDetails
            // 
            this.lblMovieDetails.AutoSize = true;
            this.lblMovieDetails.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieDetails.Location = new System.Drawing.Point(324, 92);
            this.lblMovieDetails.Name = "lblMovieDetails";
            this.lblMovieDetails.Size = new System.Drawing.Size(91, 31);
            this.lblMovieDetails.TabIndex = 2;
            this.lblMovieDetails.Text = "label1";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(324, 284);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(165, 31);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.Black;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.ForeColor = System.Drawing.Color.White;
            this.rtbDescription.Location = new System.Drawing.Point(330, 319);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(510, 235);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            // 
            // MovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(852, 566);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblMovieDetails);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.picPoster);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MovieDetails";
            this.Text = "MovieDetails";
            this.Load += new System.EventHandler(this.MovieDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblMovieDetails;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}