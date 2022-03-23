using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assignment
{
    public class WorkshopManager
    {
        private List<Workshop> workshops;

        public WorkshopManager ()
        {
            this.workshops = new List<Workshop>();
        }

        public Workshop Get (Workshop workshop)
        {
            foreach (Workshop w in workshops)
            {
                if (w == workshop)
                {
                    return w;
                }
            }

            return null;
        }

        public List<Workshop> GetAll ()
        {
            return workshops;
        }

        public Response Add (Workshop workshop)
        {
            if (workshop.Seats.Count == 0)
            {
                return Response.NoEmptySlots;
            }
            else if (workshop.Date < DateTime.Now)
            {
                return Response.PastCurrentTime;
            }
            else if (workshop.Teacher.Type != "Teacher")
            {
                return Response.NoTeacher;
            }
            else
            {
                workshops.Add(workshop);
                return Response.Success;
            }
        }

        public Response Edit (Workshop oldWorkshop, Workshop newWorkshop)
        {
            if (newWorkshop.Seats.Count == 0)
            {
                return Response.NoEmptySlots;
            }
            else if (newWorkshop.Date < DateTime.Now)
            {
                return Response.PastCurrentTime;
            }
            else
            {
                foreach (Workshop w in workshops)
                {
                    if (w == oldWorkshop)
                    {
                        w.Name = newWorkshop.Name;
                        w.Description = newWorkshop.Description;
                        w.Date = newWorkshop.Date;
                        w.Teacher = newWorkshop.Teacher;
                        if (w.Seats.Count > newWorkshop.Seats.Count)
                        {
                            int difference = w.Seats.Count - newWorkshop.Seats.Count;
                            int counter = w.Seats.Count - 1;
                            for (int i = 1; i <= difference; i++)
                            {
                                w.Seats.RemoveAt(counter);
                                counter--;
                            }
                        }

                        if (newWorkshop is BuildingWorkshop)
                        {
                            ((BuildingWorkshop)w).Address = ((BuildingWorkshop)newWorkshop).Address;
                            ((BuildingWorkshop)w).Room = ((BuildingWorkshop)newWorkshop).Room;

                            if (w.Seats.Count < newWorkshop.Seats.Count)
                            {
                                int difference = newWorkshop.Seats.Count - w.Seats.Count;
                                for (int i = 1; i <= difference; i++)
                                {
                                    w.Seats.Add(new BuildingSeat());
                                }
                            }
                        }
                        else if (newWorkshop is OnlineWorkshop)
                        {
                            ((OnlineWorkshop)w).URL = ((OnlineWorkshop)newWorkshop).URL;

                            if (w.Seats.Count < newWorkshop.Seats.Count)
                            {
                                int difference = newWorkshop.Seats.Count - w.Seats.Count;
                                for (int i = 1; i <= difference; i++)
                                {
                                    w.Seats.Add(new OnlineSeat());
                                }
                            }
                        }
                    }
                }

                return Response.Success;
            }
        }

        public void Remove (Workshop workshop)
        {
            workshops.Remove(workshop);
        }

        public bool Start (Workshop workshop)
        {
            foreach (Workshop w in workshops)
            {
                if (w.ID == workshop.ID)
                {
                    if (w.Started == false)
                    {
                        w.Start();
                        return true;
                    }
                }
            }

            return false;
        }

        public Response Reserve (Workshop workshop, Person person)
        {
            if (workshop.Started == false)
            {
                foreach (Seat s in workshop.Seats)
                {
                    if (s.Occupant == person)
                    {
                        return Response.AlreadyRegistered;
                    }
                }

                foreach (Seat s in workshop.Seats)
                {
                    if (s.Occupant == null)
                    {
                        s.Reserve(person);
                        return Response.Success;
                    }
                }

                return Response.NoEmptySlots;
            }

            return Response.WorkshopLocked;
        }

        public bool CancelReservation (Workshop workshop, Person person)
        {
            foreach (Seat s in workshop.Seats)
            {
                if (s.Occupant == person)
                {
                    s.CancelReservation();
                    return true;
                }
            }

            return false;
        }
    }
}