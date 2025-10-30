/************** Simple calculator ***************
Simple calculator to test my C# knowledge so far
***********************************************/


Console.WriteLine("===============================================");
Console.WriteLine("============ WELCOME TO CALCULALLY ============");
Console.WriteLine("===============================================");

// User entries 

Console.WriteLine("Press any key to continue");
Console.ReadLine();

Console.WriteLine("Enter a number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the mathematical operation: +, -, *, /");
string? userOperator = Console.ReadLine();


// Calculator

double result;


if (userOperator == "+")
{
    result = firstNumber + secondNumber;
    Console.WriteLine($"The result is: {result}");
}

else if (userOperator == "-")
{
    result = firstNumber - secondNumber;
    Console.WriteLine($"The result is: {result}");
}

else if (userOperator == "*")
{
    result = firstNumber * secondNumber;
    Console.WriteLine($"The result is: {result}");

}

else if (userOperator == "/")
{
    if (firstNumber == 0 || secondNumber == 0)
    {
        Console.WriteLine("Zero is not a valid number.");
        return;
    }
    else
        result = firstNumber / secondNumber;
    Console.WriteLine($"The result is: {result}");
}