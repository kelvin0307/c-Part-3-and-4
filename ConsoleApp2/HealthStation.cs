using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HealthStation
    {
        public int Weighings { get; private set; }
        public int Weigh(Person person)
        {
            Weighings++;
            return person.Weigth;
        }

        public void Feed(Person person)
        {
            person.Weigth++;
        }
    }
}
