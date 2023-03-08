List<int> ints = new List<int>();

while (true)
{
    string input = Console.ReadLine();
    if(input == "end")
    {
        break;
    }
    int number = int.Parse(input);

    ints.Add(number);
}

foreach (int i in ints)
{
    Console.Write(i);
}