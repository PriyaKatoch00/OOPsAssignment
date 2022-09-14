using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsAssignment
{
    internal class Student
    {
        int rollno, currentClass, sem;
        string name, branch;
        int[] marks;

        public Student(string name, int rollno, int currentClass, int sem, string branch, int[] marks)
        {
            this.rollno = rollno;
            this.currentClass = currentClass;
            this.sem = sem;
            this.name = name;
            this.branch = branch;
            this.marks = marks;
        }

        public void displayResult()
        {
            int sum = 0;
            int min = 0;
            foreach (int i in marks)
            {
                sum += i;
                min = Math.Min(min, i);
            }
            if (min < 35 || sum / 5 < 50) Console.WriteLine("Failed");
            else Console.WriteLine("Passed");
        }

        public void displayData()
        {
            Console.WriteLine($"Name = {name} , RollNo = {rollno} , Class ={currentClass} , Semester ={sem} , Branch = {branch}");
            Console.WriteLine(String.Join(",", marks));
            displayResult();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter student Name, RollNo, Class, Sem, Branch");
            string name = Console.ReadLine();
            int rollno = int.Parse(Console.ReadLine());
            int currentClass = int.Parse(Console.ReadLine());
            int sem = int.Parse(Console.ReadLine());
            string branch = Console.ReadLine();
            int[] marks = new int[5];

            Console.WriteLine("Enter marks of 5 subjects");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }

            Student student = new Student(name, rollno, currentClass, sem, branch, marks);
            student.displayData();


        }
    }
}
 