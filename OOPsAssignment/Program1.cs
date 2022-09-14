using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsAssignment
{
    public class Program1
    {
        static void Main(string[] args)
        {
            int month = 1;
            Console.WriteLine("Balance:");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Pay:");
            int n = int.Parse(Console.ReadLine());
            int k = n;
            while (s > 0)
            {
                s = s + (1.5 * s) / 100;
                s = s - n;
                if (s < 0)
                    break;
                Console.WriteLine("Updated Balance: " + s + "Monthly Pay:" + k);
                k = k + n;

            }

        }
    }
}