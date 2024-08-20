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

    #endregion
}
