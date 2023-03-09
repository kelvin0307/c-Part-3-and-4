using ConsoleApp2;

HealthStation childrensHospital = new HealthStation();

Person ethan = new Person("Ethan", 1, 110, 7);
Person peter = new Person("Peter", 33, 176, 85);

Console.WriteLine(ethan.Name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
Console.WriteLine(peter.Name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

childrensHospital.Feed(ethan);
childrensHospital.Feed(peter);

Console.WriteLine(ethan.Name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
Console.WriteLine(peter.Name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

childrensHospital.Weigh(ethan);
childrensHospital.Weigh(ethan);
childrensHospital.Weigh(ethan);
childrensHospital.Weigh(ethan);

Console.WriteLine("weighings performed: " + childrensHospital.Weighings);