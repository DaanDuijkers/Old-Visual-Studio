namespace DemoStreetApp
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
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txbStreetName = new System.Windows.Forms.TextBox();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSpawnCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Location = new System.Drawing.Point(219, 88);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(116, 24);
            this.lblStreetName.TabIndex = 0;
            this.lblStreetName.Text = "Street name:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(223, 152);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 24);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // txbStreetName
            // 
            this.txbStreetName.Location = new System.Drawing.Point(353, 84);
            this.txbStreetName.Name = "txbStreetName";
            this.txbStreetName.Size = new System.Drawing.Size(207, 28);
            this.txbStreetName.TabIndex = 2;
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(353, 149);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(207, 28);
            this.txbCity.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(246, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(342, 231);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(96, 35);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(461, 231);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 34);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSpawnCity
            // 
            this.btnSpawnCity.Location = new System.Drawing.Point(246, 309);
            this.btnSpawnCity.Name = "btnSpawnCity";
            this.btnSpawnCity.Size = new System.Drawing.Size(303, 34);
            this.btnSpawnCity.TabIndex = 7;
            this.btnSpawnCity.Text = "Spawn City Form";
            this.btnSpawnCity.UseVisualStyleBackColor = true;
            this.btnSpawnCity.Click += new System.EventHandler(this.btnSpawnCity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 541);
            this.Controls.Add(this.btnSpawnCity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.txbStreetName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreetName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txbStreetName;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSpawnCity;
    }
}

