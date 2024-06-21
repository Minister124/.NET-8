Write("Enter a Number between 0 and 255: ");
string firstAmount = ReadLine()!;
if (string.IsNullOrEmpty(firstAmount)) return;

Write("Enter Another Number Between 0 and 255: ");
string secondAmount = ReadLine()!;
if (string.IsNullOrEmpty(secondAmount)) return;

try
{
    decimal firstAmountValue = decimal.Parse(firstAmount);
    decimal secondAmountValue = decimal.Parse(secondAmount);
    if (firstAmountValue >= 0 && firstAmountValue <= 255 && secondAmountValue >= 0 && secondAmountValue <= 255){
        decimal result = firstAmountValue / secondAmountValue;
        WriteLine($"{firstAmountValue} divided by {secondAmountValue} is {result}");
    }else{
        WriteLine("Please Enter The Valid Value in range 0 to 255.");
    }
}
catch(FormatException)
{
    WriteLine("FormatException: Input string was not in a correct format");
}
catch(OverflowException)
{
    WriteLine("OverflowException: Value was too large");
}
catch(DivideByZeroException)
{
    WriteLine("DivideByZeroException: This occured because the number was divided by 0");
}
