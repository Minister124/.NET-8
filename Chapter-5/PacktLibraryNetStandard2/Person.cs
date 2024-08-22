using System;
using System.Collections.Generic;

namespace PacktLibraryNetStandard2;

public class Person : Object
{
    #region Fields: Data or state of this person.
    public string? Name; // ? means it can be null
    public DateTimeOffset Born;

    // We have multiple choices for the data type of the Born field. .NET 6 introduced
    // the DateOnly type. This would store only the date without a time value. DateTime
    // stores the date and time of when the person was born, but it varies between local
    // and UTC time. The best choice is DateTimeOffset, which stores the date, time,
    // and hours offset from Universal Coordinated Time (UTC), which is related to the
    // time zone. The choice depends on how much detail you need to store.

    public WondersOfTheAncientWorld ancientWondersOfWorld;
    public WondersOfTheAncientWorld BucketList;

    public List<Person> Children = new(); //generic collection

    public const string Species = "Homo Sapiens"; //instance of class is not needed to access. Is done through className

    public readonly string Planet = "Earth"; //instance of class is needed

    public readonly DateTime Instantiated;
    #endregion

    #region Constructors: Called when using new to instantiate a type
    public Person()
    {
        // Constructors can set default values for fields
        // including any read-only fields like Instantiated.
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    #endregion

    #region Multiple Constructors
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        Planet = homePlanet;
        Instantiated = DateTime.Now;
    }

    public Person(string homePlanet)
    {
        Name = "Sheesh";
        Planet = homePlanet;
    }
    #endregion

    #region Returning values from Methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {Planet}";
    }
    #endregion

    #region Defining and Passing Parameters to Methods
    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHello(string name)
    {
        return $"{Name} say 'Hello, {name}!'";
    }
    #endregion

    #region Optional Parameters
    public string OptionalParameters(
        int count,
        string command = "Run!",
        double number = 0.0,
        bool active = true
    )
    {
        return string.Format(
            format: "Command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active
        );
    }
    #endregion

    #region Controlling how parameters are passed
    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        // out parameters cannot have a default and they
        // must be initialized inside the method.
        z = 100;
        // Increment each parameter except the read-only x.
        w++;
        //x++; // Gives a compiler error!
        y++;
        z++;
        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }
    #endregion
}
