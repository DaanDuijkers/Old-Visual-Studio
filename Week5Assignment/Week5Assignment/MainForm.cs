using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5Assignment
{
    public partial class MainForm : Form
    {
        private TransportationManager transportationManager;

        public MainForm()
        {
            InitializeComponent();

            transportationManager = new TransportationManager();
            transportationManager.VehiclesFromBinaryFile();
            transportationManager.RidesFromBinaryFile();
            FillComboboxes();
            GetAllVehicles(true);
            GetAllRides(false);
        }

        private void FillComboboxes ()
        {
            cmbVehicleType.DataSource = Enum.GetValues(typeof(VehicleType));
            cmbRideType.DataSource = Enum.GetValues(typeof(RideType));
            
            cmbVehicleType.SelectedIndex = 0;
            cmbRideType.SelectedIndex = 0;
        }

        private void ResetAllInputBoxes ()
        {
            cmbVehicleType.SelectedIndex = 0;
            txbLicensePlate.Text = string.Empty;
            txbGasUsage.Text = string.Empty;
            txbPricePerKM.Text = string.Empty;
            txbMaxPassengers.Text = string.Empty;
            txbMaxWeight.Text = string.Empty;
            txbMaxVolume.Text = string.Empty;
        }

        private void GetAllVehicles(bool available)
        {
            dgvVehicles.Rows.Clear();

            try
            {
                foreach (Vehicle v in transportationManager.GetAllVehicles())
                {
                    if (v.Available == available)
                    {
                        int rowId = dgvVehicles.Rows.Add();
                        DataGridViewRow row = dgvVehicles.Rows[rowId];

                        row.Cells["type"].Value = v.VehicleType;
                        row.Cells["licensePlate"].Value = v.LicensePlate;
                        row.Cells["gasUsage"].Value = v.GasUsagePerKM;
                        row.Cells["priceKM"].Value = v.PricePerKM.ToString("0.00");
                        row.Cells["riddenKM"].Value = v.TotalRiddenKM;
                        row.Cells["fuelConsumed"].Value = v.ConsumedFuel;

                        if (v is Car)
                        {
                            row.Cells["maxPassengers"].Value = ((Car)v).MaxPassengers;
                        }
                        else if (v is Van)
                        {
                            row.Cells["maxPassengers"].Value = ((Van)v).MaxPassengers;
                        }
                        else
                        {
                            row.Cells["maxPassengers"].Value = "✕";
                        }

                        if (v is Truck)
                        {
                            row.Cells["maxWeight"].Value = ((Truck)v).MaxWeight;
                            row.Cells["maxVolume"].Value = ((Truck)v).MaxVolume;
                        }
                        else if (v is Van)
                        {
                            row.Cells["maxWeight"].Value = ((Van)v).MaxWeight;
                            row.Cells["maxVolume"].Value = ((Van)v).MaxVolume;
                        }
                        else
                        {
                            row.Cells["maxWeight"].Value = "✕";
                            row.Cells["maxVolume"].Value = "✕";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllRides (bool completed)
        {
            dgvRides.Rows.Clear();

            try
            {
                foreach (Ride r in transportationManager.GetAllRides())
                {
                    if (completed == r.Completed)
                    {
                        int rowId = dgvRides.Rows.Add();
                        DataGridViewRow row = dgvRides.Rows[rowId];

                        row.Cells["id"].Value = r.ID;
                        row.Cells["rideType"].Value = r.RideType;
                        row.Cells["vehicleType"].Value = r.Vehicle.VehicleType;
                        row.Cells["vehicleLicensePlate"].Value = r.Vehicle.LicensePlate;
                        row.Cells["startTime"].Value = r.StartTime;
                        row.Cells["endTime"].Value = r.EndTime;

                        if (r is PassengerRide)
                        {
                            row.Cells["ridePassengers"].Value = ((PassengerRide)r).Passengers;
                        }
                        else
                        {
                            row.Cells["ridePassengers"].Value = "✕";
                        }

                        if (r is CargoRide)
                        {
                            row.Cells["rideWeight"].Value = ((CargoRide)r).CargoWeight;
                            row.Cells["rideVolume"].Value = ((CargoRide)r).CargoVolume;
                        }
                        else
                        {
                            row.Cells["rideWeight"].Value = "✕";
                            row.Cells["rideVolume"].Value = "✕";
                        }

                        if (r.Completed == true)
                        {
                            row.Cells["rideRiddenKM"].Value = r.RiddenKM;
                            row.Cells["totalPrice"].Value = r.TotalPrice.ToString("0.00");
                        }
                        else
                        {
                            row.Cells["rideRiddenKM"].Value = "✕";
                            row.Cells["totalPrice"].Value = "✕";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAvailableVehicles_Click(object sender, EventArgs e)
        {
            GetAllVehicles(true);
        }

        private void btnUnavailableVehicles_Click(object sender, EventArgs e)
        {
            GetAllVehicles(false);
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if ((VehicleType)cmbVehicleType.SelectedItem == VehicleType.Car)
                {
                    if (txbLicensePlate.Text != string.Empty && txbGasUsage.Text != string.Empty && txbPricePerKM.Text != string.Empty && txbMaxPassengers.Text != string.Empty)
                    {
                        transportationManager.AddVehicle(new Car(txbLicensePlate.Text, Convert.ToInt32(txbGasUsage.Text), Convert.ToDouble(txbPricePerKM.Text), VehicleType.Car, Convert.ToInt32(txbMaxPassengers.Text)));
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the License Plate, Gas Usage per Hour, Price per Hour, and Max Passengers");
                    }
                }
                else if ((VehicleType)cmbVehicleType.SelectedItem == VehicleType.Truck)
                {
                    if (txbLicensePlate.Text != string.Empty && txbGasUsage.Text != string.Empty && txbPricePerKM.Text != string.Empty && txbMaxWeight.Text != string.Empty && txbMaxVolume.Text != string.Empty)
                    {
                        transportationManager.AddVehicle(new Truck(txbLicensePlate.Text, Convert.ToInt32(txbGasUsage.Text), Convert.ToDouble(txbPricePerKM.Text), VehicleType.Truck, Convert.ToInt32(txbMaxWeight.Text), Convert.ToInt32(txbMaxVolume.Text)));
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the License Plate, Gas Usage per Hour, Price per Hour, Max Carry Weight, and Max Volume");
                    }
                }
                else if ((VehicleType)cmbVehicleType.SelectedItem == VehicleType.Van)
                {
                    if (txbLicensePlate.Text != string.Empty && txbGasUsage.Text != string.Empty && txbPricePerKM.Text != string.Empty && txbMaxPassengers.Text != string.Empty && txbMaxWeight.Text != string.Empty && txbMaxVolume.Text != string.Empty)
                    {
                        transportationManager.AddVehicle(new Van(txbLicensePlate.Text, Convert.ToInt32(txbGasUsage.Text), Convert.ToDouble(txbPricePerKM.Text), VehicleType.Van, Convert.ToInt32(txbMaxPassengers.Text), Convert.ToInt32(txbMaxWeight.Text), Convert.ToInt32(txbMaxVolume.Text)));
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the License Plate, Gas Usage per Hour, Price per Hour, Max Passengers, Max Carry Weight, and Max Volume");
                    }
                }

                transportationManager.VehiclesToBinaryFile();
                transportationManager.VehiclesFromBinaryFile();
                GetAllVehicles(true);
                ResetAllInputBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOngoingRides_Click(object sender, EventArgs e)
        {
            GetAllRides(false);
        }

        private void btnCompletedRides_Click(object sender, EventArgs e)
        {
            GetAllRides(true);
        }

        private void btnAddRide_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle availableVehicle = null;

                if ((RideType)cmbRideType.SelectedItem == RideType.Passenger)
                {
                    availableVehicle = transportationManager.GetAvailableVehicle(Convert.ToInt32(txbRidePassengers.Text));

                    if (availableVehicle != null)
                    {
                        transportationManager.AddRide(new PassengerRide(availableVehicle, Convert.ToDateTime(dtpStartTime.Text), Convert.ToDateTime(dtpEndTime.Text), Convert.ToInt32(txbRidePassengers.Text)));
                    }
                }
                else if ((RideType)cmbRideType.SelectedItem == RideType.Cargo)
                {
                    availableVehicle = transportationManager.GetAvailableVehicle(Convert.ToInt32(txbRideCargoWeight), Convert.ToInt32(txbRideCargoVolume.Text));

                    if (availableVehicle != null)
                    {
                        transportationManager.AddRide(new CargoRide(availableVehicle, Convert.ToDateTime(dtpStartTime.Text), Convert.ToDateTime(dtpEndTime.Text), Convert.ToInt32(txbRideCargoWeight), Convert.ToInt32(txbRideCargoVolume.Text)));
                    }
                }

                if (availableVehicle != null)
                {
                    transportationManager.RidesToBinaryFile();
                    transportationManager.RidesFromBinaryFile();
                    GetAllRides(false);
                    GetAllVehicles(false);
                }
                else
                {
                    MessageBox.Show("There are no available vehicles with these specifications");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinishRide_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRides.CurrentRow.Index != -1)
                {
                    if (txbTotalRiddenKMs.Text != string.Empty)
                    {
                        int index = Convert.ToInt32(dgvRides.CurrentRow.Index);

                        transportationManager.FinishRide(index, Convert.ToInt32(txbTotalRiddenKMs.Text));

                        transportationManager.RidesToBinaryFile();
                        transportationManager.RidesFromBinaryFile();
                        GetAllRides(true);
                        GetAllVehicles(true);
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the Total Ridden KMs");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a ride");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVehicles.CurrentRow.Index != -1)
                {
                    Vehicle selectedVehicle = transportationManager.GetVehicle(dgvVehicles.CurrentRow.Index);

                    if ((VehicleType)cmbVehicleType.SelectedItem == VehicleType.Car)
                    {
                        if (txbLicensePlate.Text != string.Empty && txbGasUsage.Text != string.Empty && txbPricePerKM.Text != string.Empty && txbMaxPassengers.Text != string.Empty)
                        {
                            transportationManager.EditVehicle(selectedVehicle.LicensePlate, txbLicensePlate.Text, Convert.ToInt32(txbGasUsage.Text), Convert.ToDouble(txbPricePerKM.Text), VehicleType.Car, Convert.ToInt32(txbMaxPassengers.Text));
                        }
                        else
                        {
                            MessageBox.Show("Please fill in the License Plate, Gas Usage per Hour, Price per Hour, and Max Passengers");
                        }
                    }
                    else if ((VehicleType)cmbVehicleType.SelectedItem == VehicleType.Truck)
                    {
                        if (txbLicensePlate.Text != string.Empty && txbGasUsage.Text != string.Empty && txbPricePerKM.Text != string.Empty && txbMaxWeight.Text != string.Empty && txbMaxVolume.Text != string.Empty)
                        {
                            transportationManager.EditVehicle(selectedVehicle.LicensePlate, txbLicensePlate.Text, Convert.ToInt32(txbGasUsage.Text), Convert.ToDouble(txbPricePerKM.Text), VehicleType.Truck, Convert.ToInt32(txbMaxWeight.Text), Convert.ToInt32(txbMaxVolume.Text));
                        }
                        else
                        {
                            MessageBox.Show("Please fill in the License Plate, Gas Usage per Hour, Price per Hour, Max Carry Weight, and Max Volume");
                        }
                    }
                    else if ((VehicleType)cmbVehicleType.SelectedItem == VehicleType.Van)
                    {
                        if (txbLicensePlate.Text != string.Empty && txbGasUsage.Text != string.Empty && txbPricePerKM.Text != string.Empty && txbMaxPassengers.Text != string.Empty && txbMaxWeight.Text != string.Empty && txbMaxVolume.Text != string.Empty)
                        {
                            transportationManager.EditVehicle(selectedVehicle.LicensePlate, txbLicensePlate.Text, Convert.ToInt32(txbGasUsage.Text), Convert.ToDouble(txbPricePerKM.Text), VehicleType.Van, Convert.ToInt32(txbMaxPassengers.Text), Convert.ToInt32(txbMaxWeight.Text), Convert.ToInt32(txbMaxVolume.Text));
                        }
                        else
                        {
                            MessageBox.Show("Please fill in the License Plate, Gas Usage per Hour, Price per Hour, Max Passengers, Max Carry Weight, and Max Volume");
                        }
                    }

                    transportationManager.VehiclesToBinaryFile();
                    transportationManager.VehiclesFromBinaryFile();
                    GetAllVehicles(true);
                }
                else
                {
                    MessageBox.Show("Please select a vehicle");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
