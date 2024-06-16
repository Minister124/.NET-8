#region Looping with while statement
int x = 0;
while (x < 10){
    WriteLine(x);
    x++;
};
#endregion

//#region Looping with do Statement
string? actualPassword = "Password";
string? password;

do{
    Write("Enter your password: ");
    password = ReadLine();
}
while(password != actualPassword);
WriteLine("Correct!");
#endregion

#region Looping with for statement
for (int y = 0; y < 10; y++){
    WriteLine("y");
}
for (int y = 0; y <= 10; y += 3){
    WriteLine("y");
}
#endregion 

#region Looping with foreach statement
string[] names = {"Adam", "Chindey", "Motey"};
foreach (string name in names){
    WriteLine($"{name} has {name.Length} characters.");
}
#endregion