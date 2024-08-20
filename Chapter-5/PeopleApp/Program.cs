using PacktLibraryModern;
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
bob.Children.Add(new() { Name = "Shit Face", Born = new(1997, 4, 15, 12, 12, 12, TimeSpan.Zero) });

WriteLine(
    $"{bob.Name} who is {Person.Species} has {bob.Children.Count} Childrens are from {bob.Planet}"
);

for (int i = 0; i < bob.Children.Count; i++)
{
    WriteLine($"{bob.Children[i].Name}");
    WriteLine($"{bob.Children[i].Born}");
}

foreach (var item in bob.Children)
{
    WriteLine($"{item.Name}");
    WriteLine($"{item.Born}");
}

#endregion

#region Static Field
BankAccount.InterestRate = 0.012M; //stored a shared value in static field

BankAccount Khatey = new();
Khatey.AccountName = "KhateyAccount";
Khatey.Balance = 1200;

WriteLine(
    format: "{0} earned {1:C} interest",
    arg0: Khatey.AccountName,
    arg1: Khatey.Balance * BankAccount.InterestRate
);

BankAccount bhikari = new();
bhikari.AccountName = "BhikariAccount";
bhikari.Balance = 20;

WriteLine(
    format: "{0} has earned {1:c} interest",
    arg0: bhikari.AccountName,
    arg1: bhikari.Balance * BankAccount.InterestRate
);
#endregion

#region Required Fields
Book book =
    new()
    {
        Isbn = "978-1803237800",
        Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals",
    };

WriteLine(
    "{0}: {1} written by {2} has {3:N0} pages",
    book.Isbn,
    book.Title,
    book.Author,
    book.PageCount
);
#endregion

#region Constructor
Person blank = new();
WriteLine(
    format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blank.Name,
    arg1: blank.Planet,
    arg2: blank.Instantiated
);

#region Multiple Constructor
Person sheesh = new(homePlanet: "Mars");
WriteLine(format: "{0} is from {1}", arg0: sheesh.Name, arg1: sheesh.Planet);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format:
 "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
 arg0: gunny.Name,
 arg1: gunny.Planet,
 arg2: gunny.Instantiated);
#endregion
#endregion

#region Requiring fields to be set during instantiation
// Instantiate a book using object initializer syntax.
Book book1 = new()
{
 Isbn = "978-1803237800",
 Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
};

Book book2 = new(isbn: "978-1803237800",
 title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
 Author = "Mark J. Price",
 PageCount = 821
};
WriteLine($"{book2.Isbn}: {book2.Title} written by {book2.Author} has {book2.PageCount}");
#endregion