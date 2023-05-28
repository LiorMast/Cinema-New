using eShop;
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
        User User;
        Movie movie;
        Ticket.ScreeningTime screeningTime;
        private Ticket[] tickets;
        private List<Ticket> ticketList = new List<Ticket>();
        private List<string> chairs = new List<string>();
        private const int ticketPrice = 10;

        public SeatBooking()
        {
            InitializeComponent();
            UpdateInfo();
        }

        public SeatBooking(User user,Movie movie, Ticket.ScreeningTime screeningTime) : this()
        {
            this.movie = movie;
            this.screeningTime = screeningTime;
            this.User = user;
            lblScreeningInfo.Text = $"Movie: {movie.GetTitle()}\nTime: {Ticket.ScreeningTimeToString(screeningTime)}";
            lblPrice2.Text = $"{ticketPrice}";
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

        private void Lblchair_Click(object sender, EventArgs e)
        {
            Label lblchair = sender as Label;
            if(lblchair.BackColor==Color.Maroon)
            {
                lblchair.BackColor = Color.SkyBlue;
                chairs.Add(lblchair.Text);
                UpdateInfo();
            }
            else if(lblchair.BackColor==Color.SkyBlue)
            {
                lblchair.BackColor = Color.Maroon;
                chairs.Remove(lblchair.Text);
                UpdateInfo();
            }
            
        }

        private void UpdateInfo()
        {
            try { lblTotalPriceSeats2.Text = $"{chairs.Count * ticketPrice}"; } catch { lblTotalPriceSeats2.Text = "0"; }
        }

        private void pnlChairs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (chairs.Count==0)
            {
                MessageBox.Show("No seats selected!", "You must choose a seat",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                foreach (string seat in chairs)
                {
                    ticketList.Add(new Ticket(movie, seat, screeningTime, ticketPrice));
                }
                foreach (Ticket ticket in ticketList)
                {
                    User.GetCart().AddItem(ticket);
                }
                Close();
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
