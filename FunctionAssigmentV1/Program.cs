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
        

        

        static void Main(string[] args)
        {
          
            string name = AskName();
            int age = AskAge();

            // Ask for name and ensure it is not empty
          
            // Ask for age and ensure it is a positive integer
           

            // Print name and age
            Console.WriteLine($"Your name is {name} and your age is {age}.");

            // Check if the user is an adult
            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");

            // Compare the name to another string (e.g., "Matti")
            string compareName = "Matti";

            // Comparison ignoring case
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }
    }
}