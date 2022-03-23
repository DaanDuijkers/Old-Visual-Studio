
namespace Week12Assignment
{
    partial class MainForm
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbWorkshop = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddWorkshop = new System.Windows.Forms.Button();
            this.btnEditWorkshop = new System.Windows.Forms.Button();
            this.btnRemoveWorkshop = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.dgvWorkshops = new System.Windows.Forms.DataGridView();
            this.tbPerson = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.tbControl.SuspendLayout();
            this.tbWorkshop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkshops)).BeginInit();
            this.tbPerson.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbWorkshop);
            this.tbControl.Controls.Add(this.tbPerson);
            this.tbControl.Location = new System.Drawing.Point(13, 13);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(1409, 516);
            this.tbControl.TabIndex = 0;
            // 
            // tbWorkshop
            // 
            this.tbWorkshop.BackColor = System.Drawing.SystemColors.Control;
            this.tbWorkshop.Controls.Add(this.flowLayoutPanel1);
            this.tbWorkshop.Controls.Add(this.dgvWorkshops);
            this.tbWorkshop.Location = new System.Drawing.Point(4, 27);
            this.tbWorkshop.Name = "tbWorkshop";
            this.tbWorkshop.Padding = new System.Windows.Forms.Padding(3);
            this.tbWorkshop.Size = new System.Drawing.Size(1401, 485);
            this.tbWorkshop.TabIndex = 0;
            this.tbWorkshop.Text = "Workshop";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.Controls.Add(this.btnAddWorkshop);
            this.flowLayoutPanel1.Controls.Add(this.btnEditWorkshop);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveWorkshop);
            this.flowLayoutPanel1.Controls.Add(this.btnReserve);
            this.flowLayoutPanel1.Controls.Add(this.btnStart);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1095, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnAddWorkshop
            // 
            this.btnAddWorkshop.Location = new System.Drawing.Point(3, 2);
            this.btnAddWorkshop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWorkshop.Name = "btnAddWorkshop";
            this.btnAddWorkshop.Size = new System.Drawing.Size(94, 46);
            this.btnAddWorkshop.TabIndex = 1;
            this.btnAddWorkshop.Text = "Add";
            this.btnAddWorkshop.UseVisualStyleBackColor = true;
            this.btnAddWorkshop.Click += new System.EventHandler(this.btnAddWorkshop_Click);
            // 
            // btnEditWorkshop
            // 
            this.btnEditWorkshop.Location = new System.Drawing.Point(103, 2);
            this.btnEditWorkshop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditWorkshop.Name = "btnEditWorkshop";
            this.btnEditWorkshop.Size = new System.Drawing.Size(94, 46);
            this.btnEditWorkshop.TabIndex = 2;
            this.btnEditWorkshop.Text = "Edit";
            this.btnEditWorkshop.UseVisualStyleBackColor = true;
            this.btnEditWorkshop.Click += new System.EventHandler(this.btnEditWorkshop_Click);
            // 
            // btnRemoveWorkshop
            // 
            this.btnRemoveWorkshop.Location = new System.Drawing.Point(203, 2);
            this.btnRemoveWorkshop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveWorkshop.Name = "btnRemoveWorkshop";
            this.btnRemoveWorkshop.Size = new System.Drawing.Size(94, 46);
            this.btnRemoveWorkshop.TabIndex = 3;
            this.btnRemoveWorkshop.Text = "Remove";
            this.btnRemoveWorkshop.UseVisualStyleBackColor = true;
            this.btnRemoveWorkshop.Click += new System.EventHandler(this.btnRemoveWorkshop_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(3, 52);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(94, 46);
            this.btnReserve.TabIndex = 4;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // dgvWorkshops
            // 
            this.dgvWorkshops.AllowUserToAddRows = false;
            this.dgvWorkshops.AllowUserToDeleteRows = false;
            this.dgvWorkshops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkshops.Location = new System.Drawing.Point(7, 7);
            this.dgvWorkshops.Name = "dgvWorkshops";
            this.dgvWorkshops.ReadOnly = true;
            this.dgvWorkshops.RowHeadersWidth = 51;
            this.dgvWorkshops.RowTemplate.Height = 24;
            this.dgvWorkshops.Size = new System.Drawing.Size(1082, 472);
            this.dgvWorkshops.TabIndex = 0;
            // 
            // tbPerson
            // 
            this.tbPerson.BackColor = System.Drawing.SystemColors.Control;
            this.tbPerson.Controls.Add(this.flowLayoutPanel2);
            this.tbPerson.Controls.Add(this.dgvPersons);
            this.tbPerson.Location = new System.Drawing.Point(4, 27);
            this.tbPerson.Name = "tbPerson";
            this.tbPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tbPerson.Size = new System.Drawing.Size(1401, 485);
            this.tbPerson.TabIndex = 1;
            this.tbPerson.Text = "Person";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel2.Controls.Add(this.btnAddPerson);
            this.flowLayoutPanel2.Controls.Add(this.btnEditPerson);
            this.flowLayoutPanel2.Controls.Add(this.btnRemovePerson);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1094, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(301, 50);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(3, 2);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(94, 46);
            this.btnAddPerson.TabIndex = 1;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(103, 2);
            this.btnEditPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(94, 46);
            this.btnEditPerson.TabIndex = 2;
            this.btnEditPerson.Text = "Edit";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.Location = new System.Drawing.Point(203, 2);
            this.btnRemovePerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(94, 46);
            this.btnRemovePerson.TabIndex = 3;
            this.btnRemovePerson.Text = "Remove";
            this.btnRemovePerson.UseVisualStyleBackColor = true;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(6, 6);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowHeadersWidth = 51;
            this.dgvPersons.RowTemplate.Height = 24;
            this.dgvPersons.Size = new System.Drawing.Size(1082, 473);
            this.dgvPersons.TabIndex = 1;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Week12Assignment.Person);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(103, 52);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 46);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 541);
            this.Controls.Add(this.tbControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Main";
            this.tbControl.ResumeLayout(false);
            this.tbWorkshop.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkshops)).EndInit();
            this.tbPerson.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbWorkshop;
        private System.Windows.Forms.DataGridView dgvWorkshops;
        private System.Windows.Forms.TabPage tbPerson;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddWorkshop;
        private System.Windows.Forms.Button btnEditWorkshop;
        private System.Windows.Forms.Button btnRemoveWorkshop;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button btnStart;
    }
}

