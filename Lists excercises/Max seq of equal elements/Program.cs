using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_seq_of_equal_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            int currentSeqLength = 1;

            int seqElementToPrint = 0;
            int bestSeqLength = 0;
            for (int i = 1; i < numbersInput.Count; i++)
            {
                if (numbersInput.Count == 1)
                {
                    Console.WriteLine(numbersInput[0]);
                    break;
                } 

                if (numbersInput[i] == numbersInput[i - 1])
                {
                    currentSeqLength++;
                }
                if (currentSeqLength > bestSeqLength)
                {
                    seqElementToPrint = numbersInput[i];
                    bestSeqLength = currentSeqLength;
                }
                if (numbersInput[i] != numbersInput[i - 1])
                {
                    currentSeqLength = 1;
                }
            }
            int[] result = new int[bestSeqLength];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = seqElementToPrint;
                Console.Write(string.Join(" ", result[i] + " "));
            }
            Console.WriteLine();
        }
    }
}
