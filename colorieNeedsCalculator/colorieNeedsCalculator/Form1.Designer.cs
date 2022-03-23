namespace colorieNeedsCalculator
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
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbActivityLevel = new System.Windows.Forms.GroupBox();
            this.rbExtremelyActive = new System.Windows.Forms.RadioButton();
            this.rbVeryActive = new System.Windows.Forms.RadioButton();
            this.rbModeratelyActive = new System.Windows.Forms.RadioButton();
            this.rbLightlyActive = new System.Windows.Forms.RadioButton();
            this.rbSedentary = new System.Windows.Forms.RadioButton();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBmrValue = new System.Windows.Forms.Label();
            this.lblDailyCalorieNeeds = new System.Windows.Forms.Label();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.txbLength = new System.Windows.Forms.TextBox();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.btnBMR = new System.Windows.Forms.Button();
            this.btnCalorieNeeds = new System.Windows.Forms.Button();
            this.grbGender.SuspendLayout();
            this.rbActivityLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rbWoman);
            this.grbGender.Controls.Add(this.rbMan);
            this.grbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGender.Location = new System.Drawing.Point(18, 19);
            this.grbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbGender.Name = "grbGender";
            this.grbGender.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbGender.Size = new System.Drawing.Size(302, 141);
            this.grbGender.TabIndex = 0;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(59, 75);
            this.rbWoman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(102, 29);
            this.rbWoman.TabIndex = 2;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Woman";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(59, 33);
            this.rbMan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(72, 29);
            this.rbMan.TabIndex = 1;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbActivityLevel
            // 
            this.rbActivityLevel.Controls.Add(this.rbExtremelyActive);
            this.rbActivityLevel.Controls.Add(this.rbVeryActive);
            this.rbActivityLevel.Controls.Add(this.rbModeratelyActive);
            this.rbActivityLevel.Controls.Add(this.rbLightlyActive);
            this.rbActivityLevel.Controls.Add(this.rbSedentary);
            this.rbActivityLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivityLevel.Location = new System.Drawing.Point(507, 19);
            this.rbActivityLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbActivityLevel.Name = "rbActivityLevel";
            this.rbActivityLevel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbActivityLevel.Size = new System.Drawing.Size(444, 272);
            this.rbActivityLevel.TabIndex = 1;
            this.rbActivityLevel.TabStop = false;
            this.rbActivityLevel.Text = "Activity Level";
            // 
            // rbExtremelyActive
            // 
            this.rbExtremelyActive.AutoSize = true;
            this.rbExtremelyActive.Location = new System.Drawing.Point(74, 220);
            this.rbExtremelyActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbExtremelyActive.Name = "rbExtremelyActive";
            this.rbExtremelyActive.Size = new System.Drawing.Size(178, 29);
            this.rbExtremelyActive.TabIndex = 4;
            this.rbExtremelyActive.TabStop = true;
            this.rbExtremelyActive.Text = "Extremely Active";
            this.rbExtremelyActive.UseVisualStyleBackColor = true;
            // 
            // rbVeryActive
            // 
            this.rbVeryActive.AutoSize = true;
            this.rbVeryActive.Location = new System.Drawing.Point(74, 171);
            this.rbVeryActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbVeryActive.Name = "rbVeryActive";
            this.rbVeryActive.Size = new System.Drawing.Size(133, 29);
            this.rbVeryActive.TabIndex = 3;
            this.rbVeryActive.TabStop = true;
            this.rbVeryActive.Text = "Very Active";
            this.rbVeryActive.UseVisualStyleBackColor = true;
            // 
            // rbModeratelyActive
            // 
            this.rbModeratelyActive.AutoSize = true;
            this.rbModeratelyActive.Location = new System.Drawing.Point(74, 123);
            this.rbModeratelyActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbModeratelyActive.Name = "rbModeratelyActive";
            this.rbModeratelyActive.Size = new System.Drawing.Size(189, 29);
            this.rbModeratelyActive.TabIndex = 2;
            this.rbModeratelyActive.TabStop = true;
            this.rbModeratelyActive.Text = "Moderately Active";
            this.rbModeratelyActive.UseVisualStyleBackColor = true;
            // 
            // rbLightlyActive
            // 
            this.rbLightlyActive.AutoSize = true;
            this.rbLightlyActive.Location = new System.Drawing.Point(74, 75);
            this.rbLightlyActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLightlyActive.Name = "rbLightlyActive";
            this.rbLightlyActive.Size = new System.Drawing.Size(148, 29);
            this.rbLightlyActive.TabIndex = 1;
            this.rbLightlyActive.TabStop = true;
            this.rbLightlyActive.Text = "Lightly Active";
            this.rbLightlyActive.UseVisualStyleBackColor = true;
            // 
            // rbSedentary
            // 
            this.rbSedentary.AutoSize = true;
            this.rbSedentary.Location = new System.Drawing.Point(74, 33);
            this.rbSedentary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSedentary.Name = "rbSedentary";
            this.rbSedentary.Size = new System.Drawing.Size(123, 29);
            this.rbSedentary.TabIndex = 0;
            this.rbSedentary.TabStop = true;
            this.rbSedentary.Text = "Sedentary";
            this.rbSedentary.UseVisualStyleBackColor = true;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(13, 192);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(122, 25);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight (kilo)";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(13, 278);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(117, 25);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Length (cm)";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(13, 360);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(105, 25);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age (year)";
            // 
            // lblBmrValue
            // 
            this.lblBmrValue.AutoSize = true;
            this.lblBmrValue.BackColor = System.Drawing.Color.PeachPuff;
            this.lblBmrValue.Location = new System.Drawing.Point(344, 396);
            this.lblBmrValue.Name = "lblBmrValue";
            this.lblBmrValue.Size = new System.Drawing.Size(0, 25);
            this.lblBmrValue.TabIndex = 5;
            // 
            // lblDailyCalorieNeeds
            // 
            this.lblDailyCalorieNeeds.AutoSize = true;
            this.lblDailyCalorieNeeds.BackColor = System.Drawing.Color.PeachPuff;
            this.lblDailyCalorieNeeds.Location = new System.Drawing.Point(880, 360);
            this.lblDailyCalorieNeeds.Name = "lblDailyCalorieNeeds";
            this.lblDailyCalorieNeeds.Size = new System.Drawing.Size(0, 25);
            this.lblDailyCalorieNeeds.TabIndex = 6;
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(18, 230);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(208, 30);
            this.txbWeight.TabIndex = 7;
            this.txbWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbWeight_KeyPress);
            // 
            // txbLength
            // 
            this.txbLength.Location = new System.Drawing.Point(17, 317);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(208, 30);
            this.txbLength.TabIndex = 8;
            this.txbLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLength_KeyPress);
            // 
            // txbAge
            // 
            this.txbAge.Location = new System.Drawing.Point(18, 398);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(207, 30);
            this.txbAge.TabIndex = 9;
            this.txbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAge_KeyPress);
            // 
            // btnBMR
            // 
            this.btnBMR.Location = new System.Drawing.Point(276, 228);
            this.btnBMR.Name = "btnBMR";
            this.btnBMR.Size = new System.Drawing.Size(179, 32);
            this.btnBMR.TabIndex = 10;
            this.btnBMR.Text = "Calculate BMR";
            this.btnBMR.UseVisualStyleBackColor = true;
            this.btnBMR.Click += new System.EventHandler(this.BtnBMR_Click);
            // 
            // btnCalorieNeeds
            // 
            this.btnCalorieNeeds.Location = new System.Drawing.Point(976, 230);
            this.btnCalorieNeeds.Name = "btnCalorieNeeds";
            this.btnCalorieNeeds.Size = new System.Drawing.Size(218, 61);
            this.btnCalorieNeeds.TabIndex = 11;
            this.btnCalorieNeeds.Text = "Calculate Daily Calorie Needs";
            this.btnCalorieNeeds.UseVisualStyleBackColor = true;
            this.btnCalorieNeeds.Click += new System.EventHandler(this.btnCalorieNeeds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 519);
            this.Controls.Add(this.btnCalorieNeeds);
            this.Controls.Add(this.btnBMR);
            this.Controls.Add(this.txbAge);
            this.Controls.Add(this.txbLength);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.lblDailyCalorieNeeds);
            this.Controls.Add(this.lblBmrValue);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.rbActivityLevel);
            this.Controls.Add(this.grbGender);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.rbActivityLevel.ResumeLayout(false);
            this.rbActivityLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.GroupBox rbActivityLevel;
        private System.Windows.Forms.RadioButton rbExtremelyActive;
        private System.Windows.Forms.RadioButton rbVeryActive;
        private System.Windows.Forms.RadioButton rbModeratelyActive;
        private System.Windows.Forms.RadioButton rbLightlyActive;
        private System.Windows.Forms.RadioButton rbSedentary;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBmrValue;
        private System.Windows.Forms.Label lblDailyCalorieNeeds;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.TextBox txbLength;
        private System.Windows.Forms.TextBox txbAge;
        private System.Windows.Forms.Button btnBMR;
        private System.Windows.Forms.Button btnCalorieNeeds;
    }
}

