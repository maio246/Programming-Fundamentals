using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miner_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMaterial = "";
            Dictionary<string, int> result = new Dictionary<string, int>();
            while (inputMaterial != "stop")
            {
                inputMaterial = Console.ReadLine();

                if (inputMaterial != "stop")
                {
                    int quantity = int.Parse(Console.ReadLine());

                    if (result.ContainsKey(inputMaterial))
                    {
                        result[inputMaterial] += quantity;
                    }
                    else
                    {
                        result.Add(inputMaterial, quantity);
                    }
                }
                else
                {
                    break;
                }
            }
            foreach (KeyValuePair<string, int> material in result)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");
            }
        }
    }
}
