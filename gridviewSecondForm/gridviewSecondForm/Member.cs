using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gridviewSecondForm
{
    public class Member
    {
        private int id;
        private string name;
        private char gender;
        private string skills;

        public int GetID ()
        {
            return id; 
        } 
        
        public void SetID (int id)
        { 
            this.id = id; 
        }

        public string GetName ()
        { 
            return name;
        } 
        
        public void SetName (string name)
        { 
            this.name = name; 
        }

        public char GetGender ()
        { 
            return gender; 
        } 
        
        public void SetGender (char gender) 
        { 
            this.gender = gender; 
        }

        public string GetSkills ()
        { 
            return skills;
        }
        
        public void SetSkills (string skills)
        { 
            this.skills = skills; 
        }
    }
}
