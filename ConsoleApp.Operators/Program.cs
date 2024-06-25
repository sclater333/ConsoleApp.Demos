
//You can write it this way
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

//Or you can write it this way
int num2 = 0;
Console.Write("Please enter the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);


/*
 Math Operations and operators
 */
//Add numbers
int sum = num1 + num2; 
//Multiply
int product = num1 * num2;
//Division
int quotient = num1 / num2;
//Subtraction
int difference = num1 - num2;
//Modulus
int mod = num1 % num2;

Console.WriteLine("**********Math Results*************");
Console.WriteLine(); //gives space
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("**********End Math Results*************");

/*
 Logic Operations and operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqual = num1 >= num2;
bool isLessThanOrEqual = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("**********Logic Results*************");
Console.WriteLine(); //gives space
Console.WriteLine($"is Greater Than: {isGreaterThan}");
Console.WriteLine($"is Less Than: {isLessThan}");
Console.WriteLine($"is Equal To: {isEqualTo}");
Console.WriteLine($"is Greater Than Or Equal: {isGreaterThanOrEqual}");
Console.WriteLine($"is Less Than Or Equal: {isLessThanOrEqual}");
Console.WriteLine($"is Not Equal: {isNotEqual}");
Console.WriteLine("********** End Logic Results*************");

/*
 Assignment Operations and operators
 */

Console.WriteLine("Enter Random Number for assignment operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());
//int increaseValue = num1 + 5;

//num1 = num1 + 5; // long way

Console.WriteLine("**********Assignment Results*************");
Console.WriteLine(); //gives space
num1 += randomValue; //short way
Console.WriteLine($"Num 1 increased by {randomValue}: {num1}");
num1 -= randomValue;
Console.WriteLine($"Num 1 reduced by {randomValue}: {num1}");
num1 /= randomValue;
Console.WriteLine($"Num 1 divided by {randomValue}: {num1}");
num1 %= randomValue;
Console.WriteLine($"Num 1 mod by {randomValue}: {num1}");
num1 *= randomValue;
Console.WriteLine($"Num 1 multipled by {randomValue}: {num1}");
Console.WriteLine(); //gives space
Console.WriteLine("********** End Assignment Results*************");