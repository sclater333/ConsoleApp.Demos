
Console.Write("Please enter student's grade: ");
// Global variable / global scope
int grade = Convert.ToInt32(Console.ReadLine());

//Decide to print pass or fail based on input
if(grade > 50)
{
    Console.WriteLine("Student has passed");

}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recommend student to " +
        "student affair's office");
}
Console.WriteLine("Thank you for using this program");

/*
 * A: 86 - 100 
 * B: 75 - 84
 * C: 65 - 74
 * C-: 50 - 64
 * F: LESS THAN 50 X
 */


if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value");
  
}
else if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if (grade >= 50 && grade <= 64)
  
{
    Console.WriteLine("C-");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A");
}
else
{
    Console.WriteLine("Invalid value");
}
int gradeAfterBonus = grade >= 0 && grade <= 100 ? grade + 10 : 0; //Ternary operator
Console.WriteLine($"Grade after bonus: {gradeAfterBonus}");

    Console.WriteLine("Thank you for using this program");

// Ternary operator - Used to assign a vlaue to a variable based on a condition
Console.WriteLine("**Ternary Operator results**");

string passStatus = grade < 50 ? "Fail" : "Pass"; 
Console.WriteLine($"Student Status is: {passStatus}");

// Switch statements - used to evaluate a value and take an action
Console.WriteLine("**Switch Statement Results**");
/*
 * Write a program to accept an integer as the day of the week and print the appropriate message as outlined below.
 * 1 - Sunday
 * 2- Monday
 * 3 - Tuesday
 * 4 - Wednesday (Hump Day)!
 * 5 - Thursday
 * 6 - Friday (TGIF!!!)
 * 7 - Saturday
 */

Console.WriteLine("Please enter the day of the week: ");

int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        Console.WriteLine("(Hump Day!)");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        Console.WriteLine("(TGIF!!!)");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("invalid day entered!");
        break;
}