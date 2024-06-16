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