using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // Entering the first number
                    Console.WriteLine("Enter the first number:");
                    double num1 = GetValidNumber();

                    // Entering the second number
                    Console.WriteLine("Enter the second number:");
                    double num2 = GetValidNumber();

                    // Entering the operation symbol
                    Console.WriteLine("Choose the correct operation: +, -, *, /");
                    string operationSymbol = Console.ReadLine();

                    // Initializing the result as zero
                    double result = 0;

                    // Using the switch case to determine the arithmetic operation
                    switch (operationSymbol)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                throw new DivideByZeroException("Cannot divide by zero.");
                            }
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Invalid operation.");
                            continue;
                    }

                    // Returning the result
                    Console.WriteLine($"The result of {num1} {operationSymbol} {num2} is: {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                // Asking the user if they want to perform another calculation
                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                string continueCalculation = Console.ReadLine().ToLower();
                if (continueCalculation != "yes")
                {
                    break;
                }
            }
        }
        
        //Getting the valid Number input from the user
        static double GetValidNumber()
        {
            while (true)
            {
                try
                {
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }
            }
        }
    }
}
