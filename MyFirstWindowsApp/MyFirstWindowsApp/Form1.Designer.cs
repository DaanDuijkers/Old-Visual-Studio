namespace MyFirstWindowsApp
{
    partial class frmMyFirstProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyFirstProgram));
            this.trbTrack = new System.Windows.Forms.TrackBar();
            this.btnIdentifier = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.prgbProgress = new System.Windows.Forms.ProgressBar();
            this.rbtnMakeMeRed = new System.Windows.Forms.RadioButton();
            this.rbtnMakeMeYellow = new System.Windows.Forms.RadioButton();
            this.rbtnMakeMeBlue = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trbTrack
            // 
            this.trbTrack.BackColor = System.Drawing.Color.Red;
            this.trbTrack.Location = new System.Drawing.Point(66, 230);
            this.trbTrack.Maximum = 100;
            this.trbTrack.Name = "trbTrack";
            this.trbTrack.Size = new System.Drawing.Size(721, 56);
            this.trbTrack.TabIndex = 0;
            this.trbTrack.Value = 20;
            this.trbTrack.Scroll += new System.EventHandler(this.trbTrack_Scroll);
            // 
            // btnIdentifier
            // 
            this.btnIdentifier.BackColor = System.Drawing.Color.Yellow;
            this.btnIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentifier.Location = new System.Drawing.Point(66, 73);
            this.btnIdentifier.Name = "btnIdentifier";
            this.btnIdentifier.Size = new System.Drawing.Size(165, 70);
            this.btnIdentifier.TabIndex = 1;
            this.btnIdentifier.Text = "Who am I ? ? ?";
            this.btnIdentifier.UseVisualStyleBackColor = false;
            this.btnIdentifier.Click += new System.EventHandler(this.btnIdentifier_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(66, 350);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(34, 25);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "30";
            // 
            // prgbProgress
            // 
            this.prgbProgress.Location = new System.Drawing.Point(136, 350);
            this.prgbProgress.Name = "prgbProgress";
            this.prgbProgress.Size = new System.Drawing.Size(651, 25);
            this.prgbProgress.TabIndex = 3;
            // 
            // rbtnMakeMeRed
            // 
            this.rbtnMakeMeRed.AutoSize = true;
            this.rbtnMakeMeRed.Location = new System.Drawing.Point(382, 47);
            this.rbtnMakeMeRed.Name = "rbtnMakeMeRed";
            this.rbtnMakeMeRed.Size = new System.Drawing.Size(99, 21);
            this.rbtnMakeMeRed.TabIndex = 4;
            this.rbtnMakeMeRed.TabStop = true;
            this.rbtnMakeMeRed.Text = "Make it red";
            this.rbtnMakeMeRed.UseVisualStyleBackColor = true;
            this.rbtnMakeMeRed.CheckedChanged += new System.EventHandler(this.rbtnMakeMeRed_CheckedChanged);
            // 
            // rbtnMakeMeYellow
            // 
            this.rbtnMakeMeYellow.AutoSize = true;
            this.rbtnMakeMeYellow.Location = new System.Drawing.Point(382, 90);
            this.rbtnMakeMeYellow.Name = "rbtnMakeMeYellow";
            this.rbtnMakeMeYellow.Size = new System.Drawing.Size(116, 21);
            this.rbtnMakeMeYellow.TabIndex = 5;
            this.rbtnMakeMeYellow.TabStop = true;
            this.rbtnMakeMeYellow.Text = "Make it yellow";
            this.rbtnMakeMeYellow.UseVisualStyleBackColor = true;
            this.rbtnMakeMeYellow.CheckedChanged += new System.EventHandler(this.rbtnMakeMeYellow_CheckedChanged);
            // 
            // rbtnMakeMeBlue
            // 
            this.rbtnMakeMeBlue.AutoSize = true;
            this.rbtnMakeMeBlue.Location = new System.Drawing.Point(382, 135);
            this.rbtnMakeMeBlue.Name = "rbtnMakeMeBlue";
            this.rbtnMakeMeBlue.Size = new System.Drawing.Size(105, 21);
            this.rbtnMakeMeBlue.TabIndex = 6;
            this.rbtnMakeMeBlue.TabStop = true;
            this.rbtnMakeMeBlue.Text = "Make it blue";
            this.rbtnMakeMeBlue.UseVisualStyleBackColor = true;
            this.rbtnMakeMeBlue.CheckedChanged += new System.EventHandler(this.rbtnMakeMeBlue_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(621, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmMyFirstProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbtnMakeMeBlue);
            this.Controls.Add(this.rbtnMakeMeYellow);
            this.Controls.Add(this.rbtnMakeMeRed);
            this.Controls.Add(this.prgbProgress);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnIdentifier);
            this.Controls.Add(this.trbTrack);
            this.Name = "frmMyFirstProgram";
            this.Text = "My first program";
            ((System.ComponentModel.ISupportInitialize)(this.trbTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbTrack;
        private System.Windows.Forms.Button btnIdentifier;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ProgressBar prgbProgress;
        private System.Windows.Forms.RadioButton rbtnMakeMeRed;
        private System.Windows.Forms.RadioButton rbtnMakeMeYellow;
        private System.Windows.Forms.RadioButton rbtnMakeMeBlue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

