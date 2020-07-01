using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class TwoSumer
    {
        public int[] GetSumTwo(int[] numArray, int target)
        {
            if (IsInValidInput(numArray, target))
            {
                return null;
            }
            List<int> numList = numArray.ToList();
            int[] ans = new int[2];
            foreach (var firstNum in numList)
            {
                var index = numList.IndexOf(firstNum);
                var secondNum = target - firstNum;
                if (FoundAnotherIndex(numList, secondNum, index))
                {
                    return SetUpAns(ans, numList, firstNum, secondNum);
                }
            }
            return null;
        }

        private static int[] SetUpAns(int[] ans, List<int> numList, int firstNum, int secondNum)
        {
            ans[0] = numList.IndexOf(firstNum);
            ans[1] = numList.IndexOf(secondNum, numList.IndexOf(firstNum) + 1);
            return ans;
        }

        private static bool FoundAnotherIndex(List<int> numList, int secondNum, int index)
        {
            return numList.IndexOf(secondNum, index + 1) >= 0;
        }

        private static bool IsInValidInput(int[] numArray, int target)
        {
            return numArray == null || numArray.Length < 2 || target == null;
        }
    }
}