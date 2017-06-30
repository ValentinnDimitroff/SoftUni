namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            var allPeople = Console.ReadLine()
                .Split(new [] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var allProducts = Console.ReadLine()
                .Split(new [] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var currentPerson in allPeople)
                {
                    var tokens = currentPerson.Split('=');
                    var person = new Person(tokens[0], decimal.Parse(tokens[1]));
                    people.Add(person);
                }

                foreach (var currentProduct in allProducts)
                {
                    var tokens = currentProduct.Split('=');
                    var product = new Product(tokens[0], decimal.Parse(tokens[1]));
                    products.Add(product);
                }

                string purchases;
                while ((purchases = Console.ReadLine()) != "END")
                {
                    var tokens = purchases
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var personName = tokens[0];
                    var productName = tokens[1];

                    try
                    {
                        var person = people.FirstOrDefault(pers => pers.Name == personName);
                        var product = products.FirstOrDefault(prod => prod.Name == productName);
                        person.BuyProduct(product);
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                }

                foreach (var person in people)
                {
                    var boughtProducts = string.Join(", ", person.GetProducts().Select(prod => prod.Name).ToList());
                    var result = boughtProducts.Any() ? boughtProducts : "Nothing bought";
                    Console.WriteLine($"{person.Name} - {result}");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
