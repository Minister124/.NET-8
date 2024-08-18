using PacktLibraryNetStandard2;
using Env = System.Environment; //Aliases
using Nep = Nepal; //Aliases
using Sun = Sunsari; //Aliases

ConfigureConsole(); // Sets Current culture to US english

//Alternatives:
// ConfigureConsole(useComputerCulture: true); // Sets Current culture to computer's culture
//ConfigureConsole(culture: "fr-FR"); // Use French Culture.

PacktLibraryNetStandard2.Person bob = new();
WriteLine(bob); //Implicit call to ToString();

// WriteLine(bob.ToString()); Does the same thing.

#region Setting and outputting field values

bob.Name = "Khatey";

bob.Born = new DateTimeOffset(
    year: 1989,
    month: 12,
    day: 25,
    hour: 15,
    minute: 30,
    second: 24,
    offset: new TimeSpan(hours: 5, minutes: 45, seconds: 0) //Nepal Time
);

#endregion

WriteLine($"{bob.Name} was born on {bob.Born}.");

#region Avoiding namespace conflict using Aliases and using directives
Nep.Person p = new();
Sun.Person f = new();

WriteLine(Env.MachineName);
WriteLine(Env.OSVersion);
WriteLine(Env.CurrentDirectory);
WriteLine(Env.ProcessorCount);
WriteLine(Env.CommandLine);

#endregion


#region Setting field values using object initializer syntax

Person MangneyBudo =
    new() { Name = "Mangney Budo", Born = new(1991, 4, 28, 5, 15, 45, TimeSpan.Zero) };

WriteLine(
    format: "{0} was born in {1:d}", //short date.
    arg0: MangneyBudo.Name,
    arg1: MangneyBudo.Born
);

//using interpolated string
WriteLine($"{MangneyBudo.Name} was born in {MangneyBudo.Born:d}");

#endregion

#region enums

bob.ancientWondersOfWorld = WondersOfTheAncientWorld.GreatPyramidOfGiza;

WriteLine(
    format: "{0} who was born in {1:d}, favorite wonder of the world is {2}",
    arg0: bob.Name,
    arg1: bob.Born,
    arg2: bob.ancientWondersOfWorld
);

#endregion

#region storing multiple values using enum

bob.BucketList =
    WondersOfTheAncientWorld.HangingGardensOfBabylon
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");
#endregion

#region Understanding Generic Type

Person shit = new();
shit.Name = "Shit";
bob.Children.Add(shit); //works for all version of C#

//Works for C#3 and higher
bob.Children.Add(new Person { Name = "Shithead" });

//Works for C#9 and higher
bob.Children.Add(new() { Name = "Shit Face" });

WriteLine($"{bob.Name} has {bob.Children.Count} Childrens");

#endregion
