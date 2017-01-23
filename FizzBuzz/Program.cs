using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        private const int NUMBEROFNUMBERS = 100;

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
            for (int i = 1; i <= NUMBEROFNUMBERS; i++)
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
            if (IsMultipleOfFiveAndThree(number))
                return "Fizz Buzz";
            else if (IsMultipleOfFive(number))
                return "Buzz";
            else if (IsMultipleOfThree(number))
                return "Fizz";
            else
                return number.ToString();
        }

        private bool IsMultipleOfThree(int number)
        {
            return number % 3 == 0;
        }

        private bool IsMultipleOfFive(int number)
        {
            return number % 5 == 0;
        }

        private bool IsMultipleOfFiveAndThree(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }
    }
}
