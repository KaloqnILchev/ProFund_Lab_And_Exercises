namespace P03.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input;
            Dictionary<string, int> mineralDic = new Dictionary<string, int>();
            int counter = 1;
            string resource = "";
            int quantity = 0;

            for ( ; ; )
            {
                input = Console.ReadLine();

                if (counter % 2 == 0 )
                {
                    quantity = int.Parse(input);
                    if (mineralDic.ContainsKey(resource))
                    {
                        mineralDic[resource] += quantity;
                    }
                    else
                    {
                        mineralDic[resource] = quantity;
                    }
                }
                else
                {
                    resource = input;
                }
                if (input == "stop")
                {
                    break;
                }
                         
                counter++;
            }
            foreach (var item in mineralDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
