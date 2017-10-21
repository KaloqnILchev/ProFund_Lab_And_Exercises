namespace P04.FixEmails
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
            Dictionary<string, string> mailContacts = new Dictionary<string, string>();
            string input = "";
            string name = "";
            string email = "";
            int count = 0;

            while ((input = Console.ReadLine()) != "stop")

            {
                count++;

                if (count % 2 == 0)
                {
                    email = input;
                    mailContacts.Add(name, email);
                }
                else
                {
                    name = input;
                }
            }
            for (int i = 0; i < mailContacts.Count; i++)
            {
                var item = mailContacts.ElementAt(i);
                var itemKey = item.Key;
                var itemValue = item.Value;

                String[] domane = itemValue.Split('.').ToArray();

                if (domane[1].Contains("uk") || domane[1].Contains("us"))
                {
                    mailContacts.Remove(itemKey);
                }
            }

            foreach (var letfContact in mailContacts)
            {
                Console.WriteLine($"{letfContact.Key} -> {letfContact.Value}");
            }

        }
    }
}
