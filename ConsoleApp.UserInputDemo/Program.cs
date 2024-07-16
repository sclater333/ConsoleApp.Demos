// Declare Variables
const int retirementAge = 65;

string? firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
DateOnly dob = new DateOnly();
decimal salary = 0;
char gender = char.MinValue;
bool working = true;

// Prompt the user for input
Console.Write("please enter your first name: ");
firstName = Console.ReadLine(); //this will allocate the name to the variable at the top overriding the empty string

Console.Write("please enter your last name: ");
lastName = Console.ReadLine(); //this will allocate the name to the variable at the top overriding the empty string

Console.Write("please enter your date of birth (dd/mm/yyyy): ");
dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
age = DateTime.Now.Year - dob.Year; //calc current age instead of a constant entry

Console.Write("please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine()); //

Console.Write("please enter your gender (M or F): " );
gender = Convert.ToChar(Console.ReadLine()); //

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine()); //

// Process the data
int workingYearsRemaining = retirementAge - age;
var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary.ToString("C")}"); // Changes to String
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"You Are Employed: {working}");
Console.WriteLine($"Working Years Remaining: {workingYearsRemaining}");
Console.WriteLine($"Estimated Retirement year: {estimatedRetirementDate.Year}");

