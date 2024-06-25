// Declare Variables
string? firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working = true;

// Prompt the user for input
Console.Write("please enter your first name: ");
firstName = Console.ReadLine(); //this will allocate the name to the variable at the top overriding the empty string

Console.Write("please enter your last name: ");
lastName = Console.ReadLine(); //this will allocate the name to the variable at the top overriding the empty string

Console.Write("please enter your age: ");
age = Convert.ToInt32(Console.ReadLine()); //this will allocate the age to the variable at the top overriding the 0

Console.Write("please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine()); //

Console.Write("please enter your gender (M or F): " );
gender = Convert.ToChar(Console.ReadLine()); //

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine()); //

// Process the data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"You Are Employed: {working}");
Console.WriteLine($"Working Years Remaining: {workingYearsRemaining}");

