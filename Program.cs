/************** Simple calculator ***************
Simple calculator to test my C# knowledge so far
***********************************************/

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

    double result;


    if (userOperator == "+")
    {
        double sum = firstNumber + secondNumber;
        DefaultMessage(); // to be fixed with the DefaultMessage method
    }

    else if (userOperator == "-")
    {
        double difference = firstNumber - secondNumber;
        Console.WriteLine($"The result is: {difference}");
    }

    else if (userOperator == "*")
    {
        double multiply = firstNumber * secondNumber;
        Console.WriteLine($"The result is: {multiply}");
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
            double dividend = firstNumber / secondNumber;
            Console.WriteLine($"The result is: {dividend}");
        }
    }
    Console.WriteLine("Press [R] to restart or [F] to finish");
    string? input = Console.ReadLine();

    if (input == "R" || input == "r")
    {
        RunCalculator();
    }

    else
    {
        return;
    }
}

// Method to fix 
void DefaultMessage(string message)
{
    Console.WriteLine($@"{message}");
}