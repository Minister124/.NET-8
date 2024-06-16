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

for (int row = 0; row <= grid.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid[row, col]}");
    }
}

#endregion