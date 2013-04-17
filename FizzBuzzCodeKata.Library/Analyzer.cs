using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzzCodeKata.Library
{
    public class Analyzer
    {
        public string Analyze(int number)
        {
            if (IsMultipleOfThree(number) && IsMultipleOfFive(number))            
                return "FizzBuzz";            
            if (IsMultipleOfThree(number))            
                return "Fizz";            
            if (IsMultipleOfFive(number))            
                return "Buzz";            
            return number.ToString(CultureInfo.InvariantCulture);
        }

        private static bool IsMultipleOfFive(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsMultipleOfThree(int number)
        {
            return number % 3 == 0;
        }

        public string GetCompleteList()
        {
            var sb = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                sb.Append(Analyze(i));
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
