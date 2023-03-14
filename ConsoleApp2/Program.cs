// Try your code here, if you want

using ConsoleApp2;

PaymentTerminal lunchCafeteria = new PaymentTerminal();
Console.WriteLine(lunchCafeteria);

PaymentCard annesCard = new PaymentCard(2);

Console.WriteLine("amount of money on the card is " + annesCard.Balance + " euros");

bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
Console.WriteLine("there was enough money: " + wasSuccessful);

lunchCafeteria.AddMoneyToCard(annesCard, 100);

wasSuccessful = lunchCafeteria.EatLunch(annesCard);
Console.WriteLine("there was enough money: " + wasSuccessful);

Console.WriteLine("amount of money on the card is " + annesCard.Balance + " euros");

Console.WriteLine(lunchCafeteria);
