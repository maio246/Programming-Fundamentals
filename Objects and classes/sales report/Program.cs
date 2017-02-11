using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_report
{
    class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var sales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                var currentSale = Console.ReadLine().Split().ToArray();
                Sale currentSaleParse = new Sale
                {
                    Town = currentSale[0],
                    Product = currentSale[1],
                    Price = decimal.Parse(currentSale[2]),
                    Quantity = decimal.Parse(currentSale[3])

                };
                sales.Add(currentSaleParse);
            }

            var result = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }

                result[sale.Town] += sale.Price * sale.Quantity;
            }
            foreach (var list in result)
            {
                Console.WriteLine($"{list.Key} -> {list.Value:f2}");
            }
        }
    }
}
