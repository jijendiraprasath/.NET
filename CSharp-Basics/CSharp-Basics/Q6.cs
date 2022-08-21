using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Q6
    {
        public static void q6()
        {
            int a, c;
            Console.WriteLine("Fahrenheit to Celcius conversion \nEnter Fahrenheit: ");
            a = Convert.ToInt32(Console.ReadLine());
            c = ((a - 32) * 5 / 9);
            Console.WriteLine("{0}°F = {1}°C", a, c);
        }
    }
}
