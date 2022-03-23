using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_test
{
    class Game
    {
        ArrayList _aPictures = new ArrayList();

        public void newGame()
        {
            newArray();
        }

        private ArrayList ShuffleArrayList(ArrayList source)
        {
            ArrayList sortedList = new ArrayList();
            Random generator = new Random();

            while (source.Count > 0)
            {
                int position = generator.Next(source.Count);
                sortedList.Add(source[position]);
                source.RemoveAt(position);
            }

            return sortedList;
        }

        private void newArray()
        {
            //arraylist leegmaken (bakjes verwijderen)
            _aPictures.Clear();

            //1e set van 12 plaatjes
            for (int i = 1; i < 13; i++)
            {
                _aPictures.Add(i);
            }

            //2e set van 12 plaatjes
            for (int i = 1; i < 13; i++)
            {
                _aPictures.Add(i);
            }

            //shuffle alle bakjes door elkaar
            _aPictures = ShuffleArrayList(_aPictures);

           // int j = 1;
           // foreach(int value in _aPictures)
           // {
           //     Console.Write(j + " = " + value + "\r\n");
           //     j++;
           // }
        }

        public string checkPicture(int plaatjeNummer)
        {
            plaatjeNummer = plaatjeNummer - 1;
            return _aPictures[plaatjeNummer].ToString();
        }
    }
}
