namespace _3.Phonebook
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();
            var contactNames = Console.ReadLine().Split().ToArray();

            var currContact = Console.ReadLine();

            var result = new StringBuilder();

            while (currContact != "done")
            {
                for (int i = 0; i < contactNames.Length; i++)
                {
                    if (contactNames[i] == currContact)
                    {
                        result.AppendLine($"{contactNames[i]} -> {numbers[i]}");
                    }
                }

                currContact = Console.ReadLine();
            }

            Console.WriteLine(result);
        }
    }
}
