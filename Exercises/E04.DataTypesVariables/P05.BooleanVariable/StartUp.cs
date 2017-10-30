namespace P05.BooleanVariable
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Boolean isTrue = Convert.ToBoolean(text);

            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            } 
            

        }
    }
}
