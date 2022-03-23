namespace Exam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.txbCapacity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbBarrelID = new System.Windows.Forms.TextBox();
            this.txbAmountOfWine = new System.Windows.Forms.TextBox();
            this.cmbKind = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddBarrel = new System.Windows.Forms.Button();
            this.btnRemoveBarrel = new System.Windows.Forms.Button();
            this.btnBarrelToCarrier = new System.Windows.Forms.Button();
            this.btnCarrierToBarrel = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbKind);
            this.groupBox1.Controls.Add(this.txbAmountOfWine);
            this.groupBox1.Controls.Add(this.txbBarrelID);
            this.groupBox1.Controls.Add(this.txbCapacity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(704, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(496, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add / remove barrel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID barrel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount of wine:";
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 18;
            this.lbOutput.Location = new System.Drawing.Point(13, 13);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(669, 364);
            this.lbOutput.TabIndex = 1;
            // 
            // txbCapacity
            // 
            this.txbCapacity.Location = new System.Drawing.Point(127, 37);
            this.txbCapacity.Name = "txbCapacity";
            this.txbCapacity.Size = new System.Drawing.Size(100, 24);
            this.txbCapacity.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.btnStore);
            this.groupBox2.Controls.Add(this.btnStatistics);
            this.groupBox2.Controls.Add(this.btnCarrierToBarrel);
            this.groupBox2.Controls.Add(this.btnBarrelToCarrier);
            this.groupBox2.Controls.Add(this.btnRemoveBarrel);
            this.groupBox2.Controls.Add(this.btnAddBarrel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(704, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(496, 286);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txbBarrelID
            // 
            this.txbBarrelID.Location = new System.Drawing.Point(127, 85);
            this.txbBarrelID.Name = "txbBarrelID";
            this.txbBarrelID.Size = new System.Drawing.Size(100, 24);
            this.txbBarrelID.TabIndex = 4;
            // 
            // txbAmountOfWine
            // 
            this.txbAmountOfWine.Location = new System.Drawing.Point(127, 137);
            this.txbAmountOfWine.Name = "txbAmountOfWine";
            this.txbAmountOfWine.Size = new System.Drawing.Size(100, 24);
            this.txbAmountOfWine.TabIndex = 5;
            // 
            // cmbKind
            // 
            this.cmbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKind.FormattingEnabled = true;
            this.cmbKind.Location = new System.Drawing.Point(308, 65);
            this.cmbKind.Name = "cmbKind";
            this.cmbKind.Size = new System.Drawing.Size(121, 26);
            this.cmbKind.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kind of wine:";
            // 
            // btnAddBarrel
            // 
            this.btnAddBarrel.Location = new System.Drawing.Point(44, 34);
            this.btnAddBarrel.Name = "btnAddBarrel";
            this.btnAddBarrel.Size = new System.Drawing.Size(153, 35);
            this.btnAddBarrel.TabIndex = 0;
            this.btnAddBarrel.Text = "Add Barrel";
            this.btnAddBarrel.UseVisualStyleBackColor = true;
            this.btnAddBarrel.Click += new System.EventHandler(this.btnAddBarrel_Click);
            // 
            // btnRemoveBarrel
            // 
            this.btnRemoveBarrel.Location = new System.Drawing.Point(247, 34);
            this.btnRemoveBarrel.Name = "btnRemoveBarrel";
            this.btnRemoveBarrel.Size = new System.Drawing.Size(153, 35);
            this.btnRemoveBarrel.TabIndex = 1;
            this.btnRemoveBarrel.Text = "Remove Barrel";
            this.btnRemoveBarrel.UseVisualStyleBackColor = true;
            this.btnRemoveBarrel.Click += new System.EventHandler(this.btnRemoveBarrel_Click);
            // 
            // btnBarrelToCarrier
            // 
            this.btnBarrelToCarrier.Location = new System.Drawing.Point(44, 88);
            this.btnBarrelToCarrier.Name = "btnBarrelToCarrier";
            this.btnBarrelToCarrier.Size = new System.Drawing.Size(356, 35);
            this.btnBarrelToCarrier.TabIndex = 2;
            this.btnBarrelToCarrier.Text = "From Barrel to Carrier";
            this.btnBarrelToCarrier.UseVisualStyleBackColor = true;
            // 
            // btnCarrierToBarrel
            // 
            this.btnCarrierToBarrel.Location = new System.Drawing.Point(44, 129);
            this.btnCarrierToBarrel.Name = "btnCarrierToBarrel";
            this.btnCarrierToBarrel.Size = new System.Drawing.Size(356, 35);
            this.btnCarrierToBarrel.TabIndex = 3;
            this.btnCarrierToBarrel.Text = "From Carrier to Barrel";
            this.btnCarrierToBarrel.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(44, 181);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(356, 35);
            this.btnStatistics.TabIndex = 4;
            this.btnStatistics.Text = "Show Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(44, 231);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(356, 35);
            this.btnStore.TabIndex = 5;
            this.btnStore.Text = "Store incoming wine";
            this.btnStore.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.rbC);
            this.groupBox3.Controls.Add(this.rbB);
            this.groupBox3.Controls.Add(this.rbA);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 384);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(669, 142);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carriers";
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(8, 25);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(87, 22);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "Carrier A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(8, 65);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(88, 22);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "Carrier B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(8, 100);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(89, 22);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "Carrier C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKind;
        private System.Windows.Forms.TextBox txbAmountOfWine;
        private System.Windows.Forms.TextBox txbBarrelID;
        private System.Windows.Forms.TextBox txbCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnCarrierToBarrel;
        private System.Windows.Forms.Button btnBarrelToCarrier;
        private System.Windows.Forms.Button btnRemoveBarrel;
        private System.Windows.Forms.Button btnAddBarrel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
    }
}

