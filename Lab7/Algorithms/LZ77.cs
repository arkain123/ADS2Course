using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class LZ77
    {
        public static string Compress(string input)
        {
            int windowSize = 20; // Размер окна (длина буфера словаря)
            int lookaheadBuffer = 15; // Размер буфера просмотра (длина текущего символа)

            var compressedOutput = new List<string>();
            int currentIndex = 0;

            while (currentIndex < input.Length)
            {
                int maxMatchLength = 0;
                int maxMatchIndex = 0;

                for (int i = Math.Max(0, currentIndex - windowSize); i < currentIndex; i++)
                {
                    int matchLength = 0;
                    while (matchLength < lookaheadBuffer && currentIndex + matchLength < input.Length &&
                           input[i + matchLength] == input[currentIndex + matchLength])
                    {
                        matchLength++;
                    }

                    if (matchLength > maxMatchLength)
                    {
                        maxMatchLength = matchLength;
                        maxMatchIndex = i;
                    }
                }

                if (maxMatchLength > 0)
                {
                    compressedOutput.Add($"<{currentIndex - maxMatchIndex},{maxMatchLength},'{input[currentIndex + maxMatchLength]}'");
                    currentIndex += maxMatchLength + 1;
                }
                else
                {
                    compressedOutput.Add($"<0,0,'{input[currentIndex]}'");
                    currentIndex++;
                }
            }

            return string.Join("", compressedOutput);
        }
    }
}
