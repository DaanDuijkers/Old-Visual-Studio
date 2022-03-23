namespace truckCompany
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
            this.gbTrucks = new System.Windows.Forms.GroupBox();
            this.txbBoxesPerPallet = new System.Windows.Forms.TextBox();
            this.txbTruckCapacity = new System.Windows.Forms.TextBox();
            this.lblBoxesPerPallet = new System.Windows.Forms.Label();
            this.lblTruckCapacity = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.txbBoxes = new System.Windows.Forms.TextBox();
            this.lblBoxes = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblRemainingPallets = new System.Windows.Forms.Label();
            this.lblRemainingBoxes = new System.Windows.Forms.Label();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.lblTruckPrice = new System.Windows.Forms.Label();
            this.lblPaletPrice = new System.Windows.Forms.Label();
            this.lblBoxPrice = new System.Windows.Forms.Label();
            this.gbTrucks.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTrucks
            // 
            this.gbTrucks.BackColor = System.Drawing.Color.PeachPuff;
            this.gbTrucks.Controls.Add(this.txbBoxesPerPallet);
            this.gbTrucks.Controls.Add(this.txbTruckCapacity);
            this.gbTrucks.Controls.Add(this.lblBoxesPerPallet);
            this.gbTrucks.Controls.Add(this.lblTruckCapacity);
            this.gbTrucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrucks.Location = new System.Drawing.Point(12, 12);
            this.gbTrucks.Name = "gbTrucks";
            this.gbTrucks.Size = new System.Drawing.Size(446, 426);
            this.gbTrucks.TabIndex = 0;
            this.gbTrucks.TabStop = false;
            this.gbTrucks.Text = "Info truck and pallet";
            // 
            // txbBoxesPerPallet
            // 
            this.txbBoxesPerPallet.Location = new System.Drawing.Point(16, 211);
            this.txbBoxesPerPallet.Name = "txbBoxesPerPallet";
            this.txbBoxesPerPallet.Size = new System.Drawing.Size(247, 30);
            this.txbBoxesPerPallet.TabIndex = 4;
            // 
            // txbTruckCapacity
            // 
            this.txbTruckCapacity.Location = new System.Drawing.Point(11, 95);
            this.txbTruckCapacity.Name = "txbTruckCapacity";
            this.txbTruckCapacity.Size = new System.Drawing.Size(252, 30);
            this.txbTruckCapacity.TabIndex = 3;
            // 
            // lblBoxesPerPallet
            // 
            this.lblBoxesPerPallet.AutoSize = true;
            this.lblBoxesPerPallet.Location = new System.Drawing.Point(11, 183);
            this.lblBoxesPerPallet.Name = "lblBoxesPerPallet";
            this.lblBoxesPerPallet.Size = new System.Drawing.Size(195, 25);
            this.lblBoxesPerPallet.TabIndex = 2;
            this.lblBoxesPerPallet.Text = "Nr of boxes per pallet";
            // 
            // lblTruckCapacity
            // 
            this.lblTruckCapacity.AutoSize = true;
            this.lblTruckCapacity.Location = new System.Drawing.Point(6, 66);
            this.lblTruckCapacity.Name = "lblTruckCapacity";
            this.lblTruckCapacity.Size = new System.Drawing.Size(324, 25);
            this.lblTruckCapacity.TabIndex = 1;
            this.lblTruckCapacity.Text = "Capacity of truck (number of pallets)";
            // 
            // gbOrder
            // 
            this.gbOrder.BackColor = System.Drawing.Color.PeachPuff;
            this.gbOrder.Controls.Add(this.txbBoxes);
            this.gbOrder.Controls.Add(this.lblBoxes);
            this.gbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrder.Location = new System.Drawing.Point(464, 12);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(391, 426);
            this.gbOrder.TabIndex = 1;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "About this order";
            // 
            // txbBoxes
            // 
            this.txbBoxes.Location = new System.Drawing.Point(51, 94);
            this.txbBoxes.Name = "txbBoxes";
            this.txbBoxes.Size = new System.Drawing.Size(252, 30);
            this.txbBoxes.TabIndex = 4;
            // 
            // lblBoxes
            // 
            this.lblBoxes.AutoSize = true;
            this.lblBoxes.Location = new System.Drawing.Point(46, 66);
            this.lblBoxes.Name = "lblBoxes";
            this.lblBoxes.Size = new System.Drawing.Size(232, 25);
            this.lblBoxes.TabIndex = 0;
            this.lblBoxes.Text = "Number of boxes ordered";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(885, 318);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 36);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(1076, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 3;
            // 
            // lblRemainingPallets
            // 
            this.lblRemainingPallets.AutoSize = true;
            this.lblRemainingPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingPallets.Location = new System.Drawing.Point(1076, 97);
            this.lblRemainingPallets.Name = "lblRemainingPallets";
            this.lblRemainingPallets.Size = new System.Drawing.Size(0, 25);
            this.lblRemainingPallets.TabIndex = 4;
            // 
            // lblRemainingBoxes
            // 
            this.lblRemainingBoxes.AutoSize = true;
            this.lblRemainingBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingBoxes.Location = new System.Drawing.Point(1081, 169);
            this.lblRemainingBoxes.Name = "lblRemainingBoxes";
            this.lblRemainingBoxes.Size = new System.Drawing.Size(0, 25);
            this.lblRemainingBoxes.TabIndex = 5;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(885, 106);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(101, 21);
            this.rbA.TabIndex = 6;
            this.rbA.TabStop = true;
            this.rbA.Text = "Company A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(885, 170);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(101, 21);
            this.rbB.TabIndex = 7;
            this.rbB.TabStop = true;
            this.rbB.Text = "Company B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(885, 232);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(101, 21);
            this.rbC.TabIndex = 8;
            this.rbC.TabStop = true;
            this.rbC.Text = "Company C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // lblTruckPrice
            // 
            this.lblTruckPrice.AutoSize = true;
            this.lblTruckPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruckPrice.Location = new System.Drawing.Point(1083, 232);
            this.lblTruckPrice.Name = "lblTruckPrice";
            this.lblTruckPrice.Size = new System.Drawing.Size(0, 25);
            this.lblTruckPrice.TabIndex = 9;
            // 
            // lblPaletPrice
            // 
            this.lblPaletPrice.AutoSize = true;
            this.lblPaletPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaletPrice.Location = new System.Drawing.Point(1081, 303);
            this.lblPaletPrice.Name = "lblPaletPrice";
            this.lblPaletPrice.Size = new System.Drawing.Size(0, 25);
            this.lblPaletPrice.TabIndex = 10;
            // 
            // lblBoxPrice
            // 
            this.lblBoxPrice.AutoSize = true;
            this.lblBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxPrice.Location = new System.Drawing.Point(1081, 381);
            this.lblBoxPrice.Name = "lblBoxPrice";
            this.lblBoxPrice.Size = new System.Drawing.Size(0, 25);
            this.lblBoxPrice.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 450);
            this.Controls.Add(this.lblBoxPrice);
            this.Controls.Add(this.lblPaletPrice);
            this.Controls.Add(this.lblTruckPrice);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.lblRemainingBoxes);
            this.Controls.Add(this.lblRemainingPallets);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.gbTrucks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTrucks.ResumeLayout(false);
            this.gbTrucks.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTrucks;
        private System.Windows.Forms.TextBox txbBoxesPerPallet;
        private System.Windows.Forms.TextBox txbTruckCapacity;
        private System.Windows.Forms.Label lblBoxesPerPallet;
        private System.Windows.Forms.Label lblTruckCapacity;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.TextBox txbBoxes;
        private System.Windows.Forms.Label lblBoxes;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblRemainingPallets;
        private System.Windows.Forms.Label lblRemainingBoxes;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.Label lblTruckPrice;
        private System.Windows.Forms.Label lblPaletPrice;
        private System.Windows.Forms.Label lblBoxPrice;
    }
}

