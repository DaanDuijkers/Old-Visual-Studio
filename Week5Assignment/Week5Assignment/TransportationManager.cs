using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5Assignment
{
    public class TransportationManager
    {
        private List<Ride> rides;
        private List<Vehicle> vehicles;

        public TransportationManager ()
        {
            rides = new List<Ride>();
            vehicles = new List<Vehicle>();
        }

        public void VehiclesToBinaryFile()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("vehicles", FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();

                bf.Serialize(fs, vehicles);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        public void VehiclesFromBinaryFile()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("vehicles", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();

                vehicles = ((List<Vehicle>)bf.Deserialize(fs));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        public void RidesToBinaryFile()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("rides", FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();

                bf.Serialize(fs, rides);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        public void RidesFromBinaryFile()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("rides", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();

                rides = ((List<Ride>)bf.Deserialize(fs));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        public List<Vehicle> GetAllVehicles ()
        {
            return vehicles;
        }

        public List<Ride> GetAllRides ()
        {
            return rides;
        }

        public Vehicle GetVehicle (int index)
        {
            return vehicles[index];
        }

        private void Sort ()
        {

        }

        private bool AlreadyExists(string licensePlate)
        {
            bool exists = false;

            foreach (Vehicle v in vehicles)
            {
                if (v.LicensePlate == licensePlate)
                {
                    exists = true;
                }
            }

            return exists;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            if (AlreadyExists(vehicle.LicensePlate) == false)
            {
                vehicles.Add(vehicle);
            }
        }

        public void EditVehicle (string oldLicensePlate, string newLicensePlate, int gasUsagePerKM, double pricePerKM, VehicleType vehicleType, int maxPassengers)
        {
            if (AlreadyExists(newLicensePlate) == false)
            {
                foreach (Car c in vehicles)
                {
                    if (c.LicensePlate == oldLicensePlate)
                    {
                        c.Edit(newLicensePlate, gasUsagePerKM, pricePerKM, vehicleType, maxPassengers);
                    }
                }
            }
        }

        public void EditVehicle (string oldLicensePlate, string newLicensePlate, int gasUsagePerKM, double pricePerKM, VehicleType vehicleType, int maxWeight, int maxVolume)
        {
            if (AlreadyExists(newLicensePlate) == false)
            {
                foreach (Truck t in vehicles)
                {
                    if (t.LicensePlate == oldLicensePlate)
                    {
                        t.Edit(newLicensePlate, gasUsagePerKM, pricePerKM, vehicleType, maxWeight, maxVolume);
                    }
                }
            }
        }

        public void EditVehicle(string oldLicensePlate, string newLicensePlate, int gasUsagePerKM, double pricePerKM, VehicleType vehicleType, int maxPassengers, int maxWeight, int maxVolume)
        { 
                if (AlreadyExists(newLicensePlate) == false)
                {
                    foreach (Van v in vehicles)
                    {
                        if (v.LicensePlate == oldLicensePlate)
                        {
                            v.Edit(newLicensePlate, gasUsagePerKM, pricePerKM, vehicleType, maxPassengers, maxWeight, maxVolume);
                        }
                    }
                }
        }

        public Vehicle GetAvailableVehicle (int passengers)
        {
            foreach (Vehicle v in vehicles)
            {
                if (v is Car && passengers <= ((Car)v).MaxPassengers || v is Van && passengers <= ((Van)v).MaxPassengers)
                {
                    return v;
                }
            }

            return null;
        }

        public Vehicle GetAvailableVehicle (int weight, int volume)
        {
            foreach (Vehicle v in vehicles)
            {
                if (v is Truck && ((Truck)v).Available == true && weight <= ((Truck)v).MaxWeight && volume <= ((Truck)v).MaxVolume || v is Van && ((Van)v).Available == true && weight <= ((Van)v).MaxWeight && volume <= ((Van)v).MaxVolume)
                {
                    return v;
                }
            }

            return null;
        }

        public void AddRide (Ride ride)
        {
            rides.Add(ride);
        }

        public void FinishRide (int index, int riddenKM)
        {
            rides[index].EndRide(riddenKM);
        }
    }
}
