using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            txtEmail.Text = user.GetEmail().ToLower();
            txtPayer.Text = user.GetUsername();
            txtPhone.Text = user.GetPhone();
        }

        private static bool IsValidCCN(string input)
        {
            Regex regex = new Regex("^[0-9]{16}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(input);
        }

        private static bool IsValidCVV(string input)
        {
            Regex regex = new Regex("^[0-9]{3}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(input);
        }

        private static bool IsValidExp(string input)
        {
            Regex regex = new Regex("^[0-9]{2}/[0-9]{2}$", RegexOptions.IgnoreCase);
            try
            {
                int month = int.Parse(input.Substring(0, 2));
                int year = int.Parse(input.Substring(3, 2));
                if (year == DateTime.Now.Year - 2000)
                {
                    bool ismonth = month >= DateTime.Now.Month;
                    return regex.IsMatch(input) && ismonth;
                }
                bool ismonth2 = month > 0 && month <= 12;
                bool isyear = year > DateTime.Now.Year-2000;
                return regex.IsMatch(input) && ismonth2 && isyear;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            this.Text = "Payment Details";
            grpPaymentDetails.Width = this.Width;
            btnPay.BackColor = Color.Black;
            cmbBrand.SelectedIndex = 0;
            lblSummary.Text = $"Items in cart: {user.GetCart().GetItemCount()}\nTotal: {user.GetCart().GetTotalPrice()}";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(IsValidCCN(txtCCN.Text) && IsValidCVV(txtCVV.Text) && IsValidExp(txtExpiration.Text))
            {
                DialogResult dialogResult = MessageBox.Show($"Summary:\n{user.GetCart().ToString()}\nConfirm Purchase?","Confirm Purchase",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dialogResult == DialogResult.OK)
                {
                    MessageBox.Show($"Purchase Complete!\nEnjoy Your Movie 😁", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.GetCart().ClearCart();
                    lblSummary.Text = $"Items in cart: {user.GetCart().GetItemCount()}\nTotal: {user.GetCart().GetTotalPrice()}";
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Payment details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_MouseEnter(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.White;
            btnPay.ForeColor = Color.Black;

        }

        private void btnPay_MouseLeave(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.Black;
            btnPay.ForeColor = Color.White;

        }
    }
}
