using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace centuries_to_nanosecs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short year = (short)(centuries * 100);
            int days = (int)(year * 365.2422);
            uint hours = (uint)(days * 24);
            long minutes = hours * 60;
            ulong seconds = (ulong)(minutes * 60);
            decimal milliseconds = (decimal)(seconds * 1000);
            BigInteger microseconds = (BigInteger)(milliseconds * 1000);
            BigInteger nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
