namespace P03.RestaurantDiscount
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string hallname;
            int peopleCount = int.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine().ToLower();

            double hallPrice;
            double discountPrice;
            double discount;
            double totalPrice;
            double totalPriceDiscount;
            double pricePrePerson;
            double endPrice;



            if (peopleCount <= 50)
            {
                hallname = "Small Hall";
                hallPrice = 2500;

                switch (servicePackage)
                {
                    case "normal":
                        discountPrice = 500;
                        totalPrice = hallPrice + discountPrice;
                        discount = 5 / 100.0;
                        totalPriceDiscount = totalPrice * discount;
                        endPrice = totalPrice - totalPriceDiscount;
                        pricePrePerson = endPrice / peopleCount;
                        Console.WriteLine($"We can offer you the {hallname}");
                        Console.WriteLine($"The price per person is {pricePrePerson:F2}$");
                        break;
                    case "gold":
                        discountPrice = 750;
                        totalPrice = hallPrice + discountPrice;
                        discount = 10 / 100.0;
                        totalPriceDiscount = totalPrice * discount;
                        endPrice = totalPrice - totalPriceDiscount;
                        pricePrePerson = endPrice / peopleCount;
                        Console.WriteLine($"We can offer you the {hallname}");
                        Console.WriteLine($"The price per person is {pricePrePerson:F2}$");
                        break;
                    case "platinum":
                        discountPrice = 1000;
                        totalPrice = hallPrice + discountPrice;
                        discount = 15 / 100.0;
                        totalPriceDiscount = totalPrice * discount;
                        endPrice = totalPrice - totalPriceDiscount;
                        pricePrePerson = endPrice / peopleCount;
                        Console.WriteLine($"We can offer you the {hallname}");
                        Console.WriteLine($"The price per person is {pricePrePerson:F2}$");
                        break;
                }

            }
            else if (peopleCount <= 100)
            {
                hallname = "Terrace";
                hallPrice = 5000;

                switch (servicePackage)
                {
                    case "normal":
                        discountPrice = 500;
                        totalPrice = hallPrice + discountPrice;
                        discount = 5 / 100.0;
                        totalPriceDiscount = totalPrice * discount;
                        endPrice = totalPrice - totalPriceDiscount;
                        pricePrePerson = endPrice / peopleCount;
                        Console.WriteLine($"We can offer you the {hallname}");
                        Console.WriteLine($"The price per person is {pricePrePerson:F2}$");
                        break;
                    case "gold":
                        discountPrice = 750;
                        totalPrice = hallPrice + discountPrice;
                        discount = 10 / 100.0;
                        totalPriceDiscount = totalPrice * discount;
                        endPrice = totalPrice - totalPriceDiscount;
                        pricePrePerson = endPrice / peopleCount;
                        Console.WriteLine($"We can offer you the {hallname}");
                        Console.WriteLine($"The price per person is {pricePrePerson:F2}$");
                        break;
                    case "platinum":
                        discountPrice = 1000;
                        totalPrice = hallPrice + discountPrice;
                        discount = 15 / 100.0;
                        totalPriceDiscount = totalPrice * discount;
                        endPrice = totalPrice - totalPriceDiscount;
                        pricePrePerson = endPrice / peopleCount;
                        Console.WriteLine($"We can offer you the {hallname}");
                        Console.WriteLine($"The price per person is {pricePrePerson:F2}$");
                        break;
                }
            }
            else if (peopleCount <= 120)
            {
                hallname = "Great Hall";
                hallPrice = 7500;

                switch (servicePackage)
                {
                    case "normal":
                        discountPrice = 500;
                        totalPrice = hallPrice + discountPrice;
                        discount = 5 / 100.0;
                        totalPriceDiscount = totalPrice * discount;
                        endPrice = totalPrice - totalPriceDiscount;
                        pricePrePerson = endPrice / peopleCount;
                        Console.WriteLine($"We can offer you the {hallname}");
                        Console.WriteLine($"The price per person is {pricePrePerson:F2}$");
                        break;
                    case "gold":
                        discountPrice = 750;
                        totalPrice = hallPrice + discountPrice;
                        discount = 10 / 100.0;
                        totalPriceDiscount = totalPrice * discount;
                        endPrice = totalPrice - totalPriceDiscount;
                        pricePrePerson = endPrice / peopleCount;
                        Console.WriteLine($"We can offer you the {hallname}");
                        Console.WriteLine($"The price per person is {pricePrePerson:F2}$");
                        break;
                    case "platinum":
                        discountPrice = 1000;
                        totalPrice = hallPrice + discountPrice;
                        discount = 15 / 100.0;
                        totalPriceDiscount = totalPrice * discount;
                        endPrice = totalPrice - totalPriceDiscount;
                        pricePrePerson = endPrice / peopleCount;
                        Console.WriteLine($"We can offer you the {hallname}");
                        Console.WriteLine($"The price per person is {pricePrePerson:F2}$");
                        break;
                }
            }
            else if (peopleCount > 121)
            {
                Console.WriteLine($"We do not have an appropriate hall.");
            }
        }
    }
}

