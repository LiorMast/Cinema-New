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
    public partial class CartInfo : Form
    {
        private User activeuser;
        private Cart cart;
        private Item selectedItem;
        public CartInfo()
        {
            InitializeComponent();
        }

        public CartInfo(User user) : this()
        {
            this.activeuser = user;
            this.cart = user.GetCart();
            UpdateCartList();
            lstCartItems.SelectedIndex = 0;
            UpdateCartSummary();
        }

        private void CartInfo_Load(object sender, EventArgs e)
        {

        }

        private void UpdateCartList()
        {
            lstCartItems.Items.Clear();
            for (int i = 0; i < cart.GetItemCount(); i++)
            {
                lstCartItems.Items.Add(cart.GetItems()[i]);
            }
        }

        public void UpdateCartSummary()
        {
            lblCartSummary.Text = $"Items in cart: {cart.GetItemCount()}\nTotal: {cart.GetTotalPrice()}";
        }

        private void lstCartItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { selectedItem = cart.GetItems()[lstCartItems.SelectedIndex]; } catch(Exception) { selectedItem = null; }
        }

        private void btnCartRemove_Click(object sender, EventArgs e)
        {
            try
            {
                cart.DeleteItem(selectedItem);
                UpdateCartList();
                UpdateCartSummary();
                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCartCheckout_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(activeuser);
            checkout.ShowDialog();
            Close();
        }

        private void btnCartRemove_MouseEnter(object sender, EventArgs e)
        {
            btnCartRemove.BackColor = Color.White;
            btnCartRemove.ForeColor = Color.Black;

        }

        private void btnCartRemove_MouseLeave(object sender, EventArgs e)
        {
            btnCartRemove.BackColor = Color.Black;
            btnCartRemove.ForeColor = Color.White;

        }

        private void btnCartCheckout_MouseEnter(object sender, EventArgs e)
        {
            btnCartCheckout.BackColor = Color.White;
            btnCartCheckout.ForeColor = Color.Black;

        }

        private void btnCartCheckout_MouseLeave(object sender, EventArgs e)
        {
            btnCartCheckout.BackColor = Color.Black;
            btnCartCheckout.ForeColor = Color.White;

        }
    }
}
