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
    public partial class ProductDetails : Form
    {
        private Form1 form1;
        private ProductManager productManager;
        private Product edit;

        public ProductDetails(Form1 form1, ProductManager productManager)
        {
            InitializeComponent();

            this.form1 = form1;
            this.productManager = productManager;
            this.edit = null;

            cmbProductType.DataSource = Enum.GetValues(typeof(ProductType));
            cmbProductType.SelectedIndex = 0;
            cmbResolution.SelectedIndex = 0;
        }

        public ProductDetails(Form1 form1, ProductManager productManager, Product edit)
        {
            InitializeComponent();

            this.form1 = form1;
            this.productManager = productManager;
            this.edit = edit;

            cmbResolution.SelectedIndex = 0;

            cmbProductType.Enabled = false;
            txbName.Text = edit.Name;
            txbDescription.Text = edit.Description;
            txbPrice.Text = edit.Price.ToString();
            txbInStock.Text = edit.InStock.ToString();
            txbHeight.Text = edit.Height.ToString();
            txbWidth.Text = edit.Width.ToString();
            txbDepth.Text = edit.Depth.ToString();
            if (this.edit is Computer)
            {
                txbCPU.Text = ((Computer)edit).CPU;
                txbGPU.Text = ((Computer)edit).GPU;
                txbRAM.Text = ((Computer)edit).RAM.ToString();
                txbMotherboard.Text = ((Computer)edit).Motherboard;
                txbHz1.Text = ((Computer)edit).Hz.ToString();

                cmbResolution.Enabled = false;
                txbHz2.Enabled = false;
                txbReach1.Enabled = false;
                cbWireless1.Enabled = false;

                txbReach2.Enabled = false;
                cbWireless2.Enabled = false;
            }
            else if (this.edit is Screen)
            {
                txbCPU.Enabled = false;
                txbGPU.Enabled = false;
                txbRAM.Enabled = false;
                txbMotherboard.Enabled = false;
                txbHz1.Enabled = false;

                cmbResolution.SelectedItem = ((Screen)edit).Resolution;
                txbHz2.Text = ((Screen)edit).Hz.ToString();
                txbReach1.Text = ((Screen)edit).Reach.ToString();
                cbWireless1.Checked = ((Screen)edit).Wireless;

                txbReach2.Enabled = false;
                cbWireless2.Enabled = false;
            }
            else if (this.edit is Screen)
            {
                txbCPU.Enabled = false;
                txbGPU.Enabled = false;
                txbRAM.Enabled = false;
                txbMotherboard.Enabled = false;
                txbHz1.Enabled = false;

                cmbResolution.Enabled = false;
                txbHz2.Enabled = false;
                txbReach1.Enabled = false;
                cbWireless1.Enabled = false;

                txbReach2.Text = ((Accessory)edit).Reach.ToString();
                cbWireless2.Checked = ((Accessory)edit).Wireless;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit == null)
                {
                    if ((ProductType)cmbProductType.SelectedItem == ProductType.Computer)
                    {
                        if (txbName.Text != string.Empty && txbDescription.Text != string.Empty && txbPrice.Text != string.Empty && txbInStock.Text != string.Empty && txbHeight.Text != string.Empty && txbWidth.Text != string.Empty && txbDepth.Text != string.Empty && txbCPU.Text != string.Empty && txbGPU.Text != string.Empty && txbRAM.Text != string.Empty && txbMotherboard.Text != string.Empty && txbHz1.Text != string.Empty)
                        {
                            if (productManager.Add(new Computer(txbName.Text,
                                txbDescription.Text,
                                float.Parse(txbPrice.Text),
                                Convert.ToInt32(txbInStock.Text),
                                ProductType.Computer,
                                Convert.ToInt32(txbHeight.Text),
                                Convert.ToInt32(txbWidth.Text),
                                Convert.ToInt32(txbDepth.Text),
                                txbCPU.Text,
                                txbGPU.Text,
                                Convert.ToInt32(txbRAM.Text),
                                txbMotherboard.Text,
                                Convert.ToInt32(txbHz1.Text))) == true)
                            {
                                MessageBox.Show("New Computer was successfully added");
                                form1.GetProducts();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill in all required data for a computer");
                        }
                    }
                    else if ((ProductType)cmbProductType.SelectedItem == ProductType.Screen)
                    {
                        if (txbName.Text != string.Empty && txbDescription.Text != string.Empty && txbPrice.Text != string.Empty && txbInStock.Text != string.Empty && txbHeight.Text != string.Empty && txbWidth.Text != string.Empty && txbDepth.Text != string.Empty && txbHz2.Text != string.Empty)
                        {
                            if (productManager.Add(new Screen(txbName.Text,
                                txbDescription.Text,
                                float.Parse(txbPrice.Text),
                                Convert.ToInt32(txbInStock.Text),
                                ProductType.Computer,
                                Convert.ToInt32(txbHeight.Text),
                                Convert.ToInt32(txbWidth.Text),
                                Convert.ToInt32(txbDepth.Text),
                                cmbResolution.SelectedItem.ToString(),
                                Convert.ToInt32(txbHz1.Text),
                                cbWireless1.Checked,
                                Convert.ToInt32(txbReach1.Text))) == true)
                            {
                                MessageBox.Show("New screen was successfully added");
                                form1.GetProducts();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill in all required data for a screen");
                        }
                    }
                    else if ((ProductType)cmbProductType.SelectedItem == ProductType.Mouse || (ProductType)cmbProductType.SelectedItem == ProductType.Keyboard)
                    {
                        if (txbName.Text != string.Empty && txbDescription.Text != string.Empty && txbPrice.Text != string.Empty && txbInStock.Text != string.Empty && txbHeight.Text != string.Empty && txbWidth.Text != string.Empty && txbDepth.Text != string.Empty && txbReach2.Text != string.Empty)
                        {
                            if (productManager.Add(new Accessory(txbName.Text,
                                txbDescription.Text,
                                float.Parse(txbPrice.Text),
                                Convert.ToInt32(txbInStock.Text),
                                ProductType.Computer,
                                Convert.ToInt32(txbHeight.Text),
                                Convert.ToInt32(txbWidth.Text),
                                Convert.ToInt32(txbDepth.Text),
                                Convert.ToInt32(txbReach1.Text),
                                cbWireless2.Checked)) == true)
                            {
                                MessageBox.Show("New screen was successfully added");
                                form1.GetProducts();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill in all required data for a mouse/keyboard");
                        }
                    }
                }
                else
                {
                    edit.Name = txbName.Text;
                    edit.Description = txbDescription.Text;
                    edit.Price = float.Parse(txbPrice.Text);
                    edit.InStock = Convert.ToInt32(txbInStock.Text);
                    edit.Height = Convert.ToInt32(txbHeight.Text);
                    edit.Width = Convert.ToInt32(txbWidth.Text);
                    edit.Depth = Convert.ToInt32(txbDepth.Text);
                    if (this.edit is Computer)
                    {
                        ((Computer)edit).CPU = txbCPU.Text;
                        ((Computer)edit).GPU = txbGPU.Text;
                        ((Computer)edit).RAM = Convert.ToInt32(txbRAM.Text);
                        ((Computer)edit).Motherboard = txbMotherboard.Text;
                        ((Computer)edit).Hz = Convert.ToInt32(txbHz1.Text);
                    }
                    else if (this.edit is Screen)
                    {
                        ((Screen)edit).Resolution = cmbResolution.SelectedItem.ToString();
                        ((Screen)edit).Hz = Convert.ToInt32(txbHz2.Text);
                        ((Screen)edit).Reach = Convert.ToInt32(txbReach1.Text);
                        ((Screen)edit).Wireless = cbWireless1.Checked;
                    }
                    else if (this.edit is Screen)
                    {
                        ((Accessory)edit).Reach = Convert.ToInt32(txbReach2.Text);
                        ((Accessory)edit).Wireless = cbWireless2.Checked;
                    }

                    if (productManager.Edit(this.edit.ID, this.edit) == true)
                    {
                        MessageBox.Show("Product was updated");
                        form1.GetProducts();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}