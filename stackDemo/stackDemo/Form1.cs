using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stackDemo
{
    public partial class Form1 : Form
    {
        private Bookshelf shelf = null;
        public Form1()
        {
            InitializeComponent();

            shelf = new Bookshelf();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            shelf.AddItem(txbBook.Text);
            //lbBooks.Items.Insert(0, txbBook.Text);
            lbBooks.Items.Add(txbBook.Text);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (shelf.NumberOfItems() > 0)
            {
                MessageBox.Show("Get Item: " + shelf.GetItem());
                lbBooks.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("No books available");
            }
        }

        private void btnNrOfItems_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nr of books " + shelf.NumberOfItems()) ;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (shelf.NumberOfItems() > 0)
            {
                MessageBox.Show("Viewing book: " + shelf.ViewItem());
            }
            else
            {
                MessageBox.Show("No books available");
            }
        }
    }
}
