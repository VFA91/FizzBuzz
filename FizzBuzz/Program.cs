using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        private const int LIMIT = 100;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        private void Start()
        {
            Console.WriteLine("Programa FizzBuzz");

            StringBuilder result = new StringBuilder();
            result = PrintNumbers(result);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        private StringBuilder PrintNumbers(StringBuilder result)
        {
            for (int i = 1; i <= LIMIT; i++)
            {
                result.Append(GetNumberOrString(i) + ",");
            }

            FormatResult(result);
            return result;
        }

        private void FormatResult(StringBuilder result)
        {
            result.Remove(result.Length - 1, 1);
        }

        private string GetNumberOrString(int number)
        {
            if (IsMultiple(number, 3) && IsMultiple(number, 5))
                return "Fizz Buzz";
            else if (IsMultiple(number, 5))
                return "Buzz";
            else if (IsMultiple(number, 3))
                return "Fizz";
            else
                return number.ToString();
        }

        private bool IsMultiple(int number, int baseNumber)
        {
            return number % baseNumber  == 0;
        }
    }
}
