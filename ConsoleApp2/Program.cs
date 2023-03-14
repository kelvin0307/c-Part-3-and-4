// Try your code here, if you want
using ConsoleApp2;

Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
Song spongebob = new Song("Bikini bottom", "Spongebob", 183);

var result = jackSparrow.Equals(anotherSparrow);
Console.WriteLine(result);

var result2 = jackSparrow.Equals(spongebob);
Console.WriteLine(result2);