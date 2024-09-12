
using System.Security.Cryptography;

Console.WriteLine("***************** - Lists - *****************");


// Declare a List
List<int> grades = new List<int>();// means I don't have a size, but will create size
// var grades = new List<int> (); is another way to write the above
//List<int> grades = new(); 3rd way of writing this
List<string> students = new List<string>();
int grade = 0;
string name;
int @continue; // if you really want to use a key word that is a variable for you, you can override it with the @ symbol 
int gradeCount = 0;


// Add values to a list
//grades.Add(45);
//grades.Add(90);
//Console.WriteLine(grades[0]);
//Console.WriteLine(grades[1]); // this needs to match the count above

do
{
    gradeCount += 1;
    Console.Write("Enter Student Name: ");
    name = Console.ReadLine();
    students.Add(name);

    Console.Write("Enter Grade: ");
    grade = Convert.ToInt32(Console.ReadLine());

   

    if(grade != -1)
    {
        grades.Add(grade);
    }
    Console.Write("Do you wish to continue? (1 = yes | 2 = no): ");
    @continue = Convert.ToInt32(Console.ReadLine());
} while (@continue == 1);

// Print values in list - for

Console.WriteLine("Printing grades via a for loop");
for(int i = 0; i < grades.Count; i++)
{
    Console.WriteLine(grades[i]);
}

// Print values in list - foreach
Console.WriteLine("Printing grades via a foreach loop");
Console.WriteLine("The Grades you have entered are: ");
//foreach (int g in grades)
//{
    // Console.WriteLine(g);
    
    for (int i = 0; i < gradeCount; i++)
    {
        Console.WriteLine($"{students[i]}: {grades[i]}");

    }

//}


