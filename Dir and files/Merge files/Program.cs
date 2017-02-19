using System;
using System.IO;

namespace Merge_files
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFile = File.ReadAllLines("FileOne.txt");
            var secondFile = File.ReadAllLines("FileTwo.txt");

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText("result.txt", firstFile[i] + "\r\n" + secondFile[i] + Environment.NewLine);

            }

        }

    }
}
