using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var commands = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "reverse":
                    case "sort":
                        var from = int.Parse(commands[2]);
                        var count = int.Parse(commands[4]);

                        if (!IsValid(count, from, collection))
                        {
                            GetReversedOrSorted(commands[0], collection, from, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollLeft":
                    case "rollRight":
                        var timesToRoll = int.Parse(commands[1]);

                        if (timesToRoll < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        else
                        {
                            RollArray(collection, commands[0], timesToRoll);
                        }
                        break;

                }
                Console.WriteLine($"[{string.Join(", ", collection)}]");

                command = Console.ReadLine();
            }

        }

        private static bool IsValid(int count, int from, List<string> collection)
        {
            if (from < 0 && from > collection.Count &&
                count >= 0 && from + count > collection.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void RollArray(List<string> arr, string rollLeftOrRight, int timesToRoll)
        {

            if (rollLeftOrRight.Contains("Right"))
            {
                var rollTimes = timesToRoll % arr.Count;
                for (int i = 0; i < rollTimes; i++)
                {
                    var lastDigit = arr[arr.Count - 1];
                    arr.RemoveAt(arr.Count - 1);
                    arr.Insert(0, lastDigit);

                }
            }
            else
            {
                var rollTimes = timesToRoll % arr.Count;

                for (int i = 0; i < rollTimes; i++)
                {
                    var firstDigit = arr[0];
                    for (int j = 0; j < arr.Count - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[arr.Count - 1] = firstDigit;
                }

            }
        }

        private static void GetReversedOrSorted(string command, List<string> collection, int @from, int count)
        {


            if (command == "reverse")
            {
                var reversed = collection.Skip(@from).Take(count).Reverse().ToList();
                collection.RemoveRange(@from, count);
                collection.InsertRange(@from, reversed);
            }
            else
            {
                var middle = collection.Skip(from).Take(count).OrderBy(x => x).ToList();
                collection.RemoveRange(@from, count);
                collection.InsertRange(@from, middle);

            }

        }
    }
}
