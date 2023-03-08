// Part 3 opdr 29
List<string> names = new List<string>();
List<int> birthYears = new List<int>();

while (true)
{
    Console.Write("Enter name and birth year (or press Enter to finish): ");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        break;
    }

    string[] parts = input.Split(',');
    string name = parts[0].Trim();
    int birthYear = int.Parse(parts[1].Trim());
    names.Add(name);
    birthYears.Add(birthYear);
}

int currentYear = DateTime.Now.Year;
int maxAge = int.MinValue;
string longestName = string.Empty;

for (int i = 0; i < names.Count; i++)
{
    string name = names[i];
    int birthYear = birthYears[i];
    int age = currentYear - birthYear;

    if (age > maxAge || (age == maxAge && name.Length > longestName.Length))
    {
        maxAge = age;
        longestName = name;
    }
}

Console.WriteLine("The longest name is: " + longestName);
Console.WriteLine("The highest age is: " + maxAge);