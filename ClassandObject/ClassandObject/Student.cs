using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    internal class Student
    {
        int roll_no;
        string student_name;
        string standared;
        string Semister;
        string Branch;
        double[] marks = new double[5];

        public void Accept(int rno, string name, string stan, string SEM, string branch, double[] m)
        {
            roll_no = rno;
            student_name = name;
            standared = stan;
            Semister = SEM;
            Branch = branch;
            marks = m;
        }

        public void DisplayData()
        {
            Console.WriteLine("Student {0} Marks ", student_name);
            Console.WriteLine("roll_no: " + roll_no);
            Console.WriteLine("Name: " + student_name);
            Console.WriteLine("Class: " + standared);
            Console.WriteLine("SEM: " + Semister);
            Console.WriteLine("Branch: " + Branch);

        }
        public static void a3()
        {
            Student s1 = new Student();
            s1.roll_no = 20;
            s1.student_name = "Priya";
            s1.standared = "V";
            s1.Semister = "II";
            s1.Branch = "computers";
            s1.marks[0] = 89;
            s1.marks[1] = 78.5;
            s1.marks[2] = 56.5;
            s1.marks[3] = 90;
            s1.marks[4] = 77.5;

            double tot = 0;
            double a = 0;
            double[] m = new double[5];

            Console.WriteLine("roll_no: {0}" +
                "\nStudent name {1}" +
                "\nSemister {2}" +
                "\nBranch {3}", s1.roll_no, s1.student_name, s1.Semister, s1.Branch);

            foreach (double i in s1.marks)
            {
                Console.Write(i + " ");
                tot += i;
                if (a <= 35)
                {
                    Console.WriteLine("pass");
                }
                else
                {
                    Console.WriteLine("failed");

                }
            }
            Console.WriteLine();

            Console.WriteLine("Total Marks " + tot);
            Console.WriteLine("Average Mark: " + tot / m.Length);

            if (tot < 50)
            {
                Console.WriteLine("failed");
            }
            else
            {
                Console.WriteLine("pass");
            }

            Console.ReadKey();
        }
    }
}
