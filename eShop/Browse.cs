using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace eShop
{
    public partial class Browse : Form
    {
        private User activeUser;
        private MovieCollection movies = new MovieCollection();
        private Movie selectedMovie;
        private int featuredPicCounter = 1;
        private string[] picPaths;
        private string[] titles;
        private string[] screeningTimes;

        public Browse()
        {
            InitializeComponent();
        }
        public Browse(User activeUser): this()
        {
            this.activeUser = activeUser;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            movies.LoadMovies();
            GetArrays();
            picFeatured.ImageLocation = picPaths[0];
            cmbMovies.Items.AddRange(titles);
            cmbMovies.SelectedIndex = 0;
            UpdateUserLabel();
            cmbScreeningTIme.Items.AddRange(screeningTimes);
            cmbScreeningTIme.SelectedIndex = 0;
        }

        private void GetArrays()
        {
            int length = movies.GetCurrentIndex();
            picPaths = new string[length];
            titles = new string[length];
            screeningTimes = new string[Enum.GetNames(typeof(Ticket.ScreeningTime)).Length];
            for (int i = 0; i < length; i++)
            {
                picPaths[i] = movies.GetMovies()[i].GetPicture();
                titles[i] = movies.GetMovies()[i].GetTitle();
            }
            for (int i = 0; i < Enum.GetNames(typeof(Ticket.ScreeningTime)).Length; i++)
            {
                screeningTimes[i] = Ticket.ScreeningTimeToString((Ticket.ScreeningTime)i);
            }
        }

        

        private void UpdateUserLabel() => lblUsrInfo.Text = $"Name: {activeUser.GetUsername()}\nItems in cart: {activeUser.GetCart().GetItemCount()}\nTotal: {activeUser.GetCart().GetTotalPrice()}";

        private void timer1_Tick(object sender, EventArgs e)
        {
            featuredPicCounter++;
            if (featuredPicCounter == picPaths.Length)
            {
                featuredPicCounter = 0;
            }
            picFeatured.ImageLocation = picPaths[featuredPicCounter];
        }

        private void cmbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMovie = movies.GetMovies()[cmbMovies.SelectedIndex];
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            MovieDetails movieDetails = new MovieDetails(selectedMovie);
            movieDetails.ShowDialog();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //SeatSelectorForm seatSelectorForm = new SeatSelectorForm();
            //seatSelectorForm.ShowDialog();

            Ticket t = new Ticket(selectedMovie, "1", (Ticket.ScreeningTime)cmbScreeningTIme.SelectedIndex, 10.3);
            activeUser.GetCart().AddItem(t);
            UpdateUserLabel();
        }

        private void ViewCart()
        {
            try
            {
                CartInfo cartInfo = new CartInfo(activeUser.GetCart());
                cartInfo.ShowDialog();
                UpdateUserLabel();
            }catch (Exception ex)
            {
                MessageBox.Show("Cart is empty!", "Empty cart", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            ViewCart();
        }

        private void lblUsrInfo_Click(object sender, EventArgs e)
        {
            ViewCart();
        }

        private void cmbScreeningTIme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
