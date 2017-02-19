using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace dir_size
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirSize = Directory.GetFiles("TestFolder").Select(f => new FileInfo(f)).Sum(f => f.Length / 1024.0 / 1024.0).ToString();
            File.AppendAllText("result.txt", dirSize);
        }
    }
}
