using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class PlayroomManager
    {
        private List<Playroom> playrooms;

        public PlayroomManager()
        {
            this.playrooms = new List<Playroom>();
        }

        public List<Playroom> GetAll ()
        {
            return playrooms;
        }

        public Playroom Get (Playroom playroom)
        {
            foreach (Playroom p in playrooms)
            {
                if (p == playroom)
                {
                    return p;
                }
            }

            return null;
        }

        public bool Add (Playroom playroom)
        {
            this.playrooms.Add(playroom);
            return true;
        }

        public bool MakeReservation (Playroom playroom, Reservation reservation)
        {
            foreach (Playroom p in playrooms)
            {
                if (p == playroom)
                {
                    if (reservation is Reservation)
                    {
                        p.Reservations.Add(reservation);
                    }
                    else if (reservation is ReservationLimit)
                    {
                        p.Reservations.Add((ReservationLimit)reservation);
                    }
                }
            }

            return true;
        }

        public bool AddProduct (Playroom playroom, Product product, int quantity)
        {
            if (quantity != 0)
            {
                foreach (Playroom p in playrooms)
                {
                    if (p == playroom)
                    {
                        if (p.Products.Count != 0)
                        {
                            foreach (PlayroomProduct pp in p.Products)
                            {
                                if (pp.Products[0].ProductInfo.Name == product.Name)
                                {
                                    for (int i = 1; i <= quantity; i++)
                                    {
                                        if (product is SpecialGadget)
                                        {
                                            pp.Products.Add(new SpecialGadgetAvailability(product));
                                        }
                                        else if (product is Drink)
                                        {
                                            pp.Products.Add(new DrinkAvailability(product));
                                        }
                                        else
                                        {
                                            pp.Products.Add(new ProductAvailability(product));
                                        }
                                    }

                                    return true;
                                }
                            }
                        }
                        
                        if (product is SpecialGadget)
                        {
                            p.Products.Add(new PlayroomProduct(new SpecialGadgetAvailability(product), quantity));
                        }
                        else if (product is Drink)
                        {
                            p.Products.Add(new PlayroomProduct(new DrinkAvailability(product), quantity));
                        }
                        else
                        {
                            p.Products.Add(new PlayroomProduct(new ProductAvailability(product), quantity));
                        }
                    }
                }
            }

            return false;
        }
    }
}