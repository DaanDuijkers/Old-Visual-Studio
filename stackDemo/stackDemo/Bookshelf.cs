using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackDemo
{
    public class Bookshelf
    {
        //private Stack<string> books = null;
        private Queue<string> books = null;

        public Bookshelf ()
        {
            //books = new Stack<string>();
            books = new Queue<string>();
        }

        public void AddItem (string book)
        {
            books.Enqueue(book);
        }

        public string GetItem ()
        {
            return books.Dequeue();
        }

        public int NumberOfItems()
        {
            return books.Count();
        }

        public string ViewItem()
        {
            return books.Peek();
        }
    }
}
