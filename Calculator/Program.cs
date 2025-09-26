namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation = ChooseEquation();
            decimal Num1 = GetNumber1();
            decimal Num2 = GetNumber2();
            decimal result = 0;

            switch (operation)
            {
                case 1:
                    result = Addition(Num1, Num2);
                    
                    break;
                case 2:
                    result = Substraction(Num1, Num2);
                    
                    break;
                case 3:
                    result = Multiplication(Num1, Num2);
                    
                    break;
                case 4:
                    if (Num2 == 0)
                        Console.WriteLine("You cannot divide by zero");
                    else
                    {
                        result = Division(Num1, Num2);
                        
                    }
                    break;
            }

           PrintResult(result);
        }

        /// <summary>
        /// Lets the user choose an Equation
        /// </summary>
        /// <returns>Returns a valid input</returns>
        static int ChooseEquation()
        {
            Console.WriteLine("Choose an operation");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Substraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");

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
                if (decimal.TryParse(input, out decimal Number1))
                    return Number1;

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
                if (decimal.TryParse(input, out decimal Number2))
                    return Number2;

                Console.WriteLine("Please enter a number");
            }
        }

        /// <summary>
        /// Performs the addition of two numbers
        /// </summary>
        /// <param name="Num1"></param>
        /// <param name="Num2"></param>
        /// <returns>Returns the sum the two numbers</returns>

        static decimal Addition(decimal Num1, decimal Num2)
        {
            return Num1 + Num2;
        }

        /// <summary>
        /// Performs the substraction of two numbers
        /// </summary>
        /// <param name="Num1"></param>
        /// <param name="Num2"></param>
        /// <returns>Returns the difference of the two numbers</returns>

        static decimal Substraction(decimal Num1, decimal Num2)
        {
            return Num1 - Num2;
        }

        /// <summary>
        /// Performs the multiplication of two numbers
        /// </summary>
        /// <param name="Num1"></param>
        /// <param name="Num2"></param>
        /// <returns>Returns the product of the two numbers</returns>

        static decimal Multiplication(decimal Num1, decimal Num2)
        {
            return Num1 * Num2;
        }

        /// <summary>
        /// Performs the division of two numbers
        /// </summary>
        /// <param name="Num1"></param>
        /// <param name="Num2"></param>
        /// <returns>Returns the quotient of the two numbers</returns>

        static decimal Division(decimal Num1, decimal Num2)
        {
            return Num1 / Num2;
        }

        /// <summary>
        /// Prints the result to the console
        /// </summary>
        /// <param name="result"></param>

        static void PrintResult(decimal result)
        {
            Console.WriteLine($"The result: {result}");
        }
    }


}
