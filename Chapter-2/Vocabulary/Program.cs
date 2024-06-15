// Outputs the current line terminator string.
// By default, this is a carriage-return and line feed.
Console.WriteLine();

// Outputs the greeting and the current line terminator string.
Console.WriteLine("Hello Kushal");

// Outputs a formatted number and date and the current line terminator string.
Console.WriteLine("Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);

System.Data.DataSet ds;
HttpClient client;

Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp == null) return; // quit the app
// loop through the assemblies that my app references

foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{

    // load the assembly so we can read its details
    Assembly a = Assembly.Load(name);

    // declare a variable to count the number of methods
    int methodCount = 0;

    // loop through all the types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // add up the counts of methods
        methodCount += t.GetMethods().Count();
    }

    // output the count of types and their methods
    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount, 
    arg2: name.Name);
}

//Let the heightInMeters Variable become equal to 1.88
double heightInMeters = 1.88;
Console.WriteLine($"The Variable {nameof(heightInMeters)} has the value {heightInMeters}.");