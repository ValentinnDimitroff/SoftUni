using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class OfficeStuff
{
    public static void Main()
    {
        var orders = new List<Order>();
        var count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            var orderTokens = Console.ReadLine()
                .Trim('|')
                .Split('-')
                .Select(x => x.Trim())
                .ToArray();

            orders.Add(new Order(orderTokens[0], int.Parse(orderTokens[1]), orderTokens[2]));
        }

        //var sortedOrders = 
            orders
            .GroupBy(order => order.CompanyName)
            .OrderBy(gr => gr.Key)
            //One line solution
            .Select(ordCmp => ordCmp
                .GroupBy(order => order.ProductName)
                .Select(grProd => new
                {
                    CompName = ordCmp.Key,
                    Name = grProd.Key,
                    TotalAmount = grProd.Sum(prod => prod.Amount)
                }))
            .ToList()
            .ForEach(x =>
                {
                    Console.Write(x.Select(a => $"{a.CompName}").First() + ": ");
                    Console.WriteLine(string.Join(", ", x.Select(pr => $"{pr.Name}-{pr.TotalAmount}")));
                });
            
        //foreach (var company in sortedOrders)
        //{
        //    Console.Write(company.Key + ": ");
        //    var products = company
        //        .GroupBy(x => x.ProductName)
        //        .Select(y => new
        //        {
        //            Name = y.Key,
        //            TotalAmount = y.Sum(x => x.Amount)
        //        });
        //    Console.WriteLine(string.Join(", ", products.Select(pr => $"{pr.Name}-{pr.TotalAmount}")));
        //}
    }

    public class Order
    {
        public string CompanyName { get; set; }
        public int Amount { get; set; }
        public string ProductName { get; set; }

        public Order(string companyName, int amount, string productName)
        {
            this.CompanyName = companyName;
            this.Amount = amount;
            this.ProductName = productName;
        }
    }
}