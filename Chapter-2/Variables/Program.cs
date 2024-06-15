using System.Xml;
using Variables;

object height = 1.88; // storing a double in an object 
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");

//Storing Dynamic Type

// storing a string in a dynamic object
// string has a Length property
dynamic something = "Ahmed";
// int does not have a Length property
// something = 12;
// an array of any type has a Length property
// something = new[] { 3, 5, 7 };

// this compiles but would throw an exception at run-time
// if you later stored a data type that does not have a
// property named Length
Console.WriteLine($"Length is {something.Length}");

//Local Variable Type
var population = 67_000_000; // 67 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds sterling
var fruit = "Apples"; // strings use double-quotes
var letter = 'Z'; // chars use single-quotes
var happy = true; // Booleans have value of true or false

//Creating Some new Objects
// good use of var because it avoids the repeated type
// as shown in the more verbose second statement

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt"); 
StreamWriter file2 = File.CreateText("something2.txt"); //type is streamwriter

//using target-typed new to instantiate objects

XmlDocument xml3 = new(); // target-typed new in C# 9 or Later


Person kim = new(); // class person
kim.BirthDate = new(1967, 12, 26);

List<Person> people = new(){
    new() {FirstName = "Alice"},
    new() {FirstName = "Bob"},
    new(){FirstName = "Charlie"}
};

// Getting and Setting the default Values for types

Console.WriteLine($"default(int): {default(int)}");
Console.WriteLine($"default(bool): {default(bool)}");
Console.WriteLine($"default(decimal): {default(decimal)}");
Console.WriteLine($"default(DateTime): {default(DateTime)}");
Console.WriteLine($"default(string): {default(string)}");

int number = 7;
Console.WriteLine($"number has been set to: {number}");

number = default;
Console.WriteLine($"number has been set to default: {number}");
