using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace most_frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxCounter = 0;
            int frequentNumb = 0;
            GetMostFrequentNumb(inputNumbers, ref maxCounter, ref frequentNumb);
            Console.WriteLine(frequentNumb);
        }

        private static void GetMostFrequentNumb(int[] inputNumbers, ref int maxCounter, ref int frequentNumb)
        {
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < inputNumbers.Length; j++)
                {
                    if (inputNumbers[i] == inputNumbers[j])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            frequentNumb = inputNumbers[i];
                            maxCounter = counter;
                        }
                    }
                }
            }
        }
    }
}
