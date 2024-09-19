using System;

namespace PacktLibraryModern;

public class ImmutablePerson
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}

public record ImmutableVechile{
    public string? Brand { get; init; }
    public string? Color { get; init; }

    public string? Wheels { get; init; }
}
