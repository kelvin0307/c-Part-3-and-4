using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PaymentCard
    {
        public double Balance { get; private set; }

        public PaymentCard(double balance)
        {
            Balance = balance;
        }

        public void AddMoney(double increase)
        {
            Balance = Balance + increase;
        }

        public bool TakeMoney(double amount)
        {
            // implement the method so that it only takes money from the card if
            // the balance is at least the amount parameter.
            // returns true if successful and false otherwise
            if(Balance > amount)
            {
                Balance -= amount;
                return true;
            }

            return false;
        }
    }
}
