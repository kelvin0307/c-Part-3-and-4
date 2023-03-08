using System.IO;

string path = @"C:\Users\kelvi\source\repos\ConsoleApp2\ConsoleApp2\data.txt";
string[] lines = File.ReadAllLines(path);
foreach (string line in lines)
{
    Console.WriteLine(line);
}