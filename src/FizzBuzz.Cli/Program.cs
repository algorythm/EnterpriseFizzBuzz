using System;
using FizzBuzz.Library.Model;

namespace FizzBuzz.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzer = new FizzBuzzModel();
            Console.WriteLine("Please enter an integer value greater than 0.");

            while (fizzer.Value <= 0)
            {
                Console.Write("Number> ");
                string userInput = Console.ReadLine();

                int.TryParse(userInput, out var inputAsInt);
                fizzer.Value = inputAsInt;
            }

            Console.WriteLine($"FB Algorithm resulted in {fizzer.Result}");
        }
    }
}
