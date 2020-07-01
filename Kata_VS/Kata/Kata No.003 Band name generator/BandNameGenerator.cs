namespace Kata
{
    public class BandNameGenerator
    {
        public string GenerateBandName(string input)
        {
            if (InValidInput(input))
            {
                return "";
            }
            if (StartEndSameLetter(input))
            {
                string last = RemoveFirstLetter(input);
                return RepeatBandNameRule(input, last);
            }
            else
            {
                return TheBandNameRule(input);
            }
        }

        private static string RepeatBandNameRule(string input, string last)
        {
            return char.ToUpper(input[0]) + input.Substring(1) + last;
        }

        private static string RemoveFirstLetter(string input)
        {
            return (input.Remove(0, 1) == "") ? input : input.Remove(0, 1);
        }

        private static string TheBandNameRule(string input)
        {
            return "The " + char.ToUpper(input[0]) + input.Substring(1);
        }

        private static bool StartEndSameLetter(string str)
        {
            return str[0] == str[str.Length - 1];
        }

        private static bool InValidInput(string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}