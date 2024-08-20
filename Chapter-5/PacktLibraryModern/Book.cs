namespace PacktLibraryModern;

public class Book
{
    #region Requiring Fields
    public required string? Isbn;
    public required string? Title; //required needs .NET 7 or later

    public string? Author;
    public int PageCount;
    #endregion
}
