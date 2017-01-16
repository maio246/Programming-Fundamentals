using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greater_than_two
{
    class Program
    {
        static void Main(string[] args)
        {
            string chosenType = Console.ReadLine();

            if (chosenType == "string")
            {
                string firstChoice = Console.ReadLine();
                string secondChoice = Console.ReadLine();
                string max = GetMax(firstChoice, secondChoice);
                Console.WriteLine(max);
            }
            else if (chosenType == "int")
            {
                int firstNumb = int.Parse(Console.ReadLine());
                int secondNumb = int.Parse(Console.ReadLine());
                int max = GetMax(firstNumb, secondNumb);
                Console.WriteLine(max);
            }
            else if (chosenType == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char max = GetMax(firstChar, secondChar);
                Console.WriteLine(max);
            }
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar.CompareTo(secondChar) >= 0)
            {

                return firstChar;
            }
            else if (firstChar.CompareTo(secondChar) < 0)
            {
                return secondChar;
            }
            else
            {
                return secondChar;
            }

        }
        static int GetMax(int firstNumb, int secondNumb)
        {
            if (firstNumb > secondNumb)
            {
                return firstNumb;
            }
            else if (firstNumb < secondNumb)
            {
                return secondNumb;
            }
            else
            {
                return firstNumb;
            }
        }

        static string GetMax(string firstChoice, string secondChoice)
        {
            if (firstChoice.CompareTo(secondChoice) >= 0)
            {

                return firstChoice;
            }
            else if (firstChoice.CompareTo(secondChoice) < 0)
            {
                return secondChoice;
            }
            else
            {
                return "Equal";
            }

        }
    }
}
