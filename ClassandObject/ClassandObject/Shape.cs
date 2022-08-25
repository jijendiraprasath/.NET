using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    abstract class Shape
    {
        public abstract void Area();
        public void Draw()
        {
            Console.WriteLine("It is a 2d Shape");
        }

        public abstract int Points
        {
            get;
            set;
        }
    }
    class Rectangle : Shape
    {
        public double l, w;
        public Rectangle(double l, double w)
        {
            this.l = l;
            this.w = w;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Rectangle: " + (l * w));
        }
        public override int Points
        {
            get { return 3; }
            set
            {
                value = 3;
            }
        }
    }
    class Triangle : Shape
    {
        public double h, b;
        public Triangle(double h, double b)
        {
            this.h = h;
            this.b = b;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Triangle: " + 0.5 * (h * b));
        }
        public override int Points
        {
            get { return 3; }
            set
            {
                value = 3;
            }
        }
    }
    class Circle : Shape
    {
        public double r;
        public const double PI = 3.14;
        public Circle(double r)
        {
            this.r = r;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Circle: " + PI * r * r);
        }
        public override int Points
        {
            get { return 3; }
            set
            {
                value = 3;
            }
        }
    }
    class Square : Shape
    {
        public double a;
        public Square(double a)
        {
            this.a = a;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Square: " + (a * a));
        }
        public override int Points
        {
            get { return 3; }
            set
            {
                value = 3;
            }
        }
    }
    class TESTShape
    {
        public static void a5()
        {
            Shape[] list = new Shape[4];
            list[0] = new Rectangle(12, 23);
            list[1] = new Triangle(7, 13);
            list[2] = new Circle(12.3);
            list[3] = new Square(4);
            foreach (Shape s in list)
            {
                s.Draw();
                s.Area();
            }
        }
    }
}
