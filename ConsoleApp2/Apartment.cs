using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    internal class Apartment
    {
        public int Id;
        public int Height;
        public int Price;
        public Apartment(int id, int height, int price)
        {
            Id = id;
            Height = height;
            Price = price;
        }

        public bool LargerThan(Apartment comparred)
        {
            if (Height > comparred.Height)
            {
                return true;
            }
            return false;
        }

        public int PriceDifference(Apartment compared)
        {
            if (Price > compared.Price)
            {
                return Price - compared.Price;
            }
            else
            {
                return compared.Price - Price;
            }
        }

        public bool MoreExpensiveThan(Apartment compared)
        {
            if (Price > compared.Price)
            {
                return true;
            }
            return false;
        }
    }
}
