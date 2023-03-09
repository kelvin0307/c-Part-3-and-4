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
        public int Age { get; set; }
        public int Length { get; set; }
        public int Weigth { get; set; }

        public Person(string name, int age, int length, int weight)
        {
            Name = name;
            Age = age;
            Length = length;
            Weigth = weight;
        }
    }
}
