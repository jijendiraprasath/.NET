using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructor
{
    internal class Q3
    {
        class Shapes
        {
            public void b1()
            {
                double l, b, r, a, h, B, ar_rec, ar_cir, ar_tri, ar_squ;
                double PI = 22 / 7;
                Console.WriteLine("\nEnter the Length and Breadth : ");
                l = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                ar_rec = (l * b);
                Console.WriteLine("Enter the radius of the circle : ");
                r = Convert.ToDouble(Console.ReadLine());
                ar_cir = r * PI * r;
                Console.WriteLine("Enter the Height and Base : ");
                h = Convert.ToDouble(Console.ReadLine());
                B = Convert.ToDouble(Console.ReadLine());
                ar_tri = 0.5 * h * B;
                Console.WriteLine("Enter the side of the square : ");
                a = Convert.ToDouble(Console.ReadLine());
                ar_squ = a * a;
                Console.WriteLine("Area of Rectangle : {0}", ar_rec);
                Console.WriteLine("Area of Circle : {0}", ar_cir);
                Console.WriteLine("Area of Triangle : {0}", ar_tri);
                Console.WriteLine("Area of Square : {0}", ar_squ);
                Console.ReadKey();
            }

        }
        public static void a3()
        {
            Shapes s = new Shapes();
            s.b1();

        }
    }
}
