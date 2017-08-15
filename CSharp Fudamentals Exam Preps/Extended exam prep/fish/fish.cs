namespace fish
{
    using System.Text.RegularExpressions;
    using System;

    class fish
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(>+)?<([(]+)('|-|x)+>";

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(input);

            if (matches.Count == 0)
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                var counter = 1;

                foreach (Match match in matches)
                {
                    var tailLength = match.Groups[1].Length;
                    var tail = "";

                    if (tailLength == 1) tail = "Short";
                    else if (tailLength > 1 && tailLength <= 5) tail = "Medium";
                    else if (tailLength > 5) tail = "Long";
                    else tail = "None";

                    var bodyLength = match.Groups[2].Length;
                    var body = "";

                    if (bodyLength > 10) body = "Long";
                    else if (bodyLength > 5 && bodyLength <= 10) body = "Medium";
                    else body = "Short";

                    var status = "";

                    switch (match.Groups[3].Value)
                    {
                        case "\'":
                            status = "Awake";
                            break;
                        case "-":
                            status = "Asleep";
                            break;
                        case "x":
                            status = "Dead";
                            break;
                    }

                    Console.WriteLine($"Fish {counter}: {match.Value}");

                    if (tail == "None") Console.WriteLine($"  Tail type: {tail}");
                    else Console.WriteLine($"  Tail type: {tail} ({tailLength * 2} cm)");

                    Console.WriteLine($"  Body type: {body} ({bodyLength * 2} cm)");
                    Console.WriteLine($"  Status: {status}");

                    counter++;
                }
            }
        }
    }
}
