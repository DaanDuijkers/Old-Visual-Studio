using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class FamilyManager
    {
        private List<Family> families;

        public FamilyManager()
        {
            this.families = new List<Family>();
        }

        public Family Get (Family family)
        {
            foreach (Family f in families)
            {
                if (f == family)
                {
                    return f;
                }
            }

            return null;
        }

        public bool Add(Family family)
        {
            families.Add(family);
            return true;
        }

        public bool AddPerson(Family family, Person person)
        {
            foreach (Family f in families)
            {
                if (f == family)
                {
                    int familyMembers = f.Parents.Count + f.Children.Count;
                    if (familyMembers == 4)
                    {
                        return false;
                    }
                    else
                    {
                        if (person is Parent)
                        {
                            f.Parents.Add((Parent)person);
                        }
                        else if (person is Child)
                        {
                            f.Children.Add((Child)person);
                        }
                    }
                }
            }

            return true;
        }

        public bool Approval (Family family, string status)
        {
            foreach (Family f in families)
            {
                if (f == family)
                {
                    f.Status = status;
                }
            }

            return true;
        }
    }
}