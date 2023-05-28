using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class SeatBooking : Form
    {
        public SeatBooking()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SeatBooking_Load(object sender, EventArgs e)
        {
            DrawChairs();
        }
        void DrawChairs()
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int chairNumber = 1;

            for (int i = 0; i < pnlChairs.RowCount; i++)
            {
                for (int j = 0; j < pnlChairs.ColumnCount; j++)
                {
                    Label lblchair = new Label();

                    char letter = letters[i];
                    lblchair.Text = letter + "" + chairNumber;
                    lblchair.AutoSize = false;
                    lblchair.Dock = DockStyle.Fill;
                    lblchair.TextAlign = ContentAlignment.MiddleLeft;
                    lblchair.BackColor = Color.White;
                    lblchair.BackColor = Color.Maroon;
                    lblchair.BorderStyle = BorderStyle.Fixed3D;
                    lblchair.TextAlign = ContentAlignment.MiddleCenter;
                    lblchair.ForeColor = Color.White;

                    pnlChairs.Controls.Add(lblchair, j, i);

                    chairNumber++;

                    lblchair.Click += Lblchair_Click;
                }
                chairNumber = 1;
            }
        }

        int countchairs = 0;
        //string[] chairs = new string[pnlChairs.col]; 

        private void Lblchair_Click(object sender, EventArgs e)
        {
            Label lblchair = sender as Label;
            if(lblchair.BackColor==Color.Maroon)
            {
                lblchair.BackColor = Color.SkyBlue;
            }
            else if(lblchair.BackColor==Color.SkyBlue)
            {
                lblchair.BackColor = Color.Maroon;
            }
            
        }

        private void pnlChairs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

        }
    }
}
