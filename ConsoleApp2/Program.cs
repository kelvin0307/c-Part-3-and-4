// Part 3 opdr 29
string input;
List<int> ages = new List<int>();
List<string> names = new List<string>();

while ((input = Console.ReadLine()) != "")
{
    string[] parts = input.Split(',');
    string name = parts[0];
    int age = int.Parse(parts[1].Trim());
    names.Add(name);
    ages.Add(age);
}
int maxAge = ages[0];
string oldestName = names[0];
for (int i = 1; i < ages.Count; i++)
{
    if (ages[i] > maxAge)
    {
        maxAge = ages[i];
        oldestName = names[i];
    }

}
Console.WriteLine("The name of the oldest person is: " + oldestName);