using System;

namespace Kata
{
    public class AverageString
    {
        public static string[] _dictionary = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        public string Average(string input)
        {
            if (InvalidateInput(input)) return "n/a";
            string[] numberArray = input.Split(" ");
            if (!TryGetSum(numberArray, out var sumNum)) return "n/a";
            return _dictionary[sumNum / numberArray.Length];
        }

        private static bool InvalidateInput(string input)
        {
            return string.IsNullOrEmpty(input);
        }

        private bool TryGetSum(string[] numberArray, out int sumNum)
        {
            sumNum = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (!TryConvertToNumber(numberArray[i], out var number))
                {
                    return false;
                }

                sumNum += number;
            }

            return true;
        }

        public bool TryConvertToNumber(string numberString, out int number)
        {
            if (Array.IndexOf(_dictionary, numberString.ToLower()) < 0)
            {
                number = -1;
                return false;
            }

            number = Array.IndexOf(_dictionary, numberString.ToLower());
            return true;
        }
    }
}