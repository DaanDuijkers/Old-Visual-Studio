namespace Week2Demo
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
            this.txbLicensePlate = new System.Windows.Forms.TextBox();
            this.txbColor = new System.Windows.Forms.TextBox();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txbSpeed = new System.Windows.Forms.TextBox();
            this.lbTransportation = new System.Windows.Forms.ListBox();
            this.cbHasLuggageCarrier = new System.Windows.Forms.CheckBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnAddBicycle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbLicensePlate
            // 
            this.txbLicensePlate.Location = new System.Drawing.Point(178, 23);
            this.txbLicensePlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbLicensePlate.Name = "txbLicensePlate";
            this.txbLicensePlate.Size = new System.Drawing.Size(212, 28);
            this.txbLicensePlate.TabIndex = 0;
            // 
            // txbColor
            // 
            this.txbColor.Location = new System.Drawing.Point(178, 82);
            this.txbColor.Margin = new System.Windows.Forms.Padding(4);
            this.txbColor.Name = "txbColor";
            this.txbColor.Size = new System.Drawing.Size(212, 28);
            this.txbColor.TabIndex = 1;
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(45, 27);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(122, 24);
            this.lblLicensePlate.TabIndex = 2;
            this.lblLicensePlate.Text = "License Plate";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(45, 85);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(55, 24);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(45, 139);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(66, 24);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "Speed";
            // 
            // txbSpeed
            // 
            this.txbSpeed.Location = new System.Drawing.Point(178, 136);
            this.txbSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.txbSpeed.Name = "txbSpeed";
            this.txbSpeed.Size = new System.Drawing.Size(212, 28);
            this.txbSpeed.TabIndex = 5;
            // 
            // lbTransportation
            // 
            this.lbTransportation.FormattingEnabled = true;
            this.lbTransportation.ItemHeight = 22;
            this.lbTransportation.Location = new System.Drawing.Point(49, 263);
            this.lbTransportation.Name = "lbTransportation";
            this.lbTransportation.Size = new System.Drawing.Size(620, 246);
            this.lbTransportation.TabIndex = 6;
            // 
            // cbHasLuggageCarrier
            // 
            this.cbHasLuggageCarrier.AutoSize = true;
            this.cbHasLuggageCarrier.Location = new System.Drawing.Point(463, 27);
            this.cbHasLuggageCarrier.Name = "cbHasLuggageCarrier";
            this.cbHasLuggageCarrier.Size = new System.Drawing.Size(197, 28);
            this.cbHasLuggageCarrier.TabIndex = 7;
            this.cbHasLuggageCarrier.Text = "Has luggage carrier";
            this.cbHasLuggageCarrier.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(49, 203);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(92, 33);
            this.btnAddCar.TabIndex = 8;
            this.btnAddCar.Text = "Add car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnAddBicycle
            // 
            this.btnAddBicycle.Location = new System.Drawing.Point(537, 204);
            this.btnAddBicycle.Name = "btnAddBicycle";
            this.btnAddBicycle.Size = new System.Drawing.Size(123, 32);
            this.btnAddBicycle.TabIndex = 9;
            this.btnAddBicycle.Text = "Add bicycle";
            this.btnAddBicycle.UseVisualStyleBackColor = true;
            this.btnAddBicycle.Click += new System.EventHandler(this.btnAddBicycle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 540);
            this.Controls.Add(this.btnAddBicycle);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.cbHasLuggageCarrier);
            this.Controls.Add(this.lbTransportation);
            this.Controls.Add(this.txbSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.txbColor);
            this.Controls.Add(this.txbLicensePlate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLicensePlate;
        private System.Windows.Forms.TextBox txbColor;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txbSpeed;
        private System.Windows.Forms.ListBox lbTransportation;
        private System.Windows.Forms.CheckBox cbHasLuggageCarrier;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnAddBicycle;
    }
}

