using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class LZW
    {
        public static string Compress(string input)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            List<int> compressedOutput = new List<int>();
            int nextIndex = 256; // Начальное значение для новых индексов в словаре

            string currentSubstring = "";
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                string newSubstring = currentSubstring + currentChar;

                if (dictionary.ContainsKey(newSubstring))
                {
                    currentSubstring = newSubstring;
                }
                else
                {
                    compressedOutput.Add(dictionary[currentSubstring]);

                    dictionary.Add(newSubstring, nextIndex);
                    nextIndex++;
                    currentSubstring = currentChar.ToString();
                }
            }

            if (!string.IsNullOrEmpty(currentSubstring))
            {
                compressedOutput.Add(dictionary[currentSubstring]);
            }

            return string.Join(",", compressedOutput);
        }
    }
}
