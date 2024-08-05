using PacktLibraryNetStandard2;
using Nep = Nepal; //Aliases
using Sun = Sunsari; //Aliases
using Env = System.Environment; //Aliases

ConfigureConsole(); // Sets Current culture to US english

//Alternatives:
// ConfigureConsole(useComputerCulture: true); // Sets Current culture to computer's culture
//ConfigureConsole(culture: "fr-FR"); // Use French Culture.

PacktLibraryNetStandard2.Person bob = new();
WriteLine(bob); //Implicit call to ToString();
// WriteLine(bob.ToString()); Does the same thing.

bob.Name = "Khatey";

bob.Born = new DateTimeOffset(
    year: 1989, month: 12, day: 25, hour: 15, minute: 30, second: 24,
    offset: new TimeSpan(hours: 5, minutes: 45, seconds: 0) //Nepal Time
);

WriteLine($"{bob.Name} was born on {bob.Born}.");

Nep.Person p = new();
Sun.Person f = new();

WriteLine(Env.MachineName);
WriteLine(Env.OSVersion);
WriteLine(Env.CurrentDirectory);
WriteLine(Env.ProcessorCount);
WriteLine(Env.CommandLine);


