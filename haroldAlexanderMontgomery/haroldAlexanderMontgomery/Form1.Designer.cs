namespace haroldAlexanderMontgomery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.rbLemonade = new System.Windows.Forms.RadioButton();
            this.rbBeer = new System.Windows.Forms.RadioButton();
            this.cbAge = new System.Windows.Forms.CheckBox();
            this.pbBeer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(161, 285);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(139, 37);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order a drink";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(85, 362);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 4;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(80, 41);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(378, 46);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome to the bar!";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(85, 142);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(265, 25);
            this.lblOrder.TabIndex = 7;
            this.lblOrder.Text = "What would you like to drink?";
            // 
            // rbLemonade
            // 
            this.rbLemonade.AutoSize = true;
            this.rbLemonade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLemonade.Location = new System.Drawing.Point(88, 193);
            this.rbLemonade.Name = "rbLemonade";
            this.rbLemonade.Size = new System.Drawing.Size(119, 29);
            this.rbLemonade.TabIndex = 8;
            this.rbLemonade.TabStop = true;
            this.rbLemonade.Text = "lemonade";
            this.rbLemonade.UseVisualStyleBackColor = true;
            // 
            // rbBeer
            // 
            this.rbBeer.AutoSize = true;
            this.rbBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBeer.Location = new System.Drawing.Point(213, 193);
            this.rbBeer.Name = "rbBeer";
            this.rbBeer.Size = new System.Drawing.Size(72, 29);
            this.rbBeer.TabIndex = 9;
            this.rbBeer.TabStop = true;
            this.rbBeer.Text = "beer";
            this.rbBeer.UseVisualStyleBackColor = true;
            // 
            // cbAge
            // 
            this.cbAge.AutoSize = true;
            this.cbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAge.Location = new System.Drawing.Point(292, 193);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(141, 29);
            this.cbAge.TabIndex = 10;
            this.cbAge.Text = "I am over 18";
            this.cbAge.UseVisualStyleBackColor = true;
            // 
            // pbBeer
            // 
            this.pbBeer.Image = ((System.Drawing.Image)(resources.GetObject("pbBeer.Image")));
            this.pbBeer.Location = new System.Drawing.Point(512, 53);
            this.pbBeer.Name = "pbBeer";
            this.pbBeer.Size = new System.Drawing.Size(402, 283);
            this.pbBeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBeer.TabIndex = 11;
            this.pbBeer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.pbBeer);
            this.Controls.Add(this.cbAge);
            this.Controls.Add(this.rbBeer);
            this.Controls.Add(this.rbLemonade);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbBeer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.RadioButton rbLemonade;
        private System.Windows.Forms.RadioButton rbBeer;
        private System.Windows.Forms.CheckBox cbAge;
        private System.Windows.Forms.PictureBox pbBeer;
    }
}

