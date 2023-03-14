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
        }

        public void AddMoneyToCard(PaymentCard card, double sum)
        {
            card.AddMoney(sum);
        }

        public double DrinkCoffee(double payment)
        {
            if (payment >= 2.50)
            {
                money += 2.50;
                coffeeAmount++;
                return payment - 2.50;
            }

            return payment;

        }

        public double EatLunch(double payment)
        {
            if (payment > 10.30)
            {
                money += 10.30;
                lunchAmount++;
                return payment - 10.30;
            }
            return payment;

        }

        public bool DrinkCoffee(PaymentCard card)
        {
            if (card.Balance >= 2.50)
            {
                money += 2.50;
                coffeeAmount++;
                card.TakeMoney(2.50);
                return true;
            }

            return false;
        }

        public bool EatLunch(PaymentCard card)
        {
            if (card.Balance >= 10.30)
            {
                money += 10.30;
                lunchAmount++;
                card.TakeMoney(10.30);
                return true;
            }
            return false;

        }

        public override string ToString()
        {
            return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
    }
}
