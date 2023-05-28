using Cinema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShop
{
    public partial class CreateUser : Form
    {
        private User temp;
        public CreateUser()
        {
            InitializeComponent();
        }

        public User GetUser() => temp;

        private void btnUsrCreate_Click(object sender, EventArgs e)
        {
            try
            {
                temp = new User(txtUsrName.Text, txtEmail.Text, txtPassword.Text, dtpBirthday.Value, txtUserPhone.Text);
                Close();
            }
            catch (IndexOutOfRangeException) { MessageBox.Show("Invalid Input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.Message == "Invalid email format.")
                {
                    txtEmail.Text = "";
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            this.Text = "Create an account";
        }

        private void btnUsrCreate_MouseEnter(object sender, EventArgs e)
        {
            btnUsrCreate.BackColor = Color.White;
            btnUsrCreate.ForeColor = Color.Black;

        }

        private void btnUsrCreate_MouseLeave(object sender, EventArgs e)
        {
            btnUsrCreate.BackColor = Color.Black;
            btnUsrCreate.ForeColor = Color.White;

        }
    }
}
