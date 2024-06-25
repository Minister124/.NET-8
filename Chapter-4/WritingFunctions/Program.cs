// MultiplicationTable(7);
// MultiplicationTable(8);

ConfigureConsole(useComputerCulture: true);

decimal payTax = CalculateTax(amount:12, regionCode:"FR");
WriteLine($"You need to pay {payTax:C} in tax");

WriteLine($"You must pay {CalculateTax(amount: 1498, regionCode:"FR"):C} in tax");