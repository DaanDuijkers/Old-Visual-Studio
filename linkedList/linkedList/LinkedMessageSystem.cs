using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    public class LinkedMessageSystem
    {
        private int idSeeder;
        private static int offset = 1; //first message has id 1
        private ChatMessage head;

        public LinkedMessageSystem()
        {
            this.head = null;
        }

        /*public void AddMessage(string s, string m)
        {
            //the easy way: add at the front
            this.idSeeder = offset;
            offset++;

            ChatMessage c = new ChatMessage(idSeeder, s, m);
            c.Next = head;
            head = c;
        }*/

        public void AddMessage(string s, string m)
        {
            this.idSeeder = offset;
            offset++;
            ChatMessage c = new ChatMessage(idSeeder, s, m);

            // check if this is message c the first element that we add
            if (head == null)
            {
                head = c;
            }
            else
            {
                // there is already at least one element in the list
                ChatMessage prev = head;
                ChatMessage curr = head.Next;
                while (curr != null)
                {
                    // Move prev and curr to next position
                    prev = curr;
                    curr = curr.Next;
                }
                // Now prev is the last element in the list
                // add the new lelement after prev
                prev.Next = c;
            }
        }

        public ChatMessage FindByID (int id)
        {
            if (head == null)
            {
                // no messages in the list
                return null;
            }
            else
            {
                ChatMessage curr = head;
                while (curr != null)
                {
                    if (curr.GetID() == id)
                    {
                        return curr;
                    }
                    else
                    {
                        // go to the next element
                        return curr.Next;
                    }
                }

                return null;
            }
        }

        public bool RemoveMessageByID(int id)
        {
            if (head == null)
            {
                // empty list so removal is not possible
                return false;
            }
            else
            {
                // list contains at least one element
                if (head.GetID() == id)
                {
                    // remove the first element
                    head = head.Next;
                }
                else
                {
                    // should not be removed, maybe some other element
                    ChatMessage prev = head;
                    ChatMessage curr = head.Next;

                    while (curr != null)
                    {
                        if (curr.GetID() == id)
                        {
                            // we should remove curr
                            prev.Next = curr.Next;
                            curr = null;
                            return true;
                        }
                        else
                        {
                            // we should inspect the next element
                            prev = curr;
                            curr = curr.Next;
                        }
                    }
                }

                return false;
            }
        }

        public string[] GetAllMessages()
        {
            List<string> messages = new List<string>();
            ChatMessage curr = head;
            while (curr != null)
            {
                messages.Add(curr.GetMessage());
                // go to the next element
                curr = curr.Next;
            }

            return messages.ToArray();
        }
    }
}
