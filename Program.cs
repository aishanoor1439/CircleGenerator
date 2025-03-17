using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(2.8);
            Circle c2 = new Circle(4.5);
            Circle c3 = c1 + c2;
            Console.WriteLine(c1.getCircle());
            Console.WriteLine(c2.getCircle());
            Console.WriteLine(c3.getCircle());
            Console.ReadKey();
        }
    }
}
