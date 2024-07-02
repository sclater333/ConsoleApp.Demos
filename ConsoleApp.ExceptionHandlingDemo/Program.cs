// Write a program that takes a user's age as input and prints it to the screen.
// Display an error message if an invalid input 

//this is how to "handle" an exception. 

try
{
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You are {age} years old. ");
}
catch (Exception)
{
    Console.WriteLine("Your age value was incorrect, please try again. ");
    //throw;
}
finally // do this regardless of exception 
{
    Console.WriteLine("****** - Thank you for using the program**");
}
