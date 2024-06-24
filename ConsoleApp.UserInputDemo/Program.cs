// Declare Variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;

// Prompt the user for input
Console.WriteLine("please enter your name");
name = Console.ReadLine(); //this will allocate the name to the variable at the top overriding the empty string

Console.WriteLine("please enter your age");
age = Convert.ToInt32(Console.ReadLine()); //this will allocate the age to the variable at the top overriding the 0

// Process the data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working Years Remaining: {workingYearsRemaining}");

