using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Casya", "Pupkin", "num1", 2001, 1, new int[]{4, 4, 5, 3, 3}),
                new Student("Basya", "Vasya", "num2", 2002, 2, new int[]{3, 1, 3, 2, 5}),
                new Student("Aasya", "Vasya", "num3", 2001, 1, new int[]{2, 5, 4, 1, 2}),
                new Student("Dasya", "Vasya", "num4", 2003, 2, new int[]{1, 3, 2, 5, 1}),
                new Student("Fasya", "Vasya", "num5", 2000, 1, new int[]{5, 2, 1, 4, 5}),
            };
            var formated = students.OrderBy(person => person.numOfGroup).ThenBy(person => person.name);
            foreach (Student person in formated) Console.WriteLine(person.sname);

            for (int i = 1; i <= formated.Max(person => person.numOfGroup); i++)
            {
                Console.WriteLine($"Group{i}: ");
                List<int> avgMarks = new List<int>();
                var numOfStudents = formated.Where(person => person.numOfGroup == i);
                for (int k = 0; k < 5; k++)
                {
                    Console.WriteLine($"subj {k + 1}: ");
                    for (int j = 0; j < numOfStudents.Count(); j++)
                    {
                        avgMarks.Add(numOfStudents.ElementAt(j).marks[k]);
                        Console.WriteLine(numOfStudents.ElementAt(j).marks[k]);
                    }
                    Console.WriteLine($"Average mark is: {avgMarks.Average()}");
                }
            }
            Console.WriteLine($"Max age: {formated.Max(person => person.birthyear)}");
            Console.WriteLine($"Min age: {formated.Min(person => person.birthyear)}");

            string name = "";
            double biggest;
            for (int i = 1; i <= formated.Max(person => person.numOfGroup); i++)
            {
                var numOfStudents = formated.Where(person => person.numOfGroup == i);
                biggest = numOfStudents.ElementAt(0).marks.Sum();
                name = numOfStudents.ElementAt(0).name;
                for (int k = 1; k < numOfStudents.Count(); k++)
                {
                    if (biggest < numOfStudents.ElementAt(k).marks.Sum())
                    {
                        biggest = numOfStudents.ElementAt(k).marks.Sum();
                        name = numOfStudents.ElementAt(k).name;
                    }
                }        
                Console.WriteLine($"The cleverest of {i} group has such amount of marks: {biggest} ({name})");
            }
        }
    }

    class Student
    {
        public string name { get; set; }
        public string fname { get; set; }
        public string sname { get; set; }
        public int birthyear { get; set; }
        public int numOfGroup { get; set; }
        public int[] marks { get; set; }

        public Student(string name, string fname, string sname, int birthyear, int numOfGroup, int[] marks)
        {
            this.name = name;
            this.fname = fname;
            this.sname = sname;
            this.birthyear = birthyear;
            this.numOfGroup = numOfGroup;
            this.marks = marks;
        }
    }
}
