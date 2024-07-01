using static System.Console;

namespace CallStackExceptionHandlinglib;

public class Processor
{
    public static void Gamma(){ //public can be called from outside the project
        WriteLine("In Gamma");
        Delta();
    }

    private static void Delta(){ //private so that it can't be called from outside the project
        WriteLine("In Delta");
        File.OpenText("Bad File Path");
    }
}
