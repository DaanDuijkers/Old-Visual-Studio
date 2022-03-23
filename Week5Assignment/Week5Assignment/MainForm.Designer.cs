
namespace Week5Assignment
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
            this.btnAvailableVehicles = new System.Windows.Forms.Button();
            this.btnUnavailableVehicles = new System.Windows.Forms.Button();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riddenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelConsumed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPassengers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCompletedRides = new System.Windows.Forms.Button();
            this.btnOngoingRides = new System.Windows.Forms.Button();
            this.dgvRides = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rideType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleLicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ridePassengers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rideWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rideVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rideRiddenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVehicles = new System.Windows.Forms.Label();
            this.lblRides = new System.Windows.Forms.Label();
            this.grbVehicles = new System.Windows.Forms.GroupBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.txbMaxVolume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbMaxWeight = new System.Windows.Forms.TextBox();
            this.txbMaxPassengers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPricePerKM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbGasUsage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLicensePlate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.grbRides = new System.Windows.Forms.GroupBox();
            this.txbTotalRiddenKMs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFinishRide = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddRide = new System.Windows.Forms.Button();
            this.txbRideCargoVolume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbRideCargoWeight = new System.Windows.Forms.TextBox();
            this.txbRidePassengers = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbRideType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRides)).BeginInit();
            this.grbVehicles.SuspendLayout();
            this.grbRides.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAvailableVehicles
            // 
            this.btnAvailableVehicles.Location = new System.Drawing.Point(799, 12);
            this.btnAvailableVehicles.Name = "btnAvailableVehicles";
            this.btnAvailableVehicles.Size = new System.Drawing.Size(85, 29);
            this.btnAvailableVehicles.TabIndex = 4;
            this.btnAvailableVehicles.Text = "Available";
            this.btnAvailableVehicles.UseVisualStyleBackColor = true;
            this.btnAvailableVehicles.Click += new System.EventHandler(this.btnAvailableVehicles_Click);
            // 
            // btnUnavailableVehicles
            // 
            this.btnUnavailableVehicles.Location = new System.Drawing.Point(890, 12);
            this.btnUnavailableVehicles.Name = "btnUnavailableVehicles";
            this.btnUnavailableVehicles.Size = new System.Drawing.Size(105, 29);
            this.btnUnavailableVehicles.TabIndex = 3;
            this.btnUnavailableVehicles.Text = "Unavailable";
            this.btnUnavailableVehicles.UseVisualStyleBackColor = true;
            this.btnUnavailableVehicles.Click += new System.EventHandler(this.btnUnavailableVehicles_Click);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.licensePlate,
            this.gasUsage,
            this.priceKM,
            this.riddenKM,
            this.fuelConsumed,
            this.maxPassengers,
            this.maxWeight,
            this.maxVolume});
            this.dgvVehicles.Location = new System.Drawing.Point(13, 47);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.RowHeadersWidth = 51;
            this.dgvVehicles.RowTemplate.Height = 24;
            this.dgvVehicles.Size = new System.Drawing.Size(983, 320);
            this.dgvVehicles.TabIndex = 1;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 55;
            // 
            // licensePlate
            // 
            this.licensePlate.FillWeight = 50F;
            this.licensePlate.HeaderText = "License Plate";
            this.licensePlate.MinimumWidth = 6;
            this.licensePlate.Name = "licensePlate";
            this.licensePlate.ReadOnly = true;
            this.licensePlate.Width = 145;
            // 
            // gasUsage
            // 
            this.gasUsage.HeaderText = "Gas Usage";
            this.gasUsage.MinimumWidth = 6;
            this.gasUsage.Name = "gasUsage";
            this.gasUsage.ReadOnly = true;
            this.gasUsage.Width = 120;
            // 
            // priceKM
            // 
            this.priceKM.HeaderText = "Price/KM";
            this.priceKM.MinimumWidth = 6;
            this.priceKM.Name = "priceKM";
            this.priceKM.ReadOnly = true;
            this.priceKM.Width = 85;
            // 
            // riddenKM
            // 
            this.riddenKM.HeaderText = "Ridden KM";
            this.riddenKM.MinimumWidth = 6;
            this.riddenKM.Name = "riddenKM";
            this.riddenKM.ReadOnly = true;
            this.riddenKM.Width = 120;
            // 
            // fuelConsumed
            // 
            this.fuelConsumed.HeaderText = "Fuel Consumed";
            this.fuelConsumed.MinimumWidth = 6;
            this.fuelConsumed.Name = "fuelConsumed";
            this.fuelConsumed.ReadOnly = true;
            this.fuelConsumed.Width = 155;
            // 
            // maxPassengers
            // 
            this.maxPassengers.HeaderText = "Passengers";
            this.maxPassengers.MinimumWidth = 6;
            this.maxPassengers.Name = "maxPassengers";
            this.maxPassengers.ReadOnly = true;
            this.maxPassengers.Width = 105;
            // 
            // maxWeight
            // 
            this.maxWeight.HeaderText = "Weight";
            this.maxWeight.MinimumWidth = 6;
            this.maxWeight.Name = "maxWeight";
            this.maxWeight.ReadOnly = true;
            this.maxWeight.Width = 70;
            // 
            // maxVolume
            // 
            this.maxVolume.HeaderText = "Volume";
            this.maxVolume.MinimumWidth = 6;
            this.maxVolume.Name = "maxVolume";
            this.maxVolume.ReadOnly = true;
            this.maxVolume.Width = 75;
            // 
            // btnCompletedRides
            // 
            this.btnCompletedRides.Location = new System.Drawing.Point(897, 388);
            this.btnCompletedRides.Name = "btnCompletedRides";
            this.btnCompletedRides.Size = new System.Drawing.Size(99, 29);
            this.btnCompletedRides.TabIndex = 2;
            this.btnCompletedRides.Text = "Completed";
            this.btnCompletedRides.UseVisualStyleBackColor = true;
            this.btnCompletedRides.Click += new System.EventHandler(this.btnCompletedRides_Click);
            // 
            // btnOngoingRides
            // 
            this.btnOngoingRides.Location = new System.Drawing.Point(811, 388);
            this.btnOngoingRides.Name = "btnOngoingRides";
            this.btnOngoingRides.Size = new System.Drawing.Size(80, 29);
            this.btnOngoingRides.TabIndex = 1;
            this.btnOngoingRides.Text = "Ongoing";
            this.btnOngoingRides.UseVisualStyleBackColor = true;
            this.btnOngoingRides.Click += new System.EventHandler(this.btnOngoingRides_Click);
            // 
            // dgvRides
            // 
            this.dgvRides.AllowUserToAddRows = false;
            this.dgvRides.AllowUserToDeleteRows = false;
            this.dgvRides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRides.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.rideType,
            this.vehicleType,
            this.vehicleLicensePlate,
            this.startTime,
            this.endTime,
            this.ridePassengers,
            this.rideWeight,
            this.rideVolume,
            this.rideRiddenKM,
            this.totalPrice});
            this.dgvRides.Location = new System.Drawing.Point(12, 423);
            this.dgvRides.Name = "dgvRides";
            this.dgvRides.ReadOnly = true;
            this.dgvRides.RowHeadersWidth = 51;
            this.dgvRides.RowTemplate.Height = 24;
            this.dgvRides.Size = new System.Drawing.Size(983, 320);
            this.dgvRides.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 33;
            // 
            // rideType
            // 
            this.rideType.HeaderText = "Type";
            this.rideType.MinimumWidth = 6;
            this.rideType.Name = "rideType";
            this.rideType.ReadOnly = true;
            this.rideType.Width = 55;
            // 
            // vehicleType
            // 
            this.vehicleType.HeaderText = "Vehicle Type";
            this.vehicleType.MinimumWidth = 6;
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.ReadOnly = true;
            this.vehicleType.Width = 135;
            // 
            // vehicleLicensePlate
            // 
            this.vehicleLicensePlate.HeaderText = "License Plate";
            this.vehicleLicensePlate.MinimumWidth = 6;
            this.vehicleLicensePlate.Name = "vehicleLicensePlate";
            this.vehicleLicensePlate.ReadOnly = true;
            this.vehicleLicensePlate.Width = 140;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "Start Time";
            this.startTime.MinimumWidth = 6;
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Width = 115;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "End Time";
            this.endTime.MinimumWidth = 6;
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            this.endTime.Width = 110;
            // 
            // ridePassengers
            // 
            this.ridePassengers.HeaderText = "Passengers";
            this.ridePassengers.MinimumWidth = 6;
            this.ridePassengers.Name = "ridePassengers";
            this.ridePassengers.ReadOnly = true;
            this.ridePassengers.Width = 105;
            // 
            // rideWeight
            // 
            this.rideWeight.HeaderText = "Weight";
            this.rideWeight.MinimumWidth = 6;
            this.rideWeight.Name = "rideWeight";
            this.rideWeight.ReadOnly = true;
            this.rideWeight.Width = 70;
            // 
            // rideVolume
            // 
            this.rideVolume.HeaderText = "Volume";
            this.rideVolume.MinimumWidth = 6;
            this.rideVolume.Name = "rideVolume";
            this.rideVolume.ReadOnly = true;
            this.rideVolume.Width = 75;
            // 
            // rideRiddenKM
            // 
            this.rideRiddenKM.HeaderText = "Ridden KM";
            this.rideRiddenKM.MinimumWidth = 6;
            this.rideRiddenKM.Name = "rideRiddenKM";
            this.rideRiddenKM.ReadOnly = true;
            this.rideRiddenKM.Width = 120;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 120;
            // 
            // lblVehicles
            // 
            this.lblVehicles.AutoSize = true;
            this.lblVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicles.Location = new System.Drawing.Point(12, 16);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(87, 25);
            this.lblVehicles.TabIndex = 5;
            this.lblVehicles.Text = "Vehicles";
            // 
            // lblRides
            // 
            this.lblRides.AutoSize = true;
            this.lblRides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRides.Location = new System.Drawing.Point(8, 395);
            this.lblRides.Name = "lblRides";
            this.lblRides.Size = new System.Drawing.Size(61, 25);
            this.lblRides.TabIndex = 6;
            this.lblRides.Text = "Rides";
            // 
            // grbVehicles
            // 
            this.grbVehicles.Controls.Add(this.btnAddVehicle);
            this.grbVehicles.Controls.Add(this.btnEditVehicle);
            this.grbVehicles.Controls.Add(this.txbMaxVolume);
            this.grbVehicles.Controls.Add(this.label7);
            this.grbVehicles.Controls.Add(this.txbMaxWeight);
            this.grbVehicles.Controls.Add(this.txbMaxPassengers);
            this.grbVehicles.Controls.Add(this.label6);
            this.grbVehicles.Controls.Add(this.label5);
            this.grbVehicles.Controls.Add(this.txbPricePerKM);
            this.grbVehicles.Controls.Add(this.label4);
            this.grbVehicles.Controls.Add(this.txbGasUsage);
            this.grbVehicles.Controls.Add(this.label3);
            this.grbVehicles.Controls.Add(this.label2);
            this.grbVehicles.Controls.Add(this.txbLicensePlate);
            this.grbVehicles.Controls.Add(this.label1);
            this.grbVehicles.Controls.Add(this.cmbVehicleType);
            this.grbVehicles.Location = new System.Drawing.Point(1002, 16);
            this.grbVehicles.Name = "grbVehicles";
            this.grbVehicles.Size = new System.Drawing.Size(419, 247);
            this.grbVehicles.TabIndex = 7;
            this.grbVehicles.TabStop = false;
            this.grbVehicles.Text = "Vehicles";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(256, 208);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(75, 30);
            this.btnAddVehicle.TabIndex = 15;
            this.btnAddVehicle.Text = "Add";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.Location = new System.Drawing.Point(337, 208);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Size = new System.Drawing.Size(75, 30);
            this.btnEditVehicle.TabIndex = 14;
            this.btnEditVehicle.Text = "Edit";
            this.btnEditVehicle.UseVisualStyleBackColor = true;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click);
            // 
            // txbMaxVolume
            // 
            this.txbMaxVolume.Location = new System.Drawing.Point(283, 173);
            this.txbMaxVolume.Multiline = true;
            this.txbMaxVolume.Name = "txbMaxVolume";
            this.txbMaxVolume.Size = new System.Drawing.Size(130, 28);
            this.txbMaxVolume.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Max Volume";
            // 
            // txbMaxWeight
            // 
            this.txbMaxWeight.Location = new System.Drawing.Point(144, 173);
            this.txbMaxWeight.Multiline = true;
            this.txbMaxWeight.Name = "txbMaxWeight";
            this.txbMaxWeight.Size = new System.Drawing.Size(130, 28);
            this.txbMaxWeight.TabIndex = 11;
            // 
            // txbMaxPassengers
            // 
            this.txbMaxPassengers.Location = new System.Drawing.Point(6, 173);
            this.txbMaxPassengers.Multiline = true;
            this.txbMaxPassengers.Name = "txbMaxPassengers";
            this.txbMaxPassengers.Size = new System.Drawing.Size(130, 28);
            this.txbMaxPassengers.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max Passengers";
            // 
            // txbPricePerKM
            // 
            this.txbPricePerKM.Location = new System.Drawing.Point(212, 112);
            this.txbPricePerKM.Multiline = true;
            this.txbPricePerKM.Name = "txbPricePerKM";
            this.txbPricePerKM.Size = new System.Drawing.Size(200, 28);
            this.txbPricePerKM.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price per KM";
            // 
            // txbGasUsage
            // 
            this.txbGasUsage.Location = new System.Drawing.Point(6, 112);
            this.txbGasUsage.Multiline = true;
            this.txbGasUsage.Name = "txbGasUsage";
            this.txbGasUsage.Size = new System.Drawing.Size(200, 28);
            this.txbGasUsage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gas Usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "License Plate";
            // 
            // txbLicensePlate
            // 
            this.txbLicensePlate.Location = new System.Drawing.Point(212, 49);
            this.txbLicensePlate.Multiline = true;
            this.txbLicensePlate.Name = "txbLicensePlate";
            this.txbLicensePlate.Size = new System.Drawing.Size(200, 28);
            this.txbLicensePlate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Type";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(6, 49);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(200, 28);
            this.cmbVehicleType.TabIndex = 0;
            // 
            // grbRides
            // 
            this.grbRides.Controls.Add(this.txbTotalRiddenKMs);
            this.grbRides.Controls.Add(this.label13);
            this.grbRides.Controls.Add(this.btnFinishRide);
            this.grbRides.Controls.Add(this.dtpEndTime);
            this.grbRides.Controls.Add(this.dtpStartTime);
            this.grbRides.Controls.Add(this.btnAddRide);
            this.grbRides.Controls.Add(this.txbRideCargoVolume);
            this.grbRides.Controls.Add(this.label8);
            this.grbRides.Controls.Add(this.txbRideCargoWeight);
            this.grbRides.Controls.Add(this.txbRidePassengers);
            this.grbRides.Controls.Add(this.label9);
            this.grbRides.Controls.Add(this.label10);
            this.grbRides.Controls.Add(this.label11);
            this.grbRides.Controls.Add(this.label12);
            this.grbRides.Controls.Add(this.label14);
            this.grbRides.Controls.Add(this.cmbRideType);
            this.grbRides.Location = new System.Drawing.Point(1002, 424);
            this.grbRides.Name = "grbRides";
            this.grbRides.Size = new System.Drawing.Size(419, 319);
            this.grbRides.TabIndex = 8;
            this.grbRides.TabStop = false;
            this.grbRides.Text = "Rides";
            // 
            // txbTotalRiddenKMs
            // 
            this.txbTotalRiddenKMs.Location = new System.Drawing.Point(154, 285);
            this.txbTotalRiddenKMs.Multiline = true;
            this.txbTotalRiddenKMs.Name = "txbTotalRiddenKMs";
            this.txbTotalRiddenKMs.Size = new System.Drawing.Size(139, 28);
            this.txbTotalRiddenKMs.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Total Ridden KMs";
            // 
            // btnFinishRide
            // 
            this.btnFinishRide.Location = new System.Drawing.Point(299, 283);
            this.btnFinishRide.Name = "btnFinishRide";
            this.btnFinishRide.Size = new System.Drawing.Size(114, 30);
            this.btnFinishRide.TabIndex = 18;
            this.btnFinishRide.Text = "Finish Ride";
            this.btnFinishRide.UseVisualStyleBackColor = true;
            this.btnFinishRide.Click += new System.EventHandler(this.btnFinishRide_Click);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(212, 112);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(200, 26);
            this.dtpEndTime.TabIndex = 17;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(6, 110);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 26);
            this.dtpStartTime.TabIndex = 16;
            this.dtpStartTime.Value = new System.DateTime(2021, 3, 20, 3, 27, 6, 0);
            // 
            // btnAddRide
            // 
            this.btnAddRide.Location = new System.Drawing.Point(338, 207);
            this.btnAddRide.Name = "btnAddRide";
            this.btnAddRide.Size = new System.Drawing.Size(75, 30);
            this.btnAddRide.TabIndex = 15;
            this.btnAddRide.Text = "Add";
            this.btnAddRide.UseVisualStyleBackColor = true;
            this.btnAddRide.Click += new System.EventHandler(this.btnAddRide_Click);
            // 
            // txbRideCargoVolume
            // 
            this.txbRideCargoVolume.Location = new System.Drawing.Point(283, 173);
            this.txbRideCargoVolume.Multiline = true;
            this.txbRideCargoVolume.Name = "txbRideCargoVolume";
            this.txbRideCargoVolume.Size = new System.Drawing.Size(130, 28);
            this.txbRideCargoVolume.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cargo Volume";
            // 
            // txbRideCargoWeight
            // 
            this.txbRideCargoWeight.Location = new System.Drawing.Point(144, 173);
            this.txbRideCargoWeight.Multiline = true;
            this.txbRideCargoWeight.Name = "txbRideCargoWeight";
            this.txbRideCargoWeight.Size = new System.Drawing.Size(130, 28);
            this.txbRideCargoWeight.TabIndex = 11;
            // 
            // txbRidePassengers
            // 
            this.txbRidePassengers.Location = new System.Drawing.Point(6, 173);
            this.txbRidePassengers.Multiline = true;
            this.txbRidePassengers.Name = "txbRidePassengers";
            this.txbRidePassengers.Size = new System.Drawing.Size(130, 28);
            this.txbRidePassengers.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cargo Weight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "No. Passengers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "End Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Start Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Ride Type";
            // 
            // cmbRideType
            // 
            this.cmbRideType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRideType.FormattingEnabled = true;
            this.cmbRideType.Location = new System.Drawing.Point(6, 49);
            this.cmbRideType.Name = "cmbRideType";
            this.cmbRideType.Size = new System.Drawing.Size(200, 28);
            this.cmbRideType.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 755);
            this.Controls.Add(this.grbRides);
            this.Controls.Add(this.grbVehicles);
            this.Controls.Add(this.lblRides);
            this.Controls.Add(this.lblVehicles);
            this.Controls.Add(this.btnCompletedRides);
            this.Controls.Add(this.btnOngoingRides);
            this.Controls.Add(this.btnAvailableVehicles);
            this.Controls.Add(this.dgvRides);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.btnUnavailableVehicles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRides)).EndInit();
            this.grbVehicles.ResumeLayout(false);
            this.grbVehicles.PerformLayout();
            this.grbRides.ResumeLayout(false);
            this.grbRides.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCompletedRides;
        private System.Windows.Forms.Button btnOngoingRides;
        private System.Windows.Forms.DataGridView dgvRides;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Button btnAvailableVehicles;
        private System.Windows.Forms.Button btnUnavailableVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn riddenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelConsumed;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPassengers;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxVolume;
        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.Label lblRides;
        private System.Windows.Forms.GroupBox grbVehicles;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLicensePlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbGasUsage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPricePerKM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMaxVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbMaxWeight;
        private System.Windows.Forms.TextBox txbMaxPassengers;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnEditVehicle;
        private System.Windows.Forms.GroupBox grbRides;
        private System.Windows.Forms.Button btnAddRide;
        private System.Windows.Forms.TextBox txbRideCargoVolume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbRideCargoWeight;
        private System.Windows.Forms.TextBox txbRidePassengers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbRideType;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rideType;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleLicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridePassengers;
        private System.Windows.Forms.DataGridViewTextBoxColumn rideWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn rideVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn rideRiddenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.TextBox txbTotalRiddenKMs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFinishRide;
    }
}

