using CallStackExceptionHandlinglib;
using static System.Console;

WriteLine("In Main");
Alpha();

void Alpha(){
    WriteLine("In Alpha");
    try{
        Beta();
    }catch(Exception ex){
        WriteLine($"Caught exception: {ex.Message}");
    }
}

void Beta(){
    WriteLine("In Beta");
    Processor.Gamma();
}