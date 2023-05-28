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
                lblUser1.Text = $"Current User: {activeUser.GetUsername()}";
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
    }
}
