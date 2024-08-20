using System.Diagnostics.CodeAnalysis;

namespace PacktLibraryModern;

public class Book
{
    #region Requiring Fields
    public required string? Isbn;
    public required string? Title; //required needs .NET 7 or later

    public string? Author;
    public int PageCount;
    #endregion

    //Constructor for use with object initializer syntax.
    public Book(){}

    //Constructor with parameters to set required fields
    [SetsRequiredMembers] //only then can be accessed by object of this class
    public Book(string? isbn, string? title){
        Isbn = isbn;
        Title = title;
    }
}
