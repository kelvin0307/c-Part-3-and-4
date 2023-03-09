using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PaymentTerminal
    {
        private double money = 1000;  // amount of cash
        private int coffeeAmount; // number of sold coffees
        private int lunchAmount;  // number of sold lunches

        public PaymentTerminal()
        {
            // register initially has 1000 euros of money
        }

        public double DrinkCoffee(double payment)
        {
            // an coffee now costs 2.50 euros
            // increase the amount of cash by the price of an coffee mean and return the change
            // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment
            if (payment > 2.50)
            {
                money += 2.50;
                return payment - 2.50;
            }

            return payment;

        }

        public double EatLunch(double payment)
        {
            // a lunch now costs 10.30 euros
            // increase the amount of cash by the price of a lunch and return the change
            // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment
            if (payment > 10.30)
            {
                money += 10.30;
                return payment - 10.30;
            }
            return payment;

        }

        public override string ToString()
        {
            return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
    }
}
