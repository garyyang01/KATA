using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class TwoSumer
    {
        public int[] GetSumTwo(int[] numArray, int target)
        {
            if (IsInValidInput(numArray, target)) return null;
            List<int> numList = numArray.ToList();
            int[] ans = new int[2];
            foreach (var oneNum in numList)
            {
                var index = numList.IndexOf(oneNum);
                var twoNum = target - oneNum;
                if (FoundAnotherIndex(numList, twoNum, index))
                {
                    return SetUpAns(ans, numList, oneNum, twoNum);
                }
            }
            return null;
        }

        private static int[] SetUpAns(int[] ans, List<int> numList, int oneNum, int twoNum)
        {
            ans[0] = numList.IndexOf(oneNum);
            ans[1] = numList.IndexOf(twoNum, numList.IndexOf(oneNum) + 1);
            return ans;
        }

        private static bool FoundAnotherIndex(List<int> numList, int twoNum, int index)
        {
            return numList.IndexOf(twoNum, index + 1) >= 0;
        }

        private static bool IsInValidInput(int[] numArray, int target)
        {
            return numArray == null || numArray.Length < 2 || target == null;
        }
    }
}