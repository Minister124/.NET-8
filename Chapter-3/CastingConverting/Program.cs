#region Casting numbers Implicitly and Explicitly
int a = 10;
double x = a;
WriteLine($"a is {a} and x is {x}");

double y = 10.65;
//int v = y; As we know, double is a type which has larger range then Int. So, we are telling that we are aware of potential data loss.
int v = (int)y; //Explicit type casting.
WriteLine($"y is {y} and v is {v}"); // v losses the .65 part

long l = 10;
int b = (int)l;
WriteLine($"l is {l:N3}, b is {b}");

l = long.MaxValue;
b = (int)l;
WriteLine($"l is {l}, b is {b}");
#endregion