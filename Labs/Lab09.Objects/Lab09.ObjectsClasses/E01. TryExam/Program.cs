namespace E01.TryExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> tickedsEntrence = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string leftSide = "";
            string rightSide = "";

            for (int i = 0; i < tickedsEntrence.Count; i++)
            {
                if (tickedsEntrence[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    leftSide = tickedsEntrence[i].Remove(10).ToString();
                    rightSide = tickedsEntrence[i].Substring(10).ToString();
                    

              
                  
                }
            }        


        }
    }
}
