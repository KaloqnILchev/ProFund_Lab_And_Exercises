using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.FibonacciNumbers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(TheFibNNumber(number));

        }

        private static int TheFibNNumber(int input)
        {
            int Fnext = 0;

            if (input == 1 || input == 0)
            {
                return 1;
            }
            Fnext = 0;
            int F0 = 1;
            int F1 = 1;

            for (int i = 0; i < input - 1; i++)
            {
                Fnext = F0 + F1;
                F0 = F1;
                F1 = Fnext;
            }
            return Fnext; ;
        }
    }
}
