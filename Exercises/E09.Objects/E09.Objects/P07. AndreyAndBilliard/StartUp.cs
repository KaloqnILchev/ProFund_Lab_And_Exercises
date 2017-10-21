namespace P07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {

        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> productsAndQuantity { get; set; }
            public decimal Bell { get; set; }
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var products = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split('-');
                var product = line[0];
                var price = decimal.Parse(line[1]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, 0);
                }

            }
        }
    }
}
