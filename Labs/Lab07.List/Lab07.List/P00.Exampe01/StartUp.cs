namespace P00.Exampe01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Sofia");
            names.Add("Parish");

            for (int i = 0; i < names.Count; i++)
            {
                string name = names[i];
                Console.WriteLine(name);
            }

            Console.WriteLine("---");
            names.Insert(1, "Berling");
            names.IndexOf("Berling");

            Console.WriteLine(names.IndexOf("Berling"));

            names.RemoveAt(0);


            foreach (string name in names)
            {
                Console.WriteLine(names[0]);
            }
        }
    }
}
