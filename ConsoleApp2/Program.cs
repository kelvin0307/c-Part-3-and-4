// Part 3 opdr 28
string input;
List<int> ages = new List<int>();
while ((input = Console.ReadLine()) != "")
{
    string[] parts = input.Split(',');
    int age = int.Parse(parts[1].Trim());
    ages.Add(age);
}
int maxAge = ages[0];
for (int i = 1; i < ages.Count; i++)
{
    if (ages[i] > maxAge)
    {
        maxAge = ages[i];
    }
}
Console.WriteLine("The oldest person is {0} years old.", maxAge);