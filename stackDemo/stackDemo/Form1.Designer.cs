namespace stackDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.txbBook = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnNrOfItems = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 22;
            this.lbBooks.Location = new System.Drawing.Point(296, 12);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(309, 312);
            this.lbBooks.TabIndex = 0;
            // 
            // txbBook
            // 
            this.txbBook.Location = new System.Drawing.Point(296, 330);
            this.txbBook.Name = "txbBook";
            this.txbBook.Size = new System.Drawing.Size(309, 28);
            this.txbBook.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(410, 381);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 30);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnNrOfItems
            // 
            this.btnNrOfItems.Location = new System.Drawing.Point(505, 381);
            this.btnNrOfItems.Name = "btnNrOfItems";
            this.btnNrOfItems.Size = new System.Drawing.Size(118, 30);
            this.btnNrOfItems.TabIndex = 5;
            this.btnNrOfItems.Text = "Nr of items";
            this.btnNrOfItems.UseVisualStyleBackColor = true;
            this.btnNrOfItems.Click += new System.EventHandler(this.btnNrOfItems_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(652, 381);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 30);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(190, 333);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(58, 24);
            this.lblBook.TabIndex = 7;
            this.lblBook.Text = "Book:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 457);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnNrOfItems);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbBook);
            this.Controls.Add(this.lbBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.TextBox txbBook;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnNrOfItems;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblBook;
    }
}

