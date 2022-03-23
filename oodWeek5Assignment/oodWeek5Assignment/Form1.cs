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
    public partial class Form1 : Form
    {
        private ProductManager productManager;
        private PersonManager personManager;

        public Form1()
        {
            InitializeComponent();

            productManager = new ProductManager();
            personManager = new PersonManager(productManager);

            GetPersons();
            GetProducts();
        }

        #region Persons
        public void GetPersons ()
        {
            BindingList<Person> dataSource = new BindingList<Person>(personManager.GetAll());
            dgvPersons.DataSource = dataSource;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            PersonDetails personDetails = new PersonDetails(this, personManager, productManager);
            personDetails.Show();
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersons.SelectedRows.Count > 0)
                {
                    PersonDetails personDetails = new PersonDetails(this, personManager, productManager, (Person)dgvPersons.CurrentRow.DataBoundItem);
                    personDetails.Show();
                }
                else
                {
                    MessageBox.Show("Please select a person");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBlockPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (personManager.Block(((Person)dgvPersons.CurrentRow.DataBoundItem).ID))
                {
                    MessageBox.Show("Person was blocked");
                    GetPersons();
                }
                else
                {
                    MessageBox.Show("Person was unblocked");
                    GetPersons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Products
        public void GetProducts()
        {
            BindingList<Product> dataSource = new BindingList<Product>(productManager.GetAll());
            dgvProducts.DataSource = dataSource;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductDetails productDetails = new ProductDetails(this, productManager);
            productDetails.Show();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    ProductDetails productDetails = new ProductDetails(this, productManager, (Product)dgvProducts.CurrentRow.DataBoundItem);
                    productDetails.Show();
                }
                else
                {
                    MessageBox.Show("Please select a product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    if (productManager.Remove(((Product)dgvProducts.CurrentRow.DataBoundItem).ID) == true)
                    {
                        MessageBox.Show("Product removed");
                        GetProducts();
                    }
                    else
                    {
                        MessageBox.Show("Product does not exist");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    if (productManager.Restock(((Product)dgvProducts.CurrentRow.DataBoundItem).ID, Convert.ToInt32(numRestock.Value)))
                    {
                        MessageBox.Show("Product restocked");
                        GetPersons();
                        GetProducts();
                    }
                    else
                    {
                        MessageBox.Show("Product does not exist");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region ShoppingCart

        private void btnEditShoppingCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersons.SelectedRows.Count > 0)
                {
                    ShoppingCartForm shoppingCartForm = new ShoppingCartForm(this, ((Person)dgvPersons.CurrentRow.DataBoundItem).ShoppingCart);
                    shoppingCartForm.Show();
                }
                else
                {
                    MessageBox.Show("Please select a person");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void AddToShoppingCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersons.SelectedRows.Count > 0)
                {
                    if (((Person)dgvPersons.CurrentRow.DataBoundItem).ShoppingCart.Add((Product)dgvProducts.CurrentRow.DataBoundItem, Convert.ToInt32(numAddCartProduct.Value)) == true)
                    {
                        MessageBox.Show("Product was added");
                        GetPersons();
                        GetProducts();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient stock");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a person");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}