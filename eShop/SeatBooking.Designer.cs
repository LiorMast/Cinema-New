namespace Cinema
{
    partial class SeatBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTicketBooking = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lblTotalPriceSeats2 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblTotalPriceSeats = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpChooseSeats = new System.Windows.Forms.GroupBox();
            this.pnlChairs = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpChooseSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTicketBooking);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblTicketBooking
            // 
            this.lblTicketBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTicketBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTicketBooking.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTicketBooking.Location = new System.Drawing.Point(0, 0);
            this.lblTicketBooking.Name = "lblTicketBooking";
            this.lblTicketBooking.Size = new System.Drawing.Size(971, 100);
            this.lblTicketBooking.TabIndex = 0;
            this.lblTicketBooking.Text = "Ticket Booking";
            this.lblTicketBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTicketBooking.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPurchase);
            this.panel2.Controls.Add(this.btnCancelOrder);
            this.panel2.Controls.Add(this.lblTotalPriceSeats2);
            this.panel2.Controls.Add(this.lblPrice2);
            this.panel2.Controls.Add(this.lblTotalPriceSeats);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 180);
            this.panel2.TabIndex = 1;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Yellow;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPurchase.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPurchase.Location = new System.Drawing.Point(542, 114);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(146, 54);
            this.btnPurchase.TabIndex = 4;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancelOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelOrder.Location = new System.Drawing.Point(180, 114);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(139, 54);
            this.btnCancelOrder.TabIndex = 2;
            this.btnCancelOrder.Text = "Cancell";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            // 
            // lblTotalPriceSeats2
            // 
            this.lblTotalPriceSeats2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPriceSeats2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTotalPriceSeats2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalPriceSeats2.Location = new System.Drawing.Point(243, 65);
            this.lblTotalPriceSeats2.Name = "lblTotalPriceSeats2";
            this.lblTotalPriceSeats2.Size = new System.Drawing.Size(306, 36);
            this.lblTotalPriceSeats2.TabIndex = 3;
            this.lblTotalPriceSeats2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice2
            // 
            this.lblPrice2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrice2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrice2.Location = new System.Drawing.Point(107, 20);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(442, 36);
            this.lblPrice2.TabIndex = 2;
            this.lblPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPriceSeats
            // 
            this.lblTotalPriceSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTotalPriceSeats.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalPriceSeats.Location = new System.Drawing.Point(12, 65);
            this.lblTotalPriceSeats.Name = "lblTotalPriceSeats";
            this.lblTotalPriceSeats.Size = new System.Drawing.Size(243, 36);
            this.lblTotalPriceSeats.TabIndex = 1;
            this.lblTotalPriceSeats.Text = "Total Price Seats:";
            this.lblTotalPriceSeats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Location = new System.Drawing.Point(12, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 36);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpChooseSeats);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 385);
            this.panel3.TabIndex = 2;
            // 
            // grpChooseSeats
            // 
            this.grpChooseSeats.Controls.Add(this.pnlChairs);
            this.grpChooseSeats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChooseSeats.Location = new System.Drawing.Point(0, 0);
            this.grpChooseSeats.Name = "grpChooseSeats";
            this.grpChooseSeats.Size = new System.Drawing.Size(971, 385);
            this.grpChooseSeats.TabIndex = 0;
            this.grpChooseSeats.TabStop = false;
            // 
            // pnlChairs
            // 
            this.pnlChairs.ColumnCount = 8;
            this.pnlChairs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnlChairs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnlChairs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnlChairs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnlChairs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnlChairs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnlChairs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnlChairs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnlChairs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlChairs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlChairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChairs.Location = new System.Drawing.Point(3, 22);
            this.pnlChairs.Name = "pnlChairs";
            this.pnlChairs.RowCount = 10;
            this.pnlChairs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlChairs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlChairs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlChairs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlChairs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlChairs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlChairs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlChairs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlChairs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlChairs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlChairs.Size = new System.Drawing.Size(965, 360);
            this.pnlChairs.TabIndex = 0;
            this.pnlChairs.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChairs_Paint);
            // 
            // SeatBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(971, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SeatBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Seats";
            this.Load += new System.EventHandler(this.SeatBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.grpChooseSeats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTicketBooking;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPriceSeats2;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblTotalPriceSeats;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpChooseSeats;
        private System.Windows.Forms.TableLayoutPanel pnlChairs;
    }
}