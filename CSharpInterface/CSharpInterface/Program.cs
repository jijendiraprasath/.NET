using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface
{
    internal class Program
    {
        public interface GovtRules
        {
            double EmployeePF(double basicSalary);
            string LeaVeDetails();
            double gratuityAmount(float serviceCompleted, double basicSalary);
        }
        public class c1 : GovtRules
        {
            public int EmpId { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }
            public string Desig { get; set; }
            public int BasicSalary { get; set; }

            public c1(int empId, string name, string dept, string desig, int basicSalary)
            {
                EmpId = empId;
                Name = name;
                Dept = dept;
                Desig = desig;
                BasicSalary = basicSalary;
            }

            public double EmployeePF(double basicSalary)
            {
                double pf = (0.12 * basicSalary) + ((8.33 / 100) * basicSalary) + ((3.67 / 100) * basicSalary);
                return pf;
            }

            public string LeaVeDetails()
            {
                string g = "Casual Leave per month: 1day " +
                    "\nSick Leave per year: 12days" +
                    "\nPrevilage Leave per year:10days";
                return g;
            }

            public double gratuityAmount(float serviceCompleted, double basicSalary)
            {
                if (serviceCompleted > 5 && serviceCompleted <= 10)
                {
                    return basicSalary;
                }
                else if (serviceCompleted > 10 && serviceCompleted <= 20)
                {
                    return 2 * basicSalary;
                }
                else if (serviceCompleted < 5 && serviceCompleted > 20)
                {
                    return 0 * basicSalary;
                }
                else
                {
                    return 3 * basicSalary;
                }
            }

        }
        public class c2 : GovtRules
        {
            public int EmpId { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }
            public string Desig { get; set; }
            public int BasicSalary { get; set; }

            public c2(int empId, string name, string dept, string desig, int basicSalary)
            {
                EmpId = empId;
                Name = name;
                Dept = dept;
                Desig = desig;
                BasicSalary = basicSalary;
            }

            public double EmployeePF(double basicSalary)
            {
                double pf = (0.12 * basicSalary) + (0.12 * basicSalary);
                return pf;
            }

            public string LeaVeDetails()
            {
                string g = "Casual Leave per month: 2day " +
                    "\nSick Leave per year: 5days  " +
                    "\nPrevilage Leave per year:5days";
                return g;
            }

            public double gratuityAmount(float serviceCompleted, double basicSalary)
            {
                return 0;
            }
        }
        internal class program
        {
            public static void Main(string[] args)
            {
                c1 t = new c1(12, "DER", "DELIVERY", "ASS", 2000);
                string r = t.LeaVeDetails();
                Console.WriteLine(r);

                double v = t.gratuityAmount(20f, 2000);
                Console.WriteLine(v);

                c2 a = new c2(12, "DER", "DELIVERY", "ASS", 2000);
                string s = a.LeaVeDetails();
                Console.WriteLine(s);
            }
        }
    }
}
