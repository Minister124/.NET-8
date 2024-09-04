using System;

//All the classes in this file will be defined in the following namespace

namespace PacktLibraryNetStandard2;

#region Pattern-Matching Flight Passengers
public class Passenger
{
    public string? Name { get; set; }
}

public class BussinessClassPassenger : Passenger
{
    public override string ToString()
    {
        return $"Business class: {Name}";
    }
}

public class FirstClassPassenger : Passenger
{
    public int AirMiles { get; set; }

    public override string ToString()
    {
        return $"First class with {AirMiles:N0} air miles: {Name}";
    }
}

public class CoachClassPassenger : Passenger
{
    public double CarryOnKG { get; set; }

    public override string ToString()
    {
        return $"Coach class with {CarryOnKG:N2} KH carry on: {Name}";
    }
}
#endregion
