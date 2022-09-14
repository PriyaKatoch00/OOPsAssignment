namespace OOPsAssignment
{
    internal class Program
    {
        class Student
        {
            public void data()
            {
                //int RollNo;
                double engish, math, science, obt_marks, total_marks = 300, percentage;
                Console.WriteLine("Enter Student Name: ");
                string StudName = Console.ReadLine();
                Console.WriteLine("Enter Student RollNo: ");
                string RollNo = Console.ReadLine();
                Console.WriteLine("Enter Marks of English: ");
                engish = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Marks of Math: ");
                math = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Student Science: ");
                science = Convert.ToDouble(Console.ReadLine());
                obt_marks = engish + math + science;
                percentage = (obt_marks / total_marks) * 100;

                Console.WriteLine("Name of Student: {0}", StudName);
                Console.WriteLine("RollNo of Student: {0}", RollNo);
                Console.WriteLine("Total Marks: {0}", obt_marks);
                Console.WriteLine("Percentage: {0}", percentage);
            }
        }
        class Program
        {
            static void Main()
            {
                Student x = new Student();
                x.data();
                Console.ReadKey();
            }
        }
    }
}