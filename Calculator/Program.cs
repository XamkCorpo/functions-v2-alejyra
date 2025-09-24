namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChooseOperation();
        }

        static int ChooseOperation()
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

    }


}
