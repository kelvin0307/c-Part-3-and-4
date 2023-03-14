using ConsoleApp2;

Apartment manhattanStudioApt = new Apartment(1, 16, 5500);
Apartment atlantaTwoBedroomApt = new Apartment(2, 38, 4200);
Apartment bangorThreeBedroomApt = new Apartment(3, 78, 2500);
Console.WriteLine(manhattanStudioApt.MoreExpensiveThan(atlantaTwoBedroomApt));
Console.WriteLine(bangorThreeBedroomApt.MoreExpensiveThan(manhattanStudioApt));