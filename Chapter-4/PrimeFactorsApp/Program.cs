using static System.Console;
using PrimeFactorsLib;

Write("Enter the Number Between 1 and 1000: ");

if(int.TryParse(ReadLine(), out int number)){
    WriteLine(format: "Prime Factors of {0} are: {1}",
    arg0: number,
    arg1: PrimeNumber.PrimeFactors(number));
}