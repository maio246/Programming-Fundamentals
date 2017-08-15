namespace _04.Phonebook_Update
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Globalization;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();
            var contactNames = Console.ReadLine().Split().ToArray();
            var currCall = Console.ReadLine().Split().ToArray();

            while (currCall[0] != "done")
            {
                var callFunc = currCall[0];
                var numbOrContact = currCall[1];
                var sumOfNumber = 0;
                bool hasAnswer;
                var callDuration = new TimeSpan();
                if (callFunc == "call")
                {
                    for (int i = 0; i < contactNames.Length; i++)
                    {
                        sumOfNumber = GetNumberSum(numbers[i]);
                        hasAnswer = sumOfNumber % 2 == 0;
                        callDuration = TimeSpan.FromSeconds(sumOfNumber);

                        if (numbers[i] == numbOrContact)
                        {
                            Console.WriteLine($"calling {contactNames[i]}...");
                            PrintCallAnswer(hasAnswer, callDuration);
                            break;
                        }
                        if (contactNames[i] == numbOrContact)
                        {
                            Console.WriteLine($"calling {numbers[i]}...");
                            PrintCallAnswer(hasAnswer, callDuration);
                            break;
                        }
                    }
                }
                else if (callFunc == "message")
                {
                    for (int i = 0; i < contactNames.Length; i++)
                    {
                        var isBusyOrNot = GetNumberDifference(numbers[i]);

                        if (numbers[i] == numbOrContact)
                        {
                            Console.WriteLine($"sending sms to {contactNames[i]}...");
                            PrintSmsStatus(isBusyOrNot);
                            break;
                        }
                        if (contactNames[i] == numbOrContact)
                        {
                            Console.WriteLine($"sending sms to {numbers[i]}...");
                            PrintSmsStatus(isBusyOrNot);
                            break;
                        }
                    }
                }
                currCall = Console.ReadLine().Split().ToArray();
            }
        }

        private static void PrintSmsStatus(bool isBusyOrNot)
        {
            if (!isBusyOrNot)
            {
                Console.WriteLine("busy");
            }
            else if (isBusyOrNot)
            {
                Console.WriteLine("meet me there");
            }

        }

        private static void PrintCallAnswer(bool hasAnswer, TimeSpan callDuration)
        {
            if (!hasAnswer)
            {
                Console.WriteLine("no answer");
            }
            else if (hasAnswer)
            {
                Console.WriteLine($"call ended. duration: {callDuration.Minutes:D2}:{callDuration.Seconds:D2}");
            }

        }


        private static int GetNumberSum(string numbOrContact)
        {
            var number = 0;

            for (int i = 0; i < numbOrContact.Length; i++)
            {
                var c = numbOrContact[i];

                if (char.IsDigit(c))
                {
                    number += int.Parse(c.ToString());
                }
            }
            return number;
        }

        private static bool GetNumberDifference(string numbOrContact)
        {
            var number = 0;

            for (int i = 0; i < numbOrContact.Length; i++)
            {
                var c = numbOrContact[i];

                if (char.IsNumber(c))
                {
                    number -= int.Parse(c.ToString());
                }
            }
            if (number % 2 == 0) return true;
            else return false;
        }
    }
}
