#region Exploring unary Operators
int a = 4;
int b = a++;
int c = 3;
int d = ++c; //prefix means increment c before assigning it
WriteLine($"a is {a}, b is {b}");
WriteLine($"c is {c}, d is {d}");
#endregion

#region Exploring binary arithmetic operators
int e = 12;
int f = 5;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e  f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
#endregion

#region difference between whole number and real number divisions
double g = 12.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");
#endregion

#region Assignment Operators
int p = 10;
p += 3; //Equivalent to: p = p+3;
p -= 3; //Equivalent to: p = p-3;
p *= 3; //Equivalent to: p = p*3;
p /= 3; //Equivalent to: p = p/3;
#endregion

#region Null-cpalescing operators
//string? someoneName = ReadLine();

// The maxLength variable will be the length of someoneName if it is 
// not null, or 30 if someoneName is null.
//int maxLength = someoneName?.Length ?? 40;

//The SomeoneName Variable will be "Unknown" if someoneName was null.

//someoneName ??= "Unknown";
#endregion

#region Exploring Logical Operators
bool r = true;
bool q = false;
WriteLine($"AND | r | q ");
WriteLine($"p | {r & r,-5} | {r & q,-5} ");
WriteLine($"q | {q & r,-5} | {q & q,-5} ");
WriteLine();
WriteLine($"OR | r | q ");
WriteLine($"p | {r | r,-5} | {r | q,-5} ");
WriteLine($"q | {q | r,-5} | {q | q,-5} ");
WriteLine();
WriteLine($"XOR | r | q ");
WriteLine($"p | {q ^ r,-5} | {r ^ q,-5} ");
WriteLine($"q | {q ^ r,-5} | {q ^ q,-5} ");
#endregion

#region Exploring conditional logical operators
static bool DoStuff(){
    WriteLine("I am doing some stuff.");
    return true;
}
WriteLine();
//Note that DoStuff() returns true.
WriteLine($"r & DoStuff() = {r & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");
WriteLine();
WriteLine($"r && DoStuff() = {r && DoStuff()}"); 
WriteLine($"q && DoStuff() = {q && DoStuff()}");
#endregion

#region  Exploring bitwise and binary shift operators
#endregion