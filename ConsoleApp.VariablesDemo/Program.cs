// See https://aka.ms/new-console-template for more information

//Different datatypes
/*
    text - string
    integers - ing
    decimal - double, float, decimal
    logical - bool
 */

string name = "Tamara";

Console.WriteLine(name);
Console.WriteLine("Hello I am" + name); // String concatenation
Console.WriteLine($"Test My name is {name}"); //String interpolation
Console.WriteLine("Lastly, World! My name is {0}", name); // Formatted string

int age = 54;
int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);