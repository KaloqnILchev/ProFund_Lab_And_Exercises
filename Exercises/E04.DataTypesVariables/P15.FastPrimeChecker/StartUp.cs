namespace P15.FastPrimeChecker
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberForCheck = int.Parse(Console.ReadLine());

            for (int primeNumber = 0; primeNumber <= numberForCheck; primeNumber++)
            {
                bool isItPrime = true;

                for (int primeNumberCheck = 2; primeNumberCheck <= Math.Sqrt(primeNumber); primeNumberCheck++)
                {
                    if (primeNumber % primeNumberCheck == 0)
                    {
                        isItPrime = false;
                        break;
                        
                    }
                }
                if( primeNumber >=  2)
                {
                    Console.WriteLine($"{primeNumber} -> {isItPrime}");
                }
            }
        }
    }
}
