// Welcome Message
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Welcome to the sample calculator!");

//Prompt for user input
Console.WriteLine("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calculor options / Show menu
Console.WriteLine("Please select an operation (-1 to exit) ");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Fibonacci sequence");
int choice = Convert.ToInt32(Console.ReadLine());

while (choice != -1)
{
    int answer = 0;

    switch (choice)
    {
        case 1:
            // do addition
            answer = num1 + num2;
            break;
        case 2:
            // do subtraction
            answer = num1 - num2;
            break;
        case 3:
            // do multiplication
            answer = num1 * num2;
            break;
        case 4:
            // do division
            answer = num1 / num2;
            break;
        case 5:
            // do fibonacci
            for (int i = num1; i <= num2; i++) // eg. add every number between num1 & num2
            {
                answer += i;
            }
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;

    }

    // print output
    Console.WriteLine($"The result is: {answer}");
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
    Console.Clear(); // allows you to clear everything on the screen
    Console.WriteLine("Please select an operation (-1 to exit program) ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Muliplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
    choice = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("Thank you for using the sample calculator");



// Decide which operation is needed based on selected option
//if (choice == 1)
//{
//    // do addition
//}
//else if (choice == 2)
//{
//    // do subtraction
//}
//else if (choice == 3)
//{
//    // do multiplication
//}
//else if (choice == 4)
//{
//    // do division
//}
//else
//{
//    Console.WriteLine("Invalid choice");
//}


// switch statement


