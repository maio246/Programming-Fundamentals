using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diff_Int_Sizes
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            if (number > long.MaxValue)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{number} can fit in:");

                if ((long)number <= long.MaxValue && (long)number >= long.MinValue)
                {
                    Console.WriteLine("* long");
                }
                else if ((ulong)number <= ulong.MaxValue && (ulong)number >= ulong.MinValue)
                {
                    Console.WriteLine("* ulong");
                }
                else if ((uint)number <= uint.MaxValue && (uint)number >= uint.MinValue)
                {
                    Console.WriteLine("* uint");
                }
                else if ((int)number <= int.MaxValue && (int)number >= int.MinValue)
                {
                    Console.WriteLine("* int");
                }
                else if ((ushort)number <= ushort.MaxValue && (ushort)number >= ushort.MinValue)
                {
                    Console.WriteLine("* ushort");
                }
                else if ((short)number <= short.MaxValue && (short)number >= short.MinValue)
                {
                    Console.WriteLine("* short");
                }
                else if ((sbyte)number <= sbyte.MaxValue && (sbyte)number >= sbyte.MinValue)
                {
                    Console.WriteLine("* sbyte");
                }
                else if ((byte)number <= byte.MaxValue && (byte)number >= byte.MinValue)
                {
                    Console.WriteLine("* byte");
                }
            }
        }
    }
}
