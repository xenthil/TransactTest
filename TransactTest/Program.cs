using System;

namespace TransactTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int low;
            int high;
            int a;
            int b;

            GetIntegerInput(out low);
            GetIntegerInput(out high);
            GetIntegerInput(out a);
            GetIntegerInput(out b);

            var numbers = new Numbers(low, high, a, b);
            var output = numbers.GetOutput();

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static void GetIntegerInput(out int number)
        {
            Console.WriteLine("Enter a positive number: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out number) || number < 0)
            {
                Console.WriteLine("Invalid input");
                GetIntegerInput(out number);
            }
        }
    }
}
