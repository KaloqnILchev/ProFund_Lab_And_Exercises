namespace P11.5DifferentNumbers
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            if (Math.Abs(numberA - numberB) < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int n1 = numberA; n1 <= numberB; n1++)
                {
                    for (int n2 = n1; n2 <= numberB; n2++)
                    {
                        for (int n3 = n2; n3 <= numberB; n3++)
                        {
                            for (int n4 = n3; n4 <= numberB; n4++)
                            {
                                for (int n5 = n4; n5 <= numberB; n5++)
                                {
                                    if ((numberA <= n1) && (n1 < n2) && (n2 < n3) &&
                                        (n3 < n4) && (n4 < n5) && (n5 <= numberB))
                                    {
                                        Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    }
                                }
                            }

                        }

                    }
                }
            }

        }
    }
}
