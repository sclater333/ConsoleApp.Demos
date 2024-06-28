//Simple For Loop Demo
//Print Hello World 10 times
//less than ten because it starts at 0 : 0 1 2 3 4 5 6 7 8 9

for (int i = 0; 
    i < 10; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("Loop Completed");

// Ask user how many times they wish to print hello world and print accordingly 

//Console.WriteLine("How many times should we print hello world?");
//int UserCount = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < UserCount; i++)
//{
//    Console.WriteLine($"Hello, World! - {i}"); 
//}


// While Loop
Console.WriteLine("*** While Loop *****");

int counter = 0;
while(counter < 10)
{
    Console.WriteLine($"Hello, World! - {counter}");
    counter +=2; // this will increment counter
}

// Ask the user for a number and find the total for each number that is entered. Print the final sum when the user enters -1 to exit. 

int sum = 0;
int num = 0;
while (num != -1)
{
    Console.WriteLine("Please enter a numbers to be summed (-1 to exit): ");
    num += Convert.ToInt32(Console.ReadLine());
    //nested if statement
    if (num != -1)
    { 
    sum += num;
     }
 }

Console.WriteLine($"Total is {sum}");

// Do while loop - does everything in {} before it checks the condition

Console.WriteLine("************* do while loop **********************");

int sum2 = 0;
int num2 = 0;
do
{
    Console.WriteLine("Please enter a numbers to be summed (-1 to exit): ");
    num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 != -1)
    {
        sum2 += num2;
    }
} while (num2 != -1);


Console.WriteLine($"Total is {sum2}");
Console.WriteLine("************* do while loop completed **********************");

