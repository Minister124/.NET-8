using System.Globalization;

partial class Program{

    #region Everytype of Functions
    
    #region Functions that do not return value
    static void MultiplicationTable(int num, int rows = 12){
        for(int i = 1; i <= rows; i++){
            WriteLine($"{num} x {i} = {num*i}");
        }
        WriteLine();
    }
    #endregion

    #region Functions that return value
    static decimal CalculateTax(decimal amount, string regionCode){
        decimal rate = regionCode switch{
            "CH" => 0.99M,
            "DK" or "NO" => 0.25M, // Denmark, Norway 
            "GB" or "FR" => 0.2M, // UK, France
            "HU" => 0.27M, // Hungary
            "OR" or "AK" or "MT" => 0.0M, // Oregon, Alaska, Montana
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M, // California
            _ => 0.06M // Most other states
        };
        return rate * amount;
    }

    static void ConfigureConsole(string culture="fr-FR", bool useComputerCulture = false){
        // To enable Unicode characters like Euro symbol in the console.
        OutputEncoding = System.Text.Encoding.UTF8;

        if(!useComputerCulture){
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
    }
    #endregion

    #region Converting numbers from cardinal to ordinal
    /// <summary>
    /// Pass a 32-bit unsigned integer and it will be converted into its ordinal equivalent.
    /// </summary>
    /// <param name="number">Number as a cardinal value e.g. 1, 2, 3, and so on.</param>
    /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
    static string CardinalNumbersToOrdinal(uint number){
        uint lastTwoDigits = number % 100;
        switch(lastTwoDigits){
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                uint lastDigit = number % 10;
                string suffix = lastDigit switch{
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th",
                };
                return $"{number:N0}{suffix}";
        }
    }

    static void RunCardinalNumbersToOrdinal(){
        for(uint number = 1; number <= 200; number++){
            Write($"{CardinalNumbersToOrdinal(number)} ");
        }
        WriteLine();
    }
    #endregion

    #region Calculation factorial using recursion
    static int Factorial(int number){
        if(number == 0){
            return 1;
        }
        else if(number < 0){
            throw new ArgumentOutOfRangeException(message:$"Only Input: {number}", paramName: nameof(number));
        }
        else checked{
            return number * Factorial(number - 1);
        }
    }

    static void RunFactorial(){
        for(int i = -2; i <= 15; i++){
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too large for a 32-bit integer.");
            }
            catch(Exception ex){
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }
    #endregion

    #region Using Lambdas in Function Implementation
    static int FibonacciTerms(uint terms) => terms switch{
            0 => throw new ArgumentOutOfRangeException(paramName: nameof(terms), message: "Number of terms cannot be zero."),
            1 => 0,
            2 => 1,
            _ => FibonacciTerms(terms - 1) + FibonacciTerms(terms - 2)
        };
    static void RunFibonacciTerms(){
        for(uint i = 1; i <= 15; i++){
            WriteLine("Fibonacci term {0}: {1}",
            arg0: CardinalNumbersToOrdinal(i),
            arg1: FibonacciTerms(i));
        }
    }
    #endregion
    #endregion
}