using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SimpleDate
    {
        private int day;
        private int month;
        private int year;

        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void Advance()
        {
            this.day++;
            if (this.day > 30)
            {
                this.day = 1;
                this.month++;
                if (this.month > 12)
                {
                    this.month = 1;
                    this.year++;
                }
            }
        }

        public void Advance(int howManyDays)
        {
            for (int i = 0; i < howManyDays; i++)
            {
                this.Advance();
            }
        }

        public SimpleDate AfterNumberOfDays(int days)
        {
            SimpleDate newDate = new SimpleDate(this.day, this.month, this.year);
            newDate.Advance(days);
            return newDate;
        }

        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }

        public bool Before(SimpleDate compared)
        {
            if (this.year < compared.year)
            {
                return true;
            }

            if (this.year == compared.year && this.month < compared.month)
            {
                return true;
            }

            if (this.year == compared.year && this.month == compared.month &&
                this.day < compared.day)
            {
                return true;
            }

            return false;
        }
    }
}

