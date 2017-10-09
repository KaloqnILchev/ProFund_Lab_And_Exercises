namespace P02.MaxMethod
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int thirdInput = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(firstInput, GetMax(secondInput, thirdInput)));
        }
        
        static int GetMax(int firstNumber, int secondNumber)
        {
            int output;

            if (firstNumber > secondNumber)
            {
                output = firstNumber;
            }
            else
            {
                output = secondNumber;
            }
            return output;
        }
    }
}
