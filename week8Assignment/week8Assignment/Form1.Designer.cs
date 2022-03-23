namespace week8Assignment
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
            this.lblAddCity = new System.Windows.Forms.Label();
            this.lblRemoveCity = new System.Windows.Forms.Label();
            this.lblRemoveIndex = new System.Windows.Forms.Label();
            this.txbRemoveCity = new System.Windows.Forms.TextBox();
            this.txbAddCity = new System.Windows.Forms.TextBox();
            this.txbRemoveIndex = new System.Windows.Forms.TextBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnRemoveIndex = new System.Windows.Forms.Button();
            this.btnRemoveCity = new System.Windows.Forms.Button();
            this.btnSortCity = new System.Windows.Forms.Button();
            this.lbCities = new System.Windows.Forms.ListBox();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddCity
            // 
            this.lblAddCity.AutoSize = true;
            this.lblAddCity.Location = new System.Drawing.Point(12, 9);
            this.lblAddCity.Name = "lblAddCity";
            this.lblAddCity.Size = new System.Drawing.Size(200, 25);
            this.lblAddCity.TabIndex = 0;
            this.lblAddCity.Text = "Enter city to be added";
            // 
            // lblRemoveCity
            // 
            this.lblRemoveCity.AutoSize = true;
            this.lblRemoveCity.Location = new System.Drawing.Point(12, 153);
            this.lblRemoveCity.Name = "lblRemoveCity";
            this.lblRemoveCity.Size = new System.Drawing.Size(296, 25);
            this.lblRemoveCity.TabIndex = 2;
            this.lblRemoveCity.Text = "Enter name of city to be removed";
            // 
            // lblRemoveIndex
            // 
            this.lblRemoveIndex.AutoSize = true;
            this.lblRemoveIndex.Location = new System.Drawing.Point(12, 80);
            this.lblRemoveIndex.Name = "lblRemoveIndex";
            this.lblRemoveIndex.Size = new System.Drawing.Size(294, 25);
            this.lblRemoveIndex.TabIndex = 3;
            this.lblRemoveIndex.Text = "Enter index of city to be removed";
            // 
            // txbRemoveCity
            // 
            this.txbRemoveCity.Location = new System.Drawing.Point(12, 181);
            this.txbRemoveCity.Name = "txbRemoveCity";
            this.txbRemoveCity.Size = new System.Drawing.Size(232, 30);
            this.txbRemoveCity.TabIndex = 6;
            // 
            // txbAddCity
            // 
            this.txbAddCity.Location = new System.Drawing.Point(12, 37);
            this.txbAddCity.Name = "txbAddCity";
            this.txbAddCity.Size = new System.Drawing.Size(232, 30);
            this.txbAddCity.TabIndex = 7;
            // 
            // txbRemoveIndex
            // 
            this.txbRemoveIndex.Location = new System.Drawing.Point(12, 108);
            this.txbRemoveIndex.Name = "txbRemoveIndex";
            this.txbRemoveIndex.Size = new System.Drawing.Size(232, 30);
            this.txbRemoveIndex.TabIndex = 8;
            this.txbRemoveIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRemoveIndex_KeyPress);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(341, 35);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(220, 35);
            this.btnAddCity.TabIndex = 9;
            this.btnAddCity.Text = "Add cityname";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnRemoveIndex
            // 
            this.btnRemoveIndex.Location = new System.Drawing.Point(341, 106);
            this.btnRemoveIndex.Name = "btnRemoveIndex";
            this.btnRemoveIndex.Size = new System.Drawing.Size(220, 35);
            this.btnRemoveIndex.TabIndex = 10;
            this.btnRemoveIndex.Text = "Remove city at index";
            this.btnRemoveIndex.UseVisualStyleBackColor = true;
            this.btnRemoveIndex.Click += new System.EventHandler(this.btnRemoveIndex_Click);
            // 
            // btnRemoveCity
            // 
            this.btnRemoveCity.Location = new System.Drawing.Point(341, 179);
            this.btnRemoveCity.Name = "btnRemoveCity";
            this.btnRemoveCity.Size = new System.Drawing.Size(220, 34);
            this.btnRemoveCity.TabIndex = 11;
            this.btnRemoveCity.Text = "Remove city with name";
            this.btnRemoveCity.UseVisualStyleBackColor = true;
            this.btnRemoveCity.Click += new System.EventHandler(this.btnRemoveCity_Click);
            // 
            // btnSortCity
            // 
            this.btnSortCity.Location = new System.Drawing.Point(12, 495);
            this.btnSortCity.Name = "btnSortCity";
            this.btnSortCity.Size = new System.Drawing.Size(232, 34);
            this.btnSortCity.TabIndex = 12;
            this.btnSortCity.Text = "Sort city names";
            this.btnSortCity.UseVisualStyleBackColor = true;
            this.btnSortCity.Click += new System.EventHandler(this.btnSortCity_Click);
            // 
            // lbCities
            // 
            this.lbCities.FormattingEnabled = true;
            this.lbCities.ItemHeight = 25;
            this.lbCities.Location = new System.Drawing.Point(598, 13);
            this.lbCities.Name = "lbCities";
            this.lbCities.Size = new System.Drawing.Size(259, 454);
            this.lbCities.TabIndex = 13;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(250, 495);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(607, 33);
            this.btnRemoveSelected.TabIndex = 14;
            this.btnRemoveSelected.Text = "Remove the one that is selected in the listbox";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 541);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.lbCities);
            this.Controls.Add(this.btnSortCity);
            this.Controls.Add(this.btnRemoveCity);
            this.Controls.Add(this.btnRemoveIndex);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.txbRemoveIndex);
            this.Controls.Add(this.txbAddCity);
            this.Controls.Add(this.txbRemoveCity);
            this.Controls.Add(this.lblRemoveIndex);
            this.Controls.Add(this.lblRemoveCity);
            this.Controls.Add(this.lblAddCity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCity;
        private System.Windows.Forms.Label lblRemoveCity;
        private System.Windows.Forms.Label lblRemoveIndex;
        private System.Windows.Forms.TextBox txbRemoveCity;
        private System.Windows.Forms.TextBox txbAddCity;
        private System.Windows.Forms.TextBox txbRemoveIndex;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnRemoveIndex;
        private System.Windows.Forms.Button btnRemoveCity;
        private System.Windows.Forms.Button btnSortCity;
        private System.Windows.Forms.ListBox lbCities;
        private System.Windows.Forms.Button btnRemoveSelected;
    }
}

