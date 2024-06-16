#region if-else Statements
string password = "Demon";

if(password.Length < 8){
    WriteLine("Your password is too short. Use atleast 8 chars.");
}
else{
    WriteLine("Your password is strong.");
}
#endregion

#region Pattern Matching with if statement

object o = 56;
int j = 4;

if (o is int i){
    WriteLine($"{i}*{j} = {i + j}");
}else{
    WriteLine("o is not and int so it cannot multiply");
}
#endregion


#region Branching with the switch statement
//Inclusive Lower Bound but exclusive upper bound.
int number = Random.Shared.Next(minValue:1, maxValue:6);
WriteLine($"My Random Number is {number}");

switch (number){
    case 1:
        WriteLine("one");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // Multiple case section
    case 4:
        WriteLine("Three or Four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
} //END OF SWITCH Statement.
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");
#endregion

#region Pattern Matching with the switch statement

#endregion