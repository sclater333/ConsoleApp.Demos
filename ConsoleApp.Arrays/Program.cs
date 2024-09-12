

using System;

Console.WriteLine("******* - Arrays - ********");

// Tell me how many students and grades are to be entered
Console.Write("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

// Declare Fixed Size Array
//int[] grades = new int[5];         //square means array & says that there are 5 places
// 5 space addresses/indexes - 0, 1, 2 ,3 ,4
//If n is the size of the array, then your array has addresses between 0 to n-1
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];

// Add values to Fixed Size Array
//grades[0] = 45; // assigned 45 as value to first value
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;
//grades[5] = 65; can't assign, as this is outside the number of spaces declared for this array. 

for (int i = 0; i < numberOfGrades; i++) // this is a for loop where you can change the variable at link 7 (grades). This for loop allows you to enter multiple arrays.
{
    Console.Write("Enter Student Name: ");
    students[i] = Console.ReadLine();

    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());    
}

// Print values in Fixed Size Array

Console.WriteLine("The Grades you have entered are: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");

}

// Print values in list - foreach
foreach (int g in grades) // can only declare one array, unlike multiple arrays above
{
    Console.WriteLine(g); 
}

// Declare Variable Sized Array (instead of saying number of elements)
string[] studentNames = new string[] {"Newton", "Joshua", "etc... "}; // eg. here it will default to 3 spaces


// Add values to Variable Sized Array
for (int i = 0; i < studentNames.Length; i++) // this is a for loop where you can change the variable at link 7 (grades). 
{
    Console.Write("Enter Grade: ");
    studentNames[i] = Console.ReadLine();
}

// Print values in Variable Sized Array

Console.WriteLine("The Student Names you have entered are: ");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}

