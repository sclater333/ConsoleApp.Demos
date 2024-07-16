
using System;

Console.WriteLine("****** - String manipulation - *******");

// Initialize witha  regular string literal
string s1 = "This is a literal string"; // when a developer types the string
String s2 = "This is a literal string"; //same behaviour but lower case more readable
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(s2)}: {s2}");

// Declare without initializing. (possible null exception)
string s3; // must initialize to be able to Console.Writeline

// Initialize to null. (possible null exception)
string? s4 = null; //tells program that this is nullable (?) 
Console.WriteLine($"{nameof(s4)}: {s4}");

// Initialize as an empty string.
string s5 = string.Empty; // " " - this is a safer option 
string s6 = " "; // this might skip over checking errors
Console.WriteLine($"{nameof(s5)}: {s5}");
Console.WriteLine($"{nameof(s6)}: {s6}");

// Escape sequences and characters
// She said, "I have your phone"
string sentence = "She said, \"I have your phone\" \r\n This is the next line ";
Console.WriteLine($"{nameof(sentence)}: {sentence}");

// Verbatim string literal.
string oldPath = "C:\\program files\\programfolder\\";
string newPath = @"C:\program files\programfolder\";
Console.WriteLine($"{nameof(oldPath)}: {oldPath}");
Console.WriteLine($"{nameof(newPath)}: {newPath}");

// Use a const string to prevent modification to a string
const string path = "C:\\program files\\programfolder\\";
Console.WriteLine($"{nameof(path)}: {path}");

//path = "new value"; //illegal operation against a constant - you cannot modify a const - constant 
s1 = "A new string";
Console.WriteLine($"{nameof(s1)}: {s1}");

// Raw string literals
string rawLiteral = """ She said, "I have your phone" """; //uses """ to work (must be used on one line)
string rawLiteral1 = """ 
She said, "I have your phone" 
nextline
next line
"""; //uses """ to work 
Console.WriteLine($"{nameof(rawLiteral)}: {rawLiteral}");
Console.WriteLine($"{nameof(rawLiteral1)}: {rawLiteral1}");

// Review concatenation and interpolation
s1 = s1 + s2;
s1 += s2;
string newString = $"{s1} {s2} Some random literal text ";
string newString1 = s1 + "${s1} {s2} Some random literal text ";
string newString2 = String.Format("Literal string {0} {1}", s1, s2);
Console.WriteLine($"{nameof(newString)}: {newString}");
Console.WriteLine($"{nameof(newString1)}: {newString1}");
Console.WriteLine($"{nameof(newString2)}: {newString2}");


/* String manipulation methods and properties. Sometimes it is just assessment */

// Null or empty checks
// find the length of a string

Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
//Console.WriteLine($"{nameof(s3)} has a length of {s3.Length}");
Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}"); //will have a null reference exception 
Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");


//if(string.IsNullOrEmpty(s4)) == false)
if (!string.IsNullOrEmpty(s4)) //! here means "not"
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
}

if (string.IsNullOrEmpty(s5) == false)
{
    Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
}

// Substrings
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)}: {subString}");
subString = s1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)}: {subString}");

// Splitting strings
var splitStrings = s2.Split(' '); //this will split by the space character
for (int i = 0; i < splitStrings.Length; i++) //length here is the count in the array (collection) ie.e count of spaces
{
    Console.WriteLine($"{splitStrings[i]}");
}

// Replace
string replacements1 = s1.Replace('s', 'V');
Console.WriteLine($"{nameof(replacements1)} : {replacements1}");

string replacements2 = s1.Replace("string", "chicken");
Console.WriteLine($"{nameof(replacements2)} : {replacements2}");

// Convert to string
string salary = 238432934234.02.ToString(); //this converts to string
int value = 323423423;
string strvalue = value.ToString(); // second way to convert
bool chosen = true;
chosen.ToString(); //convert bool to string

// Changing Formatting
Console.WriteLine($"{nameof(salary)} : {salary}"); // this shows as a string
//change this to currency
Console.WriteLine($"{nameof(salary)} : {salary:C}"); //C means currency
Console.WriteLine(nameof(salary) + ":" + value.ToString("C"));

