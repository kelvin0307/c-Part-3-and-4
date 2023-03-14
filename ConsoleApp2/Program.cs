using ConsoleApp2;

Pet lucy = new Pet("Lucy", "golden retriever");
Person leo = new Person("Leo", lucy);
Console.WriteLine(leo.Name + "has a friend called" + leo.Pet.Name + "(" + leo.Pet.Breed + ")");

Pet toothless = new Pet("toothless", "dragon");
Person mike = new Person("Mike", toothless);
Console.WriteLine(mike.Name + "has a friend called" + mike.Pet.Name + "(" + mike.Pet.Breed + ")");

Pet stitch = new Pet("stitch", "blue alien");
Person lilo = new Person("lilo", stitch);
Console.WriteLine(lilo.Name + "has a friend called" + lilo.Pet.Name + "(" + lilo.Pet.Breed + ")");