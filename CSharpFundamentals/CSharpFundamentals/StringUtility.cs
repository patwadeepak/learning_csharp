using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    public class StringUtility
    {
        public static string SummarizeText(string input, int maxLength)
        {
            if (input.Length <= maxLength)
                return input;

            var words = input.Split(' ');
            var mywords = new List<string>();
            var characters = 0;
            foreach(var word in words)
            {
                mywords.Add(word);
                if (characters + word.Length + 1 < maxLength)
                {
                    characters += 1 + word.Length;
                }
                else
                {
                    break;
                }
            }
            var output = string.Join(" ", mywords) + "...";
            return output;
        }
    }
}
