namespace _1.Last_3_Consecutive_Equal_Strings
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            var result = string.Empty;
            var counter = 1;

            for (int i = 1; i < input.Length; i++)
            {
                var currentWord = input[i];
                var previousWord = input[i - 1];

                if (currentWord.Equals(previousWord))
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter == 3)
                {
                    result = currentWord;
                }
            }

            Console.WriteLine("{0} {0} {0}", result);
        }
    }
}
