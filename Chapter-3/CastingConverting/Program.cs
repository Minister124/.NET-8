using static System.Convert; //To use Int32
using System.Globalization; // To Parse String

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

#region Converting with System.Convert
double g = 10.95;
int c = ToInt32(g);
WriteLine($"g is {g}, c is {c}");

/*An important difference between casting and converting is that converting rounds the 
double value 9.8 up to 10 instead of trimming the part after the decimal point. Another 
is that casting can allow overflows while converting will throw an exception.
*/
#endregion

#region Rounding Numbers and the default rounding rules
double[,] doubles = {
 { 9.49, 9.5, 9.51 },
 { 10.49, 10.5, 10.51 },
 { 11.49, 11.5, 11.51 },
 { 12.49, 12.5, 12.51 } ,
 { -12.49, -12.5, -12.51 },
 { -11.49, -11.5, -11.51 },
 { -10.49, -10.5, -10.51 },
 { -9.49, -9.5, -9.51 }
};
WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
for (int i = 0; i < 8; i++){
    for (int j = 0; j < 3; j++)
    {
        Write($"| {doubles[i, j],6} | {ToInt32(doubles[i, j]),7} ");
    }
    WriteLine("|");
}
WriteLine();
#endregion

#region Taking Control of rounding rules
foreach (double i in doubles) //foreach statement can be used to enumerate all the items in a multi-dimensional array
{
    WriteLine(format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero is {1})",
    arg0: i,
    arg1: Math.Round(value: i, digits:0,
    mode: MidpointRounding.AwayFromZero));
}
#endregion

#region Converting from any type to a string

int number = 10;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new(); // Target typed object
WriteLine(me.ToString());
/*Passing any object to the WriteLine method implicitly converts it into a string, so it is 
not necessary to explicitly call ToString. We are doing so here just to emphasize what is 
happening. Explicitly calling ToString does avoid a boxing operation,
so if you are developing games with Unity then that can help you avoid memory garbage collection issues.
*/
#endregion

#region Converting from a binary object to a string

byte[] binaryObject = new byte[128]; //Allocate an array of 128 bytes

//populate the array with random bytes.
Random.Shared.NextBytes(binaryObject);

WriteLine("Binary Object as bytes");

for(int index = 0; index < binaryObject.Length; index++){
    Write($"{binaryObject[index]:X2}");
}
WriteLine();

// Convert the array to Base64 string and output as text.
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");

#endregion

#region Parsing from strings to numbers or dates and times

 //setting the current culture to make sure date parsing works.
 //CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-us");

int chutiya = int.Parse("27");
DateTime birthday = DateTime.Parse("4 June 1980");
WriteLine($"I have {chutiya} friends to invite to my party.");
WriteLine($"My birthday is {birthday}");
WriteLine($"My birthday is {birthday:D}");
#endregion