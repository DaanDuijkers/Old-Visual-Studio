using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week14Assignment
{
    class ProjectGroup
    {
        private string name;
        List<Member> members = new List<Member> ();

        public ProjectGroup (string name)
        {
            this.name = name;
        }

        public void AddMember (string name, int studentNumber)
        {
            Member member = new Member (name, studentNumber);
            members.Add(member);
        }

        public string GetInfo () 
        {
            if (members.Any())
            {
                string allMembers = name + "\r\n";
                foreach (Member m in members)
                {
                    allMembers += " - " + m.GetInfo();
                }
                return allMembers;
            }
            else
            {
                string noMembers = name + "- No members";
                return noMembers;
            }
        }
    }
}
