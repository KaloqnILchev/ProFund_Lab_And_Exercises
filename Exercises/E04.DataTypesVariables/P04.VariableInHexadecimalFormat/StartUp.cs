namespace P04.VariableInHexadecimalFormat
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string value = Convert.ToString(Console.ReadLine());

            int number = Convert.ToInt32(value, 16);

            Console.WriteLine(number);

        }
    }
}
