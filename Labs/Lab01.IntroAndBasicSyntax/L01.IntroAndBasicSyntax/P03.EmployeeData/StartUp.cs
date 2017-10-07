namespace P03.EmployeeData
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            double monthlySalary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine("Employee ID: {0:D8}", employeeID);
            Console.WriteLine("Salary: {0:F2}",monthlySalary);
        }
    }
}