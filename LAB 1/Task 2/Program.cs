using System;

namespace Task_2
{
    class Student
    {
        public string name;
        public string id;
        public string year;

        public void PrintInfo()
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student
            {
                name = Console.ReadLine(),
                id = Console.ReadLine(),
                year = Console.ReadLine()
            };
            s.PrintInfo();
        }
    }
}
