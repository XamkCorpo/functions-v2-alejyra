using System.Xml.Linq;

namespace FunctionAssigmentV1
{

    internal class Program
    {
        static string AskName()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Name cannot be empty.");
            }
        }

       static int AskAge()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int age) && age > 0)
                    return age;

                    Console.WriteLine("Please enter a positive integer.");
            }
        }
      
        static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
       
        static bool CheckOfAge(int age)
        {
            return age >= 18;
        }

        static void CompareName(string name, string CompareTo)
        {
            //case-insensitive
            if (name.Equals(CompareTo, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Your name matches '{CompareTo}' (case-insensitive).");

            // case-sensitive
            if (name.Equals(CompareTo))
                Console.WriteLine($"Your name is exactly '{CompareTo}' (case-sensitive).");
        }

        static void Main(string[] args)
        {
          
            string name = AskName();
            int age = AskAge();

            PrintNameAndAge(name, age);
            bool isFullAge = CheckOfAge(age);
            
            if (isFullAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }

                
            
        }
    }
}