using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Welcome to the world of C#");
            Console.WriteLine("First name");
            string name = Console.ReadLine();
            Console.WriteLine("Last name");
            string name1 = Console.ReadLine();
            //if (name == name1)
            if(String.Equals(name, name1))
            {
                Console.WriteLine("\nFirst name and Last name are same");
            }
            else
            {
                Console.WriteLine("\nFirst name and Last name are not same");
            }
            string rname = string.Empty;
            foreach (char c in name)
            {
                rname = c + rname;
            }
            int a = name.Length;
//            string x = "";
//            int len = name.Length - 1;
//            while (len >= 0)
//            {
//                x = x + name[len];
//                len--;
//            }
            Console.WriteLine("\nHi {0} {1}\nWelcome to the world of C#", name, name1);
            Console.WriteLine("\nLength of the First name: " +a);
//            Console.WriteLine("Reverse of the name:", len);
            Console.Write("Reverse of First name: " +rname);
            Console.ReadLine();
            Console.WriteLine("\nPalindrome check");
            string x, y = "";
            Console.WriteLine("Enter string");
            x = Console.ReadLine();
            for (int i = x.Length - 1; i >= 0; i--)  
            {
                y += x[i].ToString();
            }
            if (y == x)  
            {
                Console.WriteLine("Entered word is a Palindrome");
            }
            else
            {
                Console.WriteLine("Entered word is not a Palindrome");
            }
            Console.ReadKey();
            one();
        }
        static void one()
        {
            int a, b, i, odd = 0, even = 0;
            Console.WriteLine("************************************************");
            Console.WriteLine("\nDisplay all the numbers between the given two numbers.");
            Console.WriteLine("Enter Start Value:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End Value:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers between {0} and {1} are", a, b);
            for (i = a; i < b; i++)
            {
                Console.WriteLine(i);
            }
            //Console.ReadKey();
            Console.WriteLine("\nOdd number or Even number.");
            if (a % 2 ==0)
            {
                Console.WriteLine("Start value \t{0} is an Even number", a);
            }
            else
            {
                Console.WriteLine("Start value \t{0} is an Odd number", a);
            }
            two();
            

        }
        static void two()
        {
            int i, n, even = 0, odd = 0;
            Console.WriteLine("************************************************");
            Console.WriteLine("Enter input to find count of odd and even: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter Values:");
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    //even = even;
                    even++;
                }
                else
                {
                    //odd = odd;
                    odd++;
                }
            }
            Console.WriteLine("Total even numbers: " + even);
            Console.WriteLine("Total odd numbers: " + odd);
            Console.ReadLine();
            three();
        }
        static void three()
        {
            int a, c;
            Console.WriteLine("************************************************");
            Console.WriteLine("Fahrenheit to Celcius conversion \nEnter Fahrenheit: ");
            a = Convert.ToInt32(Console.ReadLine());
            c = ((a - 32) * 5 / 9);
            Console.WriteLine("{0}°F = {1}°C", a, c);
            four();
        }
        static void four()
        {
            int a, b;
            Console.WriteLine("************************************************");
            Console.WriteLine("To get 0,1,4,9,16 number sequence");
            Console.WriteLine("Enter limit: ");
            b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Square numbers upto {1} are", b);
            for (a = 0; a <= b; a++)
            {
                Console.WriteLine("\n{0} ", a * a);
            }
            five();
        }
        static void five()
        {
            int a, b, c = 1;
            Console.WriteLine("************************************************");
            Console.WriteLine("Find the factorial");
            b = int.Parse(Console.ReadLine());
            for (a = 1; a <= b; a++)
            {
                c = c * a;
            }
            Console.WriteLine("Factorial of {0} is {1}", b, c);
            six();
        }
        static void six()
        {
            int a = 0, b = 1, c, d, i;
            Console.WriteLine("************************************************");
            Console.WriteLine("Fibonacci series");
            d = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b+" ");
            for (i = 2; i < d; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
                //if (c == 40);
                //break;
            }
            seven();
        }
        static void seven()
        {
            int i, n;
            Console.WriteLine("\n************************************************");
            Console.WriteLine("Multiplication table");
            Console.WriteLine("Enter Value:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0} * {1} = {2} \n", n, i, n * i);
            }
            eight();

        }
        static void eight()
        {
            int i;
            Console.WriteLine("\n************************************************");
            Console.WriteLine("Numbers divisible by 7 between 200 and 300");
            for(i = 200; i < 300; i++)
            {
                if (i % 7 == 0)
                    Console.Write(i + " ");
            }
            nine();
        }
        static void nine()
        {
            int a, b, c;
            Console.WriteLine("\n************************************************");
            Console.WriteLine("Finding the largest of 3 numbers");
            Console.WriteLine("Enter value one:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value two:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value three:");
            c = int.Parse(Console.ReadLine());
            if(a>b)
            {
                if(a>c)
                {
                    Console.Write("{0} is the largest number", a);
                }
                else
                {
                    Console.Write("{0} is the largest number", c);
                }
            }
            else if(b>c)
            {
                Console.Write("{0} is the largest number", b);
            }
            else
            {
                Console.Write("{0} is the largest number", c);
            }
            ten();
        }
        static void ten()
        {
            int i = 0;
            int a = 0;
            int[] arr = new int[5];
            Console.WriteLine("\n************************************************");
            Console.WriteLine("Enter any 5 values : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Value[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            a = arr[0];
            for (i = 1; i < arr.Length; i++)
            {
                if (a > arr[i])
                    a = arr[i];
            }
            Console.WriteLine("Smallest value is : " + a);
            for (i = 1; i < arr.Length; i++)
            {
                if (a < arr[i])
                    a = arr[i];
            }
            Console.WriteLine("Largest value is : " + a);
            a1();
        }
        static void a1()
        {
            int i = 0;
            int a = 0;
            float sum = 0;
            int[] arr = new int[10];
            Console.WriteLine("\n************************************************");
            Console.WriteLine("Enter 10 subjects mark : ");
            //int sum = arr.Sum();
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Subject[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            a = arr[0];
            for (i = 1; i < arr.Length; i++)
            {
                if (a > arr[i])
                    a = arr[i];
                sum += arr[i];
            }
            
            Console.WriteLine("\nTotal Marks: " +sum);
            Console.WriteLine("Average Mark: " + sum / arr.Length);
            Console.WriteLine("Lowest Mark: " + a);
            for (i = 1; i < arr.Length; i++)
            {
                if (a < arr[i])
                    a = arr[i];
            }
            Console.WriteLine("Highest Mark: " + a);
            Array.Sort(arr);
            
            Console.WriteLine("\nMarks in ascending order");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Array.Reverse(arr);
            Console.WriteLine("\nMarks in descending order");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
