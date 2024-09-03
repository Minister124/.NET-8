using System;

namespace PacktLibraryNetStandard2;

// This file is for simulating auto-generated class
public partial class Person
{
    #region Properties: Methods to get and/or set data or state

    // A readonly property defined using C# 1 to 5 syntax
    public string Origin
    {
        get { return string.Format("{0} was born on {1}.", arg0: Name, arg1: Planet); }
    }

    //Two readonly properties defined using c#6 and later
    //lambda expression body syntax
    public string Greetings => $"{Name} says 'Hello!";
    public int Age => DateTime.Now.Year - Born.Year;

    // A read-write property defined using C# 3 auto-syntax.
    public string? FavoriteIceCream { get; set; }

    // A private backing field to store the property value
    private string? _favoritePrimaryColor;
    #endregion
}
