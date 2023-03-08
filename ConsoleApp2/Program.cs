// Part 3 opdr 21

string line;
while ((line = Console.ReadLine()) != "")
{
    string[] words = line.Split(' ');
    Console.WriteLine(words[words.Length - 1]);
}