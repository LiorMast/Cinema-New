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
    public partial class Checkout : Form
    {

        private User user;

        public Checkout()
        {
            InitializeComponent();
        }

        public Checkout(User user) :this()
        {
            this.user = user;
            txtEmail.Text = user.GetEmail();
            txtPayer.Text = user.GetUsername();
            txtPhone.Text = user.GetPhone();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            this.Text = "Payment Details";
            grpPaymentDetails.Width = this.Width;
            btnPay.BackColor = Color.Black;
            cmbBrand.SelectedIndex = 0;

        }
    }
}
