using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace Lambada_Expressions
{
    using System;

    public class LambadaExpressions
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var storedExpressions = new Dictionary<string, Dictionary<string, string>>();

            while (input != "lambada")
            {
                var tokens = input
                    .Split(new[] { '=', '>', '.', ' '}
                    , StringSplitOptions.RemoveEmptyEntries);


                if (tokens[0] != "dance")
                {

                    var selector = tokens[0];
                    var selectorObject = tokens[1]+ ".";
                    var property = tokens[2];

                    if (!storedExpressions.ContainsKey(selector))
                    {
                        storedExpressions.Add(selector, new Dictionary<string, string>());
                    }

                    storedExpressions[selector][selectorObject] = property;

                }
                else
                {
                    storedExpressions = storedExpressions
                        .ToDictionary(x => x.Key, x => x.Value
                            .ToDictionary(y => y.Key, y => y.Key + y.Value));


                }

                input = Console.ReadLine();
            }

            foreach (var storedExpression in storedExpressions)
            {
                Console.Write($"{storedExpression.Key} => ");

                foreach (var expression in storedExpression.Value)
                {
                    Console.WriteLine($"{expression.Key}{expression.Value}");
                }
            }
        }
    }
}
