using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodWeek5Assignment
{
    public partial class ShoppingCartForm : Form
    {
        private Form1 form1;
        private ShoppingCart shoppingCart;

        public ShoppingCartForm(Form1 form1, ShoppingCart shoppingCart)
        {
            InitializeComponent();

            this.form1 = form1;
            this.shoppingCart = shoppingCart;
            GetCartProducts();
        }

        private void GetCartProducts ()
        {
            float total = 0;
            foreach (CartProduct cp in shoppingCart.GetAll())
            {
                total += cp.TotalPrice;
            }
            lblTotalPrice.Text = total.ToString();

            BindingList<CartProduct> dataSource = new BindingList<CartProduct>(shoppingCart.GetAll());
            dgvCartProducts.DataSource = dataSource;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (shoppingCart.Return(((CartProduct)dgvCartProducts.CurrentRow.DataBoundItem).ID, Convert.ToInt32(numQuantity.Value)) == true)
                {
                    MessageBox.Show("Product(s) returned");
                    GetCartProducts();
                    form1.GetProducts();
                    form1.GetPersons();
                }
                else
                {
                    MessageBox.Show("Product was not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturnAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (shoppingCart.ReturnAll() == true)
                {
                    MessageBox.Show("Product(s) returned");
                    GetCartProducts();
                    form1.GetProducts();
                    form1.GetPersons();
                }
                else
                {
                    MessageBox.Show("Product was not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}