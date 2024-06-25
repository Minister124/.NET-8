using System.Globalization;

partial class Program{
    static void MultiplicationTable(int num, int rows = 12){
        for(int i = 1; i <= rows; i++){
            WriteLine($"{num} x {i} = {num*i}");
        }
        WriteLine();
    }

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
}