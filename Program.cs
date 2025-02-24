using System;

//namespace
namespace BasicCalculator{
    //class 
    class Program{

        //main method
        static void Main(string[] args){

            //Entering the first number
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            //Entering the second number
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Entering the operation symbol
            Console.WriteLine("Choose the Correct operation : + , - , * , /  ");
            string operationSymbol = Console.ReadLine();

            // intializing the result as zero
            double result = 0;

            //using try catch to catch the error
            try
            {
                // using the switch case to determine the arithmetic operation
                switch (operationSymbol)
                {
                    // case addition
                    case "+":
                        result = num1 + num2;
                        break;
                    // case substraction
                    case "-":
                        result = num1 - num2;
                        break;
                    // case multiplication
                    case "*":
                        result = num1 * num2;
                        break;
                    //case division
                    case "/":
                        //handling the case dividing with zero 
                        if (num2 == 0)
                        {
                            // if the denominator is zero throw the message
                            throw new DivideByZeroException("Cannot divide by zero.");
                        }
                        //if num2!= 0 then do the division
                        result = num1 / num2;
                        break;
                    // default case for selecting other operation
                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                //returning the result 
                Console.WriteLine($"The result of {num1} {operationSymbol} {num2} is: {result}");
            }
            //catching the error 
            catch (DivideByZeroException ex)
            {
                //prints the dividebyzero execption message
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                //default execption message
                Console.WriteLine("An error occurred: " + ex.Message);
            }


        }
    }
}
