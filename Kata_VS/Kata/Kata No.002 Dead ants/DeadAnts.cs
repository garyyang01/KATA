using System;

namespace Kata
{
    public class DeadAnts
    {
        public int CountDeadAnts(string input)
        {
            if (InValidInput(input)) return 0;
            input = RemoveCompleteAnts(input);
            var antParts = CountAntParts(input);
            return MaxAntParts(antParts);
        }

        private static int MaxAntParts(int[] antParts)
        {
            return Math.Max(Math.Max(antParts[0], antParts[1]), antParts[2]);
        }

        private static int[] CountAntParts(string input)
        {
            int[] antParts = new int[] { 0, 0, 0 };
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        antParts[0]++;
                        break;

                    case 'n':
                        antParts[1]++;
                        break;

                    case 't':
                        antParts[2]++;
                        break;

                    default: break;
                }
            }

            return antParts;
        }

        private static string RemoveCompleteAnts(string input)
        {
            return input.Replace("ant", " ");
        }

        private static bool InValidInput(string ants)
        {
            return string.IsNullOrEmpty(ants);
        }
    }
}