using SelectionStatements;

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
var animals = new Animal?[]{
    new Cat {Name = "Karen", Born = new(year: 2022, month: 8, day: 23), Legs = 4, IsDomestic = true},
    null,
    new Cat {Name = "Mufasa", Born = new(year:1994, month: 8, day:12), IsDomestic = true},
    new Spider {Name = "Sid Vicious", Born=DateTime.Today, IsPoisonous=true},
    new Spider {Name = "Captain Furry", Born = DateTime.Today}
};

foreach (Animal? animal in animals){
    string message;
    switch(animal){
        case Cat {Legs: 4} fourLeggedCat:
            message = $"The cat Named {fourLeggedCat.Name} has four legs";
            break;
        case Cat {IsDomestic: true} wildCat:
            message = $"The non-domestic cat is named {wildCat.Name}.";
            break;
        case Cat cat:
            message = $"The cat is named {cat.Name}.";
            break;
        default: //default is always evaluated Last.
            message = $"{animal.Name} is a {animal.GetType().Name}.";
            break;
        case Spider spider when spider.IsPoisonous:
            message = $"The {spider.Name} spider is poisonous. Run!";
            break;
        case null:
            message = "The animal is null.";
            break;
    }
    WriteLine($"switch statement: {message}");
}
#endregion