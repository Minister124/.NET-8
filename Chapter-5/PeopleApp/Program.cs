using PacktLibraryModern;
using PacktLibraryNetStandard2;
using Fruit = (string Name, int Number); // Aliasing a tuple type.
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

bob.FavoriteWondersOfTheAncientWorld = WondersOfTheAncientWorld.GreatPyramidOfGiza;

/*
// Setting multiple enum values throws an exception.
bob.FavoriteWondersOfTheAncientWorld =
  WondersOfTheAncientWorld.StatueOfZeusAtOlympia |
  WondersOfTheAncientWorld.GreatPyramidOfGiza;

// Setting an invalid enum value throws an exception.
bob.FavoriteWondersOfTheAncientWorld = (WondersOfTheAncientWorld)128;*/


WriteLine(
    format: "{0} who was born in {1:d}, favorite wonder of the world is {2}",
    arg0: bob.Name,
    arg1: bob.Born,
    arg2: bob.FavoriteWondersOfTheAncientWorld
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
WriteLine(
    format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: gunny.Name,
    arg1: gunny.Planet,
    arg2: gunny.Instantiated
);
#endregion
#endregion

#region Requiring fields to be set during instantiation
// Instantiate a book using object initializer syntax.
Book book1 =
    new()
    {
        Isbn = "978-1803237800",
        Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals",
    };

Book book2 =
    new(
        isbn: "978-1803237800",
        title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
    )
    {
        Author = "Mark J. Price",
        PageCount = 821,
    };
WriteLine($"{book2.Isbn}: {book2.Title} written by {book2.Author} has {book2.PageCount}");
#endregion

#region Methods calling and return
bob.WriteToConsole();
WriteLine(bob.GetOrigin());
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Magenybudo"));
WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3, "Jump!", 98.5));
WriteLine(bob.OptionalParameters(3, number: 52.7, command: "Hide!")); //Naming parameter values when calling methods
WriteLine(bob.OptionalParameters(3, "Poke!", active: false));
bob.OptionalParameters(number: 52.7, command: "Hide!", count: 3); //you can change thier positions if you have name arguments
#endregion

#region types of parameters
int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

int e = 50;
int h = 60;
int g = 70;
WriteLine($"Before: e={e}, f={h}, g={g}, k doesn't exist yet!");

// Simplified C# 7 or later syntax for the out parameter.
bob.PassingParameters(e, h, ref g, out int k);
WriteLine($"After: e={e}, h={h}, g={g}, k={k}");
#endregion


// public class TextAndNumber
// {
//     public string? Text;
//     public int Number;
// }

// public class LifeTheUniverseAndEverything
// {
//     public TextAndNumber GetTheData()
//     {
//         return new TextAndNumber { Text = "What is the meaning of life", Number = 50 };
//     }
//
// }

#region returning multiple values using tuples
(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");
#endregion

#region Naming the fields in a tuple
Fruit fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");
var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");
#endregion

#region Deconstructing tuples
// Store return value in a tuple variable with two named fields.
(string name, int number) namedFields = bob.GetNamedFruit();

// You can then access the named fields.
WriteLine($"{namedFields.name}, {namedFields.number}");

// Deconstruct the return value into two separate variables.
(string name, int number) = bob.GetNamedFruit();

// You can then access the separate variables.
WriteLine($"{name}, {number}");

(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed tuple: {fruitName}, {fruitNumber}");
#endregion

#region Deconstructing others using tuple
var (name1, dob1) = bob; // Implicitly calls the Deconstruct method.
WriteLine($"Deconstructed person: {name1}, {dob1}");
var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");
#endregion

#region Local function
int lnum = 5;
try
{
    WriteLine($"{lnum} is {Person.Factorial(lnum)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says: {ex.Message} number was {lnum}");
    throw;
}
#endregion

#region  Controlling access with properties and indexers

Person sam = new() { Name = "Sam", Born = new(2000, 6, 25, 0, 0, 0, TimeSpan.Zero) };

WriteLine(sam.Origin);
WriteLine(sam.Greetings);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}");

string color = "Black";

try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");
}
catch (System.Exception ex)
{
    WriteLine(
        "Tried to set {0} to '{1}': {2}",
        nameof(sam.FavoritePrimaryColor),
        color,
        ex.Message
    );
}

sam.Children.Add(new() { Name = "Charlie", Born = new(2010, 6, 25, 0, 0, 0, TimeSpan.Zero) });
sam.Children.Add(new() { Name = "Khatey", Born = new(2015, 6, 25, 0, 0, 0, TimeSpan.Zero) });

//Get the list of childern
WriteLine($"Sam first child is {sam.Children[0].Name}");
WriteLine($"Sam first child is {sam.Children[1].Name}");

//Get using the int Indexer
WriteLine($"Sam first child is {sam[0].Name}");
WriteLine($"Sam first child is {sam[1].Name}");

//Get using the string indexer.
WriteLine($"Sam child name Khatey is {sam["Khatey"].Age} years old");

#endregion

#region Pattern Matching with Flight
Passenger[] passengers =
{
    new FirstClassPassenger { AirMiles = 1_419, Name = "Magney Budo" },
    new FirstClassPassenger { AirMiles = 16_564, Name = "Hawaldar Budo" },
    new BussinessClassPassenger { Name = "Dawa Budo" },
    new CoachClassPassenger { CarryOnKG = 25.7, Name = "Suntali Budi" },
    new CoachClassPassenger { CarryOnKG = 5.7, Name = "Khatey" },
};

foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger pq when pq.AirMiles > 35_000 => 1_500M,
        FirstClassPassenger pq when pq.AirMiles > 15_000 => 1_750M,
        FirstClassPassenger _ => 1_750M,
        BussinessClassPassenger _ => 1_000M,
        CoachClassPassenger pq when pq.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 500M,
        _ => 800M,
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}
#endregion
