using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    internal class Stu
    {
        static double percentage;
        static int RollNo;
        static string StudName;
        static double MarksInEng;
        static double MarksInMaths;
        static double MarksInScience;
        void TotalAndPercentage()
        {
            double TotalMarks = MarksInEng + MarksInMaths + MarksInScience;
            percentage = (TotalMarks * 100) / 300;
            Console.WriteLine("Total Marks= {0} ", TotalMarks);
            Console.WriteLine("Percentage= " + percentage);
        }
        public static void a7(String[] args)
        {
            Console.Write("Enter student RollNo: ");
            RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter student Name: ");
            StudName = Console.ReadLine();

            Console.Write("Enter student MarksInEnglish: ");
            MarksInEng = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter student MarksInMaths: ");
            MarksInMaths = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter student MarksInScience: ");
            MarksInScience = Convert.ToDouble(Console.ReadLine());

            Stu obj = new Stu();
            obj.TotalAndPercentage();
            Console.ReadLine();
        }
    }
}
