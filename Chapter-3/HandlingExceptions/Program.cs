WriteLine("Before Parsing: ");
Write("What is your age? ");
string? input = ReadLine();

try{
    if(input is null){
        WriteLine("You did not enter a value so the app has ended.");
        return;
    }
    int age = int.Parse(input!);
    WriteLine($"You are {age} years old");
}catch{
    WriteLine("Sorry cannot convert");
}