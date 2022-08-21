using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollection
{
    internal class Student
    {
        int StuID;
        String StuName;
        public static void a5()
        {
            ArrayList a = new ArrayList();
            Student s1 = new Student() { StuID = 1, StuName = "Jije" };
            Student s2 = new Student() { StuID = 2, StuName = "Jijendira" };
            Student s3 = new Student() { StuID = 3, StuName = "Jijendiran" };
            a.Add(s1);
            a.Add(s2);
            a.Add(s3);
            foreach (ArrayList s in a)
            {
                //string b = string.Format("{a}");
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
