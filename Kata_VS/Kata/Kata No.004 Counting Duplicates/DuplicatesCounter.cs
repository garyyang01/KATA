using System.Collections.Generic;

namespace Kata
{
    public class DuplicatesCounter
    {
        public int CountDuplicates(string input)
        {
            if (IsInValidInput(input)) return 0;
            var ans = CountDuplicateCharater(input);
            return ans;
        }

        private static int CountDuplicateCharater(string input)
        {
            var existedSet = new HashSet<char>();
            var duplicateCountedSet = new HashSet<char>();
            int ans = 0;
            foreach (var alpha in input.ToLower())
            {
                if (existedSet.Contains(alpha))
                {
                    if (!duplicateCountedSet.Contains(alpha))
                    {
                        duplicateCountedSet.Add(alpha);
                        ans++;
                    }

                    continue;
                }

                existedSet.Add(alpha);
            }

            return ans;
        }

        private static bool IsInValidInput(string input)
        {
            return string.IsNullOrEmpty(input);
        }
    }
}