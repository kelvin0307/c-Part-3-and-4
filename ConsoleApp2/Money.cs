using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Money
    {
        private int euros;
        private int cents;

        public Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros = euros + cents / 100;
                cents = cents % 100;
            }

            this.euros = euros;
            this.cents = cents;
        }

        public Money Plus(Money addition)
        {
            int newEuros = euros + addition.euros;
            int newCents = cents + addition.cents;
            if (newCents >= 100)
            {
                newEuros += newCents / 100;
                newCents = newCents % 100;
            }

            return new Money(newEuros, newCents);
        }

        public Money Minus(Money decreaser)
        {
            int newEuros = euros - decreaser.euros;
            int newCents = cents - decreaser.cents;
            if (newCents < 0)
            {
                newEuros -= 1;
                newCents += 100;
            }

            if (newEuros < 0)
            {
                newEuros = 0;
                newCents = 0;
            }

            return new Money(newEuros, newCents);
        }

        public bool LessThan(Money compared)
        {
            if (euros < compared.euros)
            {
                return true;
            }
            else if (euros == compared.euros && cents < compared.cents)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string zero = "";
            if (cents <= 10)
            {
                zero = "0";
            }

            return euros + "." + zero + cents + "e";
        }
    }
}
