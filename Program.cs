// /************** Simple calculator ***************
// Simple calculator to test my C# knowledge so far
// ***********************************************/

RunCalculator();
void RunCalculator()
{
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

    double result = 0;

    if (userOperator == "+")
    {
        result = firstNumber + secondNumber;
        DefaultMessage(firstNumber, secondNumber, userOperator, result);
    }

    else if (userOperator == "-")
    {
        result = firstNumber - secondNumber;
        DefaultMessage(firstNumber, secondNumber, userOperator, result);
    }

    else if (userOperator == "*")
    {
        result = firstNumber * secondNumber;
        DefaultMessage(firstNumber, secondNumber, userOperator, result);

    }

    else if (userOperator == "/")
    {
        if (firstNumber == 0 || secondNumber == 0)
        {
            Console.WriteLine("Zero is not a valid number.");
            return;
        }
        else
        {
            result = firstNumber / secondNumber;
            DefaultMessage(firstNumber, secondNumber, userOperator, result);
        }
    }
    else
    {
        Console.WriteLine("Invalid operation!");
        RunCalculator();
    }

    Console.WriteLine("Press [R] to restart or [F] to finish");
    string? input = Console.ReadLine();

    if (input?.ToLower() == "r") 
    {
        RunCalculator();
    }

    else
    {
        return;
    }
}

void DefaultMessage(double firstNumber, double secondNumber, string userOperator, double result)
{
    Console.WriteLine($"{firstNumber} {userOperator} {secondNumber} is {result}");
}
