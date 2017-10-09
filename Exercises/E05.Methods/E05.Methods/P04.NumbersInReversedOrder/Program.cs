using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();

            ReverNumber(inputNumber);
        }

        private static void ReverNumber(string inputNumber)
        {
            for (int i = inputNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(inputNumber[i]);
            }
            Console.WriteLine();
        }
    }
}
