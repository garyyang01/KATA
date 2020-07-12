using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class ThreeSumer
    {
        public List<List<int>> GetSumThree(int[] inputArray)
        {
            if (IsInValidInput(inputArray))
            {
                return null;
            }
            var numQueue = new Queue<int>(inputArray);
            List<List<int>> ansList = new List<List<int>>();
            while (numQueue.Count > 2)
            {
                var firstNum = numQueue.Dequeue();
                var tempQueue = new Queue<int>(numQueue);
                while (tempQueue.Count > 1)
                {
                    var secondNum = tempQueue.Dequeue();
                    if (tempQueue.Contains(-firstNum - secondNum))
                    {
                        var ansArray = GetAnsArray(firstNum, secondNum);
                        if (IsNotExist(ansList, ansArray))
                        {
                            ansList.Add(ansArray);
                        }
                    }
                }
            }
            return ansList.Distinct().ToList();
        }

        private static List<int> GetAnsArray(int x, int y)
        {
            var tempArray = new[] { x, y, -x - y }.ToList();
            tempArray.Sort();
            return tempArray;
        }

        private static bool IsNotExist(List<List<int>> ansList, List<int> ansArray)
        {
            return !ansList.Exists(ans => ans.SequenceEqual(ansArray));
        }

        private static bool IsInValidInput(int[] numArray)
        {
            return numArray == null || numArray.Length < 3;
        }
    }
}