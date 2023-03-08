// Part 3 opdr 21

int[] array = { 5, 1, 3, 4, 2 };
PrintArrayInStars(array);

void PrintArrayInStars(int[] array)
{
    foreach (int i in array)
    {
        for(int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine(" ");
    }
}
