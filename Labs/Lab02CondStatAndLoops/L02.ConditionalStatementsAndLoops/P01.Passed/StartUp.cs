﻿namespace P01.Passed
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
