using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldsize = int.Parse(Console.ReadLine());

            var ladybugs =
                Console.ReadLine().Split().Select(int.Parse).Where(x => x >= 0 && x < fieldsize).ToArray();


            var field = new int[fieldsize];

            for (int i = 0; i < ladybugs.Length; i++)
            {
                var currentBug = ladybugs[i];
                field[currentBug] = 1;
            }

            var commands = Console.ReadLine();

            while (commands != "end")
            {
                var command = commands.Split();

                var bugIndex = int.Parse(command[0]);
                var direction = command[1];
                var flyLength = int.Parse(command[2]);

                if (bugIndex < 0 || bugIndex >= fieldsize)
                {
                    commands = Console.ReadLine();
                    continue;
                }
                if (field[bugIndex] == 0)
                {
                    commands = Console.ReadLine();
                    continue;
                }

                field[bugIndex] = 0;
                var hasFoundPlaceOrOut = false;

                while (!hasFoundPlaceOrOut)
                {

                    switch (direction)
                    {
                        case "left":
                            bugIndex -= flyLength;
                            break;
                        case "right":
                            bugIndex += flyLength;
                            break;
                    }
                    if (bugIndex < 0 || bugIndex >= fieldsize)
                    {
                        hasFoundPlaceOrOut = true;
                        continue;
                    }
                    if (field[bugIndex] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[bugIndex] = 1;
                        hasFoundPlaceOrOut = true;
                        continue;
                    }
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
