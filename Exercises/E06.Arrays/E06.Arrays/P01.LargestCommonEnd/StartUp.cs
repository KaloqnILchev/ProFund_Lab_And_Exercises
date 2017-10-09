namespace P01.LargestCommonEnd
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] fisrtArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();
            int counterLeft = 0;
            int counterRight = 0;

            for (int i = 0; i < Math.Min(fisrtArray.Length, secondArray.Length); i++)
            {
                if (fisrtArray[i] == secondArray[i])
                {
                    counterLeft++;
                }
                else
                {
                    break;
                }
            }
            for (int i = Math.Min(fisrtArray.Length, secondArray.Length) - 1; i >= 0; i--)
            {
                int arrayDifference = Math.Abs(fisrtArray.Length - secondArray.Length);

                try
                {
                    if (secondArray[i] == (fisrtArray[i + arrayDifference]))
                    {
                        counterRight++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    break;   
                }
            }
            if (!(counterLeft == 0 && counterRight == 0) )
            {
                Console.WriteLine(Math.Max(counterLeft, counterRight));
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
