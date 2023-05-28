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
        private Cart cart;
        private Item selectedItem;
        public CartInfo()
        {
            InitializeComponent();
        }

        public CartInfo(Cart cart) : this()
        {
            this.cart = cart;
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

        private void UpdateCartSummary()
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
    }
}
