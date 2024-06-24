using static System.Console;

namespace TopLevelFunctions;

class Program
{

    static void MyNameSpace(){
        WriteLine("Namespace of program class: {0}",
        arg0: typeof(Program).Namespace);
    }
    static void Main(string[] args)
    {
        MyNameSpace();
        Console.WriteLine("Hello, World!");
    }
}
