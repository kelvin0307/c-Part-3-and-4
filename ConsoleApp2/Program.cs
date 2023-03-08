List<string> strings = new List<string>();

while (true)
{
    string input = Console.ReadLine();
    if(input == "end")
    {
        break;
    }
    strings.Add(input);
}

Console.WriteLine(strings.Count);