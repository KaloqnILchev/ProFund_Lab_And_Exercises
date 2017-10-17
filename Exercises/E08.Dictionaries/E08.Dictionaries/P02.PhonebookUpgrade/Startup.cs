using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.PhonebookUpgrade
{
    class StartUp
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string input;
            string command = "";
            string name = "";
            string phoneNumber = "";

            while ((input = Console.ReadLine()) != "END")
            {
                string[] enterenceParameter = input.Split(' ').ToArray();

                if (enterenceParameter.Length == 3)
                {
                    command = enterenceParameter[0];
                    name = enterenceParameter[1];
                    phoneNumber = enterenceParameter[2];
                }
                else if (enterenceParameter.Length == 2)
                {
                    command = enterenceParameter[0];
                    name = enterenceParameter[1];
                }
                else if (enterenceParameter.Length == 1)
                {
                    command = enterenceParameter[0];
                }

                switch (command)
                {
                    case "A":
                        phonebook[name] = phoneNumber;
                        break;
                    case "S":
                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} -> {phonebook[name]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (KeyValuePair<string, string> element in phonebook)
                        {
                            Console.WriteLine($"{element.Key} -> {element.Value}");
                        }
                        break;
                }
            }
        }
    }
}
