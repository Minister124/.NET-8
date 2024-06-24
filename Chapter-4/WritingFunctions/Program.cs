// MultiplicationTable(7);
// MultiplicationTable(8);

ConfigureConsole();

decimal payTax = CalculateTax(amount:12, regionCode:"FR");
WriteLine($"You need to pay {payTax:C} in tax");