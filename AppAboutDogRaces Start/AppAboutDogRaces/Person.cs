using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutDogRaces
{
    class Person
    {
        private String name;
        private int balance;

        public Person(String name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public Person(String name)
        { //a new member gets 10 euro as a gift
            this.name = name;
            this.balance = 10;
        }

        public String GetInfo()
        {
            String holder = this.name + ", balance: " + this.balance;
            return holder;
        }

        public void PlaceBet()
        {   //person may place 1 bet and change it as many times as he/she likes,
            //until the race starts.
            //It is not allowed to do a higher bet than the person's balance.
            //When the race starts, his/her balance will be lowered by the money of the bet.

        }

        public void FreezeBetAndPayForIt()
        {  //now the bet is frozen: you cannot change it anymore and have to pay the betting-money
        }

        public void PayOut()
        {  //when the race is finished, check if the person won.
            //if yes, he/she will receive 3 times the betting-money.

        }
    }
}
