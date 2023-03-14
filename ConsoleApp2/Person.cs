using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public string Name { get; set; }
        public Pet Pet { get; set; }
        public Person(string name, Pet pet)
        {
            Name = name;
            Pet = pet;
        }
    }
}
