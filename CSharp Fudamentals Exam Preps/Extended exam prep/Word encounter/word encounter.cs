namespace Word_encounter
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var filter = Console.ReadLine();
            var inputSentence = Console.ReadLine();

            var letter = filter[0];
            var repeatingTimes = int.Parse(filter[1].ToString());

            var sentenceMatch = new Regex(@"^[A-Z].+[\.\?!]$");
            var wordMatcher = new Regex(@"\w+");

            var matchedWords = new List<string>();

            while (inputSentence != "end")
            {

                if (sentenceMatch.IsMatch(inputSentence))
                {
                    var wordMatches = wordMatcher.Matches(inputSentence);

                    if (wordMatches.Count > 0)
                    {
                        foreach (Match wordMatch in wordMatches)
                        {
                            var count = 0;
                            var word = wordMatch.Value;

                            for (int i = 0; i < wordMatch.Length; i++)
                            {
                                if (word[i] == letter && repeatingTimes > 0)
                                {
                                    count++;
                                }
                            }
                            if (count >= repeatingTimes)
                            {
                                matchedWords.Add(wordMatch.Value);
                            }
                        }
                    }
                }

                inputSentence = Console.ReadLine();
            }

            if (matchedWords.Count > 0)
            {
                Console.WriteLine(string.Join(", ", matchedWords));
            }
        }
    }
}
