namespace cards
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class cards
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(\d{1,2}|[JKQA])([SHDC])";
            var regex = new Regex(pattern);
            var res = new List<string>();
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                int power = 0;
                
                if (int.TryParse(match.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                res.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ", res));
        }
    }
}
