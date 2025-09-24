using System.Transactions;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChooseEquation();
            GetNumber1();
            GetNumber2();
        }

        /// <summary>
        /// Lets the user choose an Equation
        /// </summary>
        /// <returns>Returns a valid input</returns>
        static int ChooseEquation()
        {
            Console.WriteLine("Choose an operation");
            Console.WriteLine("1: addition");
            Console.WriteLine("2: substraction");
            Console.WriteLine("3: multiplication");
            Console.WriteLine("4: division");

            while (true)
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int Operation) && Operation > 0 && Operation <= 4)
                    return Operation;
                else
                    Console.WriteLine("Choose a number between 1 - 4");
            }


        }

        /// <summary>
        /// User enters the first number for the equation 
        /// </summary>
        /// <returns>Returns a valid decimal number</returns>
        static decimal GetNumber1()
        {
            Console.WriteLine("Enter the first number");
            while (true)
            {
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal Num1))
                    return Num1;

                Console.WriteLine("Please enter a number");
            }

        }

        /// <summary>
        /// User enters the second number for the equation
        /// </summary>
        /// <returns>Returns a valid decimal number</returns>
        static decimal GetNumber2()
        {
            Console.WriteLine("Enter the second number");
            while (true)
            {
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal Num2))
                    return Num2;

                Console.WriteLine("Please enter a number");
            }
        }


    }


}
