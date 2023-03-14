using ConsoleApp2;

Money money = new Money(100, 00);
Money moreMoney = new Money(500, 50);

Money combined = money.Plus(moreMoney);

Console.WriteLine(money);         // prints "100.00e"
Console.WriteLine(moreMoney);    // prints "500.50e"
Console.WriteLine(combined);     // prints "600.50e"

Money lessMoney = moreMoney.Minus(money);

Console.WriteLine(money);         // prints "100.00e"
Console.WriteLine(moreMoney);    // prints "500.50e"
Console.WriteLine(lessMoney);    // prints "400.50e"

lessMoney = lessMoney.Minus(money);

Console.WriteLine(money);         // prints "100.00e"
Console.WriteLine(moreMoney);    // prints "500.50e"
Console.WriteLine(lessMoney);    // prints "300.50e"

Console.WriteLine(lessMoney.LessThan(moreMoney));   // prints "True"
Console.WriteLine(lessMoney.LessThan(money));       // prints "False"

lessMoney = lessMoney.Minus(moreMoney);
Console.WriteLine(lessMoney);    // prints "0.00e"