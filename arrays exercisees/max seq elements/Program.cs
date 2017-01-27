using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_seq_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var start = 0;
            var length = 1;

            var seqStart = 0;
            var seqLength = 0;

            for (int i = 1; i <= input.Length - 1; i++)
            {

                if (input[i] == input[i - 1])
                {
                    length++;
                }
                else if (input[i] != input[i + 1])
                {
                    start = i;
                    if (length > seqLength)
                    {
                        seqStart = i;
                        length = 1;
                    }
                }
            }
        }
    }
}
