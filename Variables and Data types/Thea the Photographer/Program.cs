using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPictures = int.Parse(Console.ReadLine());
            int filterTimePerPicture = int.Parse(Console.ReadLine());
            int percentGoodPictures = int.Parse(Console.ReadLine());
            int uploadTimePerPic = int.Parse(Console.ReadLine());

            int filteredPics = totalPictures % percentGoodPictures;
            Console.WriteLine(filteredPics);
        }
    }
}
