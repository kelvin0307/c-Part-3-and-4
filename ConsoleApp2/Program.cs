using ConsoleApp2;

PaymentCard petesCard = new PaymentCard(10);

Console.WriteLine("money " + petesCard.Balance);
bool wasSuccessful = petesCard.TakeMoney(8);
Console.WriteLine("successfully withdrew: " + wasSuccessful);
Console.WriteLine("money " + petesCard.Balance);

wasSuccessful = petesCard.TakeMoney(4);
Console.WriteLine("successfully withdrew: " + wasSuccessful);
Console.WriteLine("money " + petesCard.Balance);