using System;

namespace Kata
{
    public class AverageString
    {
        public static string[] _dictionary = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        public string Average(string input)
        {
            if (!ValidateInput(input)) return "n/a";
            string[] numberArray = input.Split(" ");
            if (!TryGetAverage(numberArray, out var averageNum)) return "n/a";
            return _dictionary[averageNum / numberArray.Length];
        }

        private static bool ValidateInput(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            return true;
        }

        private bool TryGetAverage(string[] numberArray, out int averageNum)
        {
            averageNum = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (!TryConvertToNumber(numberArray[i], out var number))
                {
                    return false;
                }

                averageNum += number;
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