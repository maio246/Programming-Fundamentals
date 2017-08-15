using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFiles = int.Parse(Console.ReadLine());

            var files = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < numberOfFiles; i++)
            {
                var fileDir = Console.ReadLine().Split('\\');

                var currentFileInfo = fileDir[fileDir.Length - 1].Split(';');

                var root = fileDir[0];
                var fileName = currentFileInfo[0];
                var fileSize = long.Parse(currentFileInfo[currentFileInfo.Length - 1]);

                if (!files.ContainsKey(root))
                {
                    files.Add(root, new Dictionary<string, long>());
                }
                if (!files[root].ContainsKey(fileName))
                {
                    files[root].Add(fileName, fileSize);
                }
                else
                {
                    files[root][fileName] = fileSize;
                }
            }

            var search = Console.ReadLine().Split();

            var searchRoot = search[2];
            var extention = search[0];
            if (files.ContainsKey(searchRoot))
            {
                var foundFiles = files[searchRoot];

                foreach (var file in foundFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (file.Key.EndsWith(extention))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }

            }
            else
            {
                Console.WriteLine("No");

            }
        }
    }
}
