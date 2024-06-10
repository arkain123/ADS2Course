using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


namespace Lab7
{
    internal class CompressionProgram
    {
        static void Main()
        {
            string inputFileName = "input.txt";
            string outputFileNameLZ77 = "output_lz77.txt";
            string outputFileNameLZ78 = "output_lz78.txt";
            string outputFileNameLZW = "output_lzw.txt";

            // Чтение исходного файла
            string inputData = File.ReadAllText(inputFileName);

            // Сжатие данных по алгоритму LZ77
            var compressedDataLZ77 = LZ77.Compress(inputData);
            File.WriteAllText(outputFileNameLZ77, compressedDataLZ77);

            // Сжатие данных по алгоритму LZ78
            var compressedDataLZ78 = LZ78.Compress(inputData);
            File.WriteAllText(outputFileNameLZ78, compressedDataLZ78);

            // Сжатие данных по алгоритму LZW
            //var compressedDataLZW = LZW.Compress(inputData);
            //File.WriteAllText(outputFileNameLZW, compressedDataLZW);

            // Вычисление коэффициента сжатия
            double originalSize = new FileInfo(inputFileName).Length;
            double newSizeLZ77 = new FileInfo(outputFileNameLZ77).Length;
            double newSizeLZ78 = new FileInfo(outputFileNameLZ78).Length;
            //double newSizeLZW = new FileInfo(outputFileNameLZW).Length;

            Console.WriteLine($"Коэффициент сжатия LZ77: {originalSize / newSizeLZ77}");
            Console.WriteLine($"Коэффициент сжатия LZ78: {originalSize / newSizeLZ78}");
            //Console.WriteLine($"Коэффициент сжатия LZW: {originalSize / newSizeLZW}");
        }
    }
}