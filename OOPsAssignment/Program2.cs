using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsAssignment
{
    internal class Program2
    {
        {
        static double Area(int side)
        {
            return side * side;
        }

        static double Area(int len, int b)
        {
            return len * b;
        }

        static double Area(double radius)
        {
            return 3.14 * radius * radius;
        }

        static double Area(double len, double b)
        {
            return 0.5 * len * b;
        }
    }
}
