namespace OopAssignment
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
            this.tbActors = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.ListBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbZipcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAnimal = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAnimalName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.lbAdoptions = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddAdoption = new System.Windows.Forms.Button();
            this.lbSelectCustomer = new System.Windows.Forms.ListBox();
            this.lbSelectAnimal = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbAllCustomers = new System.Windows.Forms.ListBox();
            this.tbActors.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbActors
            // 
            this.tbActors.Controls.Add(this.tabPage1);
            this.tbActors.Controls.Add(this.tabPage2);
            this.tbActors.Controls.Add(this.tabPage3);
            this.tbActors.Controls.Add(this.tabPage4);
            this.tbActors.Location = new System.Drawing.Point(12, 12);
            this.tbActors.Name = "tbActors";
            this.tbActors.SelectedIndex = 0;
            this.tbActors.Size = new System.Drawing.Size(1890, 740);
            this.tbActors.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.lbCustomer);
            this.tabPage1.Controls.Add(this.btnAddCustomer);
            this.tabPage1.Controls.Add(this.txbCity);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txbZipcode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txbCustomerName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1882, 707);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "All Customers:";
            // 
            // lbCustomer
            // 
            this.lbCustomer.FormattingEnabled = true;
            this.lbCustomer.ItemHeight = 20;
            this.lbCustomer.Location = new System.Drawing.Point(212, 28);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.ScrollAlwaysVisible = true;
            this.lbCustomer.Size = new System.Drawing.Size(1660, 664);
            this.lbCustomer.TabIndex = 7;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(6, 186);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(151, 31);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(6, 154);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(200, 26);
            this.txbCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "City:";
            // 
            // txbZipcode
            // 
            this.txbZipcode.Location = new System.Drawing.Point(6, 92);
            this.txbZipcode.Name = "txbZipcode";
            this.txbZipcode.Size = new System.Drawing.Size(200, 26);
            this.txbZipcode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zipcode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Location = new System.Drawing.Point(6, 31);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(200, 26);
            this.txbCustomerName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.cmbGender);
            this.tabPage2.Controls.Add(this.btnAddAnimal);
            this.tabPage2.Controls.Add(this.cmbSize);
            this.tabPage2.Controls.Add(this.cmbSpecies);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lbAnimal);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txbAge);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txbNotes);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txbAnimalName);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1882, 707);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Animal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(208, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "All animals:";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(6, 218);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(200, 28);
            this.cmbGender.TabIndex = 16;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(6, 374);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(122, 29);
            this.btnAddAnimal.TabIndex = 15;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbSize.Location = new System.Drawing.Point(6, 340);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(200, 28);
            this.cmbSize.TabIndex = 14;
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Bird"});
            this.cmbSpecies.Location = new System.Drawing.Point(6, 93);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(200, 28);
            this.cmbSpecies.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Species";
            // 
            // lbAnimal
            // 
            this.lbAnimal.FormattingEnabled = true;
            this.lbAnimal.ItemHeight = 20;
            this.lbAnimal.Location = new System.Drawing.Point(212, 26);
            this.lbAnimal.Name = "lbAnimal";
            this.lbAnimal.ScrollAlwaysVisible = true;
            this.lbAnimal.Size = new System.Drawing.Size(1660, 664);
            this.lbAnimal.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Size (birds only):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Age:";
            // 
            // txbAge
            // 
            this.txbAge.Location = new System.Drawing.Point(6, 156);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(200, 26);
            this.txbAge.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Notes:";
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(6, 278);
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(200, 26);
            this.txbNotes.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // txbAnimalName
            // 
            this.txbAnimalName.Location = new System.Drawing.Point(6, 31);
            this.txbAnimalName.Name = "txbAnimalName";
            this.txbAnimalName.Size = new System.Drawing.Size(200, 26);
            this.txbAnimalName.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.lbAdoptions);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnAddAdoption);
            this.tabPage3.Controls.Add(this.lbSelectCustomer);
            this.tabPage3.Controls.Add(this.lbSelectAnimal);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1882, 707);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adoption";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(748, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "All adoptions:";
            // 
            // lbAdoptions
            // 
            this.lbAdoptions.FormattingEnabled = true;
            this.lbAdoptions.ItemHeight = 20;
            this.lbAdoptions.Location = new System.Drawing.Point(752, 29);
            this.lbAdoptions.Name = "lbAdoptions";
            this.lbAdoptions.ScrollAlwaysVisible = true;
            this.lbAdoptions.Size = new System.Drawing.Size(1124, 644);
            this.lbAdoptions.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Select Customer:";
            // 
            // btnAddAdoption
            // 
            this.btnAddAdoption.Location = new System.Drawing.Point(11, 664);
            this.btnAddAdoption.Name = "btnAddAdoption";
            this.btnAddAdoption.Size = new System.Drawing.Size(157, 30);
            this.btnAddAdoption.TabIndex = 5;
            this.btnAddAdoption.Text = "Add Adoption";
            this.btnAddAdoption.UseVisualStyleBackColor = true;
            this.btnAddAdoption.Click += new System.EventHandler(this.btnAddAdoption_Click);
            // 
            // lbSelectCustomer
            // 
            this.lbSelectCustomer.FormattingEnabled = true;
            this.lbSelectCustomer.ItemHeight = 20;
            this.lbSelectCustomer.Location = new System.Drawing.Point(11, 354);
            this.lbSelectCustomer.Name = "lbSelectCustomer";
            this.lbSelectCustomer.ScrollAlwaysVisible = true;
            this.lbSelectCustomer.Size = new System.Drawing.Size(722, 304);
            this.lbSelectCustomer.TabIndex = 4;
            // 
            // lbSelectAnimal
            // 
            this.lbSelectAnimal.FormattingEnabled = true;
            this.lbSelectAnimal.ItemHeight = 20;
            this.lbSelectAnimal.Location = new System.Drawing.Point(11, 29);
            this.lbSelectAnimal.Name = "lbSelectAnimal";
            this.lbSelectAnimal.ScrollAlwaysVisible = true;
            this.lbSelectAnimal.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSelectAnimal.Size = new System.Drawing.Size(722, 284);
            this.lbSelectAnimal.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Select an animal:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbAllCustomers);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1882, 707);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Activity";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbAllCustomers
            // 
            this.lbAllCustomers.FormattingEnabled = true;
            this.lbAllCustomers.ItemHeight = 20;
            this.lbAllCustomers.Location = new System.Drawing.Point(7, 7);
            this.lbAllCustomers.Name = "lbAllCustomers";
            this.lbAllCustomers.Size = new System.Drawing.Size(652, 684);
            this.lbAllCustomers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 763);
            this.Controls.Add(this.tbActors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbActors.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbActors;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbZipcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbAnimalName;
        private System.Windows.Forms.ListBox lbAnimal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ListBox lbSelectAnimal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbAdoptions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddAdoption;
        private System.Windows.Forms.ListBox lbSelectCustomer;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lbAllCustomers;
    }
}

