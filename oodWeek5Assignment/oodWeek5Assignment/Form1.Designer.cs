
namespace oodWeek5Assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBlockPerson = new System.Windows.Forms.Button();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numRestock = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddToShoppingCart = new System.Windows.Forms.Button();
            this.numAddCartProduct = new System.Windows.Forms.NumericUpDown();
            this.btnEditShoppingCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestock)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddCartProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersons
            // 
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(13, 13);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowHeadersWidth = 51;
            this.dgvPersons.RowTemplate.Height = 29;
            this.dgvPersons.Size = new System.Drawing.Size(623, 272);
            this.dgvPersons.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(13, 291);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(623, 239);
            this.dgvProducts.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBlockPerson);
            this.groupBox1.Controls.Add(this.btnEditPerson);
            this.groupBox1.Controls.Add(this.btnAddPerson);
            this.groupBox1.Location = new System.Drawing.Point(643, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persons";
            // 
            // btnBlockPerson
            // 
            this.btnBlockPerson.Location = new System.Drawing.Point(7, 63);
            this.btnBlockPerson.Name = "btnBlockPerson";
            this.btnBlockPerson.Size = new System.Drawing.Size(94, 29);
            this.btnBlockPerson.TabIndex = 2;
            this.btnBlockPerson.Text = "Block";
            this.btnBlockPerson.UseVisualStyleBackColor = true;
            this.btnBlockPerson.Click += new System.EventHandler(this.btnBlockPerson_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(107, 26);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(94, 29);
            this.btnEditPerson.TabIndex = 1;
            this.btnEditPerson.Text = "Edit";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(7, 27);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(94, 29);
            this.btnAddPerson.TabIndex = 0;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numRestock);
            this.groupBox2.Controls.Add(this.btnRemoveProduct);
            this.groupBox2.Controls.Add(this.btnRestock);
            this.groupBox2.Controls.Add(this.btnEditProduct);
            this.groupBox2.Controls.Add(this.btnAddProduct);
            this.groupBox2.Location = new System.Drawing.Point(642, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 140);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // numRestock
            // 
            this.numRestock.Location = new System.Drawing.Point(115, 99);
            this.numRestock.Name = "numRestock";
            this.numRestock.Size = new System.Drawing.Size(155, 27);
            this.numRestock.TabIndex = 4;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(7, 62);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveProduct.TabIndex = 2;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.Location = new System.Drawing.Point(8, 97);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(93, 29);
            this.btnRestock.TabIndex = 3;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(107, 26);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(94, 29);
            this.btnEditProduct.TabIndex = 1;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(7, 27);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(94, 29);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddToShoppingCart);
            this.groupBox3.Controls.Add(this.numAddCartProduct);
            this.groupBox3.Controls.Add(this.btnEditShoppingCart);
            this.groupBox3.Location = new System.Drawing.Point(643, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 104);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping Cart";
            // 
            // AddToShoppingCart
            // 
            this.AddToShoppingCart.Location = new System.Drawing.Point(6, 22);
            this.AddToShoppingCart.Name = "AddToShoppingCart";
            this.AddToShoppingCart.Size = new System.Drawing.Size(93, 29);
            this.AddToShoppingCart.TabIndex = 5;
            this.AddToShoppingCart.Text = "Restock";
            this.AddToShoppingCart.UseVisualStyleBackColor = true;
            this.AddToShoppingCart.Click += new System.EventHandler(this.AddToShoppingCart_Click);
            // 
            // numAddCartProduct
            // 
            this.numAddCartProduct.Location = new System.Drawing.Point(114, 22);
            this.numAddCartProduct.Name = "numAddCartProduct";
            this.numAddCartProduct.Size = new System.Drawing.Size(155, 27);
            this.numAddCartProduct.TabIndex = 5;
            // 
            // btnEditShoppingCart
            // 
            this.btnEditShoppingCart.Location = new System.Drawing.Point(6, 61);
            this.btnEditShoppingCart.Name = "btnEditShoppingCart";
            this.btnEditShoppingCart.Size = new System.Drawing.Size(94, 29);
            this.btnEditShoppingCart.TabIndex = 0;
            this.btnEditShoppingCart.Text = "Edit";
            this.btnEditShoppingCart.UseVisualStyleBackColor = true;
            this.btnEditShoppingCart.Click += new System.EventHandler(this.btnEditShoppingCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvPersons);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRestock)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddCartProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBlockPerson;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditShoppingCart;
        private System.Windows.Forms.NumericUpDown numRestock;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button AddToShoppingCart;
        private System.Windows.Forms.NumericUpDown numAddCartProduct;
    }
}

