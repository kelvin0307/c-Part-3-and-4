// Part 3 opdr 16

List<string> strings = new List<string>();

strings.Add("First");
strings.Add("Second");
strings.Add("Third");

// Remember, this is how you print all the items in a list
strings.ForEach(Console.WriteLine);

static void RemoveLast(List<string> strings)
{
    strings.RemoveAt(strings.Count - 1);
}

RemoveLast(strings);
RemoveLast(strings);

strings.ForEach(Console.WriteLine);
