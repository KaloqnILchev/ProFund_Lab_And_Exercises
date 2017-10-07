namespace P01.DebitCardNumber
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int firstFourDigits = int.Parse(Console.ReadLine());
            int secondFourDigits = int.Parse(Console.ReadLine());
            int thirdFourDigits = int.Parse(Console.ReadLine());
            int fourthFourDigits = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}",
                               firstFourDigits, secondFourDigits,
                               thirdFourDigits, fourthFourDigits);
        }
    }
}
