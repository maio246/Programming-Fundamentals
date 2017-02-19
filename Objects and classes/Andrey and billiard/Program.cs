using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrey_and_billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var currentMenu = new Dictionary<string, double>();

            GetCurrentMenu(n, currentMenu);

            var allClients = new List<Client>();


            while (true)
            {
                var clients = Console.ReadLine();

                if (clients == "end of clients")
                {
                    break;
                }
                else
                {

                    var clientsSplit = clients.Split('-', ',').ToArray();

                    var clientName = clientsSplit[0];
                    var product = clientsSplit[1];
                    var quantity = double.Parse(clientsSplit[2]);

                    if (!currentMenu.ContainsKey(product)) { continue; }

                    Client client = new Client();

                    client.Name = clientsSplit[0];
                    client.ShopList = new Dictionary<string, double>();
                    client.ShopList.Add(product, quantity);

                    if (allClients.Any(c => c.Name == clientName))
                    {
                        Client existingClient = allClients.First(c => c.Name == clientName);

                        if (existingClient.ShopList.ContainsKey(product))
                        {
                            existingClient.ShopList[product] += quantity;
                        }
                        else
                        {
                            existingClient.ShopList[product] = quantity;
                        }
                    }
                    else
                    {
                        allClients.Add(client);
                    }
                }
            }
            foreach (var customer in allClients)
            {
                foreach (var order in customer.ShopList)
                {
                    foreach (var product in currentMenu)
                    {
                        if (order.Key == product.Key)
                        {
                            customer.Bill += order.Value * product.Value;
                        }
                    }
                }
            }
            var allOrders = allClients
                .OrderBy(x => x.Name)
                .ThenBy(b => b.Bill)
                .ToList();

            foreach (var customer in allOrders)
            {
                Console.WriteLine(customer.Name);

                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {allClients.Sum(c => c.Bill):f2}");
        }

        private static void GetCurrentMenu(int n, Dictionary<string, double> products)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                var productName = input[0];
                var price = double.Parse(input[1]);
                if (products.ContainsKey(productName))
                {
                    products[productName] = price;
                }
                else
                {
                    products.Add(productName, price);
                }
            }
        }
    }
}
