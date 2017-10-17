namespace P01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

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
                }
            }
        }
    }
}
