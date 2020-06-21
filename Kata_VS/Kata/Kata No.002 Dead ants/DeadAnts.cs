using System;
using System.Collections.Generic;

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

        private static int MaxAntParts(Dictionary<char, int> antParts)
        {
            return Math.Max(Math.Max(antParts['a'], antParts['n']), antParts['t']);
        }

        private static Dictionary<char, int> CountAntParts(string input)
        {
            Dictionary<char, int> antParts = new Dictionary<char, int>();
            antParts.Add('a', 0);
            antParts.Add('n', 0);
            antParts.Add('t', 0);
            foreach (var antPart in input)
            {
                antParts[antPart]++;
            }

            return antParts;
        }

        private static string RemoveCompleteAnts(string input)
        {
            return input.Replace("ant", "").Replace(".", "");
        }

        private static bool InValidInput(string ants)
        {
            return string.IsNullOrEmpty(ants);
        }
    }
}