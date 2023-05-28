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
    public partial class WelcomePage : Form
    {
        private User activeUser;
        private UserCollection users = new UserCollection();
        private MovieCollection movies = new MovieCollection();
        public WelcomePage()
        {
            InitializeComponent();
            movies.LoadMovies();
            lblTitle.ForeColor = Color.Gold;
            btnCreateAccount.BackColor = Color.Black;
            this.Text = "Welcome!";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateUser usr = new CreateUser();
            usr.ShowDialog();

            try
            {
                activeUser = usr.GetUser();
                users.AddUser(activeUser);
                Browse browse = new Browse(activeUser);
                browse.ShowDialog();
            }catch(Exception)
            {
                MessageBox.Show("Cancelled", "User not created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Browse frm = new Browse(new User("TESTrrrrrrrrrrrrrrrrrr","TEST@TEST.TEST","1234",new DateTime(1990,1,1), "0500000000"));
            frm.ShowDialog();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblTitle.ForeColor == Color.Gold) lblTitle.ForeColor = Color.White;
            else if (lblTitle.ForeColor == Color.White) lblTitle.ForeColor = Color.HotPink;
            else if (lblTitle.ForeColor == Color.HotPink) lblTitle.ForeColor = Color.Cyan;
            else if (lblTitle.ForeColor == Color.Cyan) lblTitle.ForeColor = Color.Gold;
        }

        private void btnCreateAccount_MouseEnter(object sender, EventArgs e)
        {
            btnCreateAccount.BackColor = Color.White;
            btnCreateAccount.ForeColor = Color.Black;
        }

        private void btnCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            btnCreateAccount.BackColor = Color.Black;
            btnCreateAccount.ForeColor = Color.White;
        }
    }
}
