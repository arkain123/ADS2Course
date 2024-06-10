using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class LZ78
    {
        public static string Compress(string input)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            List<string> compressedOutput = new List<string>();

            int nextIndex = 1;

            string currentSubstring = "";
            for (int i = 0; i < input.Length; i++)
            {
                string currentChar = input[i].ToString();
                string newSubstring = currentSubstring + currentChar;

                if (dictionary.ContainsKey(newSubstring))
                {
                    currentSubstring = newSubstring;
                }
                else
                {
                    if (currentSubstring.Length > 0)
                    {
                        compressedOutput.Add($"<{dictionary[currentSubstring]},'{currentChar}'");
                    }
                    else
                    {
                        compressedOutput.Add($"<0,'{currentChar}'");
                    }

                    dictionary.Add(newSubstring, nextIndex);
                    nextIndex++;
                    currentSubstring = "";
                }
            }

            if (currentSubstring.Length > 0)
            {
                compressedOutput.Add($"<{dictionary[currentSubstring]},''");
            }

            return string.Join("", compressedOutput);
        }
    }
}
