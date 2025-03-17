using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleGenerator
{
    class Circle
    {

        //Attribute
        double radius;

        //Methods 
        public Circle()
        {
            this.radius = 0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public string getCircle()
        {
            return string.Format("Circle : {0}", radius);
        }

        //Operator overloading
        public static Circle operator +(Circle c1, Circle c2)
        {
            Circle c3 = new Circle();
            c3.radius = c1.radius + c2.radius;
            return c3;
        }
    }
}

