namespace P08.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputFilePath = "../../input.txt";
            string outputFIlePath = "../../output.txt";

            File.WriteAllText(outputFIlePath, string.Empty);

            var enternce = File.ReadAllLines(inputFilePath);


            List<Student> studentsList = new List<Student>();

            for (int k = 0; k < enternce.Length; k++)
            {
                string[] input = enternce[k].Split().ToArray();
                string name = input[0];
                double[] grades = input.Skip(1).Select(double.Parse).ToArray();

                Student student = new Student();
                student.StudentGrades = new List<double>();

                student.StudentName = name;

                foreach (double grade in grades)
                {
                    student.StudentGrades.Add(grade);
                }
                studentsList.Add(student);
            }


            foreach (var excellentStudent in studentsList
                                                    .Where(x => x.StudentAvarageGrade >= 5.0)
                                                    .OrderBy(x => x.StudentName)
                                                    .ThenByDescending(x => x.StudentAvarageGrade))
            {
                File.AppendAllText(outputFIlePath, $"{excellentStudent.StudentName} -> {excellentStudent.StudentAvarageGrade:F2}");
                File.AppendAllText(outputFIlePath, Environment.NewLine);
            }
        }

        class Student
        {
            public string StudentName { get; set; }
            public List<double> StudentGrades { get; set; }
            public double StudentAvarageGrade => StudentGrades.Average();


        }
    }
}
