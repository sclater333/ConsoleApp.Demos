// Welcome Message
using System;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Welcome to the sample calculator!");

// Variable Declarations
int choice = 0;
int num1, num2 = 0;

// Show calculor options / Show menu
while (choice != -1)
{
    try // using one big try catch
    {
        Console.WriteLine("Please select an operation (-1 to exit) ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci sequence");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

           //Prompt for user input
            Console.WriteLine("Please enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
       
        //switch statement
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
            throw new Exception("Invalid menu item selected.");
               

        }
        // print output
        Console.WriteLine($"The result is: {answer}");
    } 
    catch (DivideByZeroException) //this is how to catch a divide by zero
    {
        Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message); //this is the exception message from above "ex"
    }
    finally
    {
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
        Console.Clear();
    }
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


