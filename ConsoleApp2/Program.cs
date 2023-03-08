using System.IO;

string path = @"C:\Users\kelvi\source\repos\ConsoleApp2\ConsoleApp2\guestlist.txt";
HashSet<string> guestList = new HashSet<string>(File.ReadAllLines(path));

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

if (guestList.Contains(name))
{
    Console.WriteLine("Welcome to the party, " + name + "!");
}
else
{
    Console.WriteLine("Sorry, you are not on the guest list.");
}