namespace P02.AddTwoNumbers
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
        }
    }
}
