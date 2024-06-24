partial class Program{
    static void MultiplicationTable(int num, int rows = 12){
        for(int i = 1; i <= rows; i++){
            WriteLine($"{num} x {i} = {num*i}");
        }
        WriteLine();
    }
}