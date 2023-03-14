using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Song
    {
        public string Title { get; set; }
        public string MainCharacter { get; set; }
        public int Pages { get; set; }
        public Song(string title, string mainCharacter, int pages)
        {
            Title = title;
            MainCharacter = mainCharacter;
            Pages = pages;
        }

        public string Equals(Song compared)
        {
            if (Title == compared.Title && MainCharacter == compared.MainCharacter && Pages == compared.Pages)
            {
                return "Songs are equal";
            }
            return "Strange things are afoot";
        }
    }
}
