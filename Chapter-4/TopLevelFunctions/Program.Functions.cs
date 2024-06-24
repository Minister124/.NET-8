using static System.Console;

// Do not define a namespace so this class goes in the default empty namespace
// just like the auto-generated partial Program class.
partial class Program
{
    static void MyNameSpace(){
        WriteLine("Namespace of Program class: {0}",
        arg0: typeof(Program).Namespace);
    }
}
