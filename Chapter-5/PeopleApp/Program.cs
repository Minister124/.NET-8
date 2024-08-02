using PacktLibraryNetStandard2;

ConfigureConsole(); // Sets Current culture to US english

//Alternatives:
// ConfigureConsole(useComputerCulture: true); // Sets Current culture to computer's culture
//ConfigureConsole(culture: "fr-FR"); // Use French Culture.

Person bob = new();
WriteLine(bob); //Implicit call to ToString();
// WriteLine(bob.ToString()); Does the same thing.