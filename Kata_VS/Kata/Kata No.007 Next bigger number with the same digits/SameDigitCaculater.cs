using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class SameDigitCaculater
    {
        public long GetBigNumber(long inputNum)
        {
            if (IsInValidInput(inputNum))
            {
                return -1;
            }

            var digitList = inputNum.ToString();
            for (int i = digitList.Length - 1; i > 0; i--)
            {
                if (digitList[i] > digitList[i - 1])
                {
                    var leftPart = digitList.Substring(0, i - 1);
                    var key = digitList[i - 1];
                    var rightPart = digitList.Substring(i);
                    GetNewKey(rightPart, key, out var newKeyIndex,out var newKey);
                    var newRightPart = GetNewRightPart(rightPart, newKeyIndex, key);
                    return SetAns(leftPart, newKey, newRightPart);
                }
            }
            return -1;
        }

        private static long SetAns(string leftPart, char newKey, List<char> newRightPart)
        {
            return Convert.ToInt64(leftPart + newKey + ConvertCharListToString(newRightPart));
        }

        private static string ConvertCharListToString(List<char> newRightPart)
        {
            return new string(newRightPart.ToArray());
        }

        private static List<char> GetNewRightPart(string rightPart, int newKeyIndex, char key)
        {
            var newRightPart = rightPart.ToList();
            newRightPart[newKeyIndex] = key;
            newRightPart.Sort();
            return newRightPart;
        }

        private static void GetNewKey(string rightPart, char key, out int newKeyIndex,out char newKey)
        {
            newKey = '9';
            newKeyIndex = 0;
            for (int j = 0; j < rightPart.Length; j++)
            {
                if (rightPart[j] > key && rightPart[j] <= newKey)
                {
                    newKey = rightPart[j];
                    newKeyIndex = j;
                }
            }
        }

        private static bool IsInValidInput(long inputNum)
        {
            return inputNum <= 11 || inputNum == null;
        }
    }
}