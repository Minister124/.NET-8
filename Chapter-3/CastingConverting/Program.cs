﻿#region Casting numbers Implicitly and Explicitly
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

l = 5_000_000_000;
b = (int)l;
WriteLine($"l is {l}, b is {b}");
#endregion

#region How negative numbres are represented in binary
WriteLine("{0, 12} {1, 34}", "Decimal", "Binary");
WriteLine("{0, 12} {0, 32:B32}", int.MaxValue);
for(int i = 8; i >= -8; i--){
    WriteLine("{0, 12} {0, 32:B32}", i);
}
WriteLine("{0, 12} {0, 32:B32}", int.MinValue);
/* Output
     Decimal                             Binary
  2147483647 01111111111111111111111111111111
           8 00000000000000000000000000001000
           7 00000000000000000000000000000111
           6 00000000000000000000000000000110
           5 00000000000000000000000000000101
           4 00000000000000000000000000000100
           3 00000000000000000000000000000011
           2 00000000000000000000000000000010
           1 00000000000000000000000000000001
           0 00000000000000000000000000000000
          -1 11111111111111111111111111111111
          -2 11111111111111111111111111111110
          -3 11111111111111111111111111111101
          -4 11111111111111111111111111111100
          -5 11111111111111111111111111111011
          -6 11111111111111111111111111111010
          -7 11111111111111111111111111111001
          -8 11111111111111111111111111111000
 -2147483648 10000000000000000000000000000000
*/ /*All the positive binary number representations start with 0 and all the negative binary number representations start with 1. 
The decimal value -1 is represented by all ones in binary.
That is why when you have an integer too large to fit in a 32-bit integer, it becomes -1.*/
#endregion