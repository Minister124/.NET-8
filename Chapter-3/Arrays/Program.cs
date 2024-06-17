#region Working with single dimension Arrays
string[] names;

names = new string[4];

names[0] = "Motey";
names[1] = "Pataley";
names[2] = "Chindey";
names[3] = "Aagley";

for (int i = 0; i < 4; i++) {
    WriteLine($"{names[i]} is at a Index {i}");
}
#endregion

#region Working with multi-dimension Arrays
string[,] grid = {
    {"Khatey", "Hatti", "Chor", "Gadha"},
    {"Motey", "Patley", "Lukhurey", "Tori Laurey"},
    {"Maila", "Saila", "Kaila", "Antarey"}
};

WriteLine($"1st dimension, lower bound: {grid.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bound: {grid.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bound: {grid.GetUpperBound(1)}");

for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 4; col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid[row, col]}");
    }
}

//Alternative syntax for declarng and allocating memory
//for a multi-dimensional array.
string[,] grid2 = new string[3, 4];
grid2[0,0] = "Kutta";
grid2[0,1] = "Gadha";
grid2[2,2] = "Yolo";

#endregion

#region Working with Jagged Arrays
string[][] jagged =
{
    new[]{"Khatey", "Chor", "Kukur",},
    new[]{"Maila", "Saila", "Kaila", "Antarey", "Jantarey", "Lakhantarey"},
    new[]{"Bau", "Xora", "Aamai", "Dajai"}
};
WriteLine("Upper bound of the array of arrays is: {0}", jagged.GetUpperBound(0));

for(int arr = 0; arr <= jagged.GetUpperBound(0); arr++){
    WriteLine("Upper bound of array {0} is {1}", 
    arg0: arr, 
    arg1: jagged[arr].GetUpperBound(0));
}

for(int row = 0; row <= jagged.GetUpperBound(0); row++){
    for(int col = 0; col <= jagged[row].GetUpperBound(0); col++){
        WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
    }
}
#endregion

#region List Pattern Matching with arrays
int[] sequentialNumbers = {1,2,3,4,5, 6, 7, 8, 9, 10};
int[] oneTwoNumbers = {1, 2};
int[] oneTwoTenNumbers = {1, 2, 3, 10};
int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] emptyNumbers = { }; // Or use Array.Empty<int>()
int[] threeNumbers = { 9, 7, 5 };
int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };

static string CheckArray(int[] values) => values switch
{
    [] => "Empty Array",
    [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
    [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
    [1, 2] => "Contains 1 then 2.",
    [int item1, int item2, int item3] => $"Has {item1} then {item2} and {item3}",
    [0, _] => "Starts with 0, the one any other number",
    [0, ..] => "Starts With 0, then any range of numbers",
    [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers",
    [..] => "Any items in any order",
};

WriteLine($"{nameof(sequentialNumbers)}: {CheckArray(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckArray(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckArray(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckArray(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckArray(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckArray(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckArray(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckArray(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckArray(sixNumbers)}");
#endregion