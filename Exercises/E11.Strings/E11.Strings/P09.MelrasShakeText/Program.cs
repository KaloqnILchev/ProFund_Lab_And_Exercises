using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//09. Melrah Shake
namespace P09.MelrasShakeText
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            string pattern = Console.ReadLine();

            bool canShake = true;

            while (canShake)
            {
                int indxFirst = input.IndexOf(pattern);
                int indxLast = input.LastIndexOf(pattern);
                if (indxFirst > -1 && indxLast > -1 && pattern.Length > 0)
                {
                    input = input.Remove(input.IndexOf(pattern), pattern.Length);
                    input = input.Remove(input.LastIndexOf(pattern), pattern.Length);
                    Console.WriteLine("Shaked it.");
                    if (pattern.Length > 0)
                    {
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                    }

                }
                else
                {
                    Console.WriteLine("No shake.");
                    canShake = false;
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}