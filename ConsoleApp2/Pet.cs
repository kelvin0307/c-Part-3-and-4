using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pet
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public Pet(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
    }
}
