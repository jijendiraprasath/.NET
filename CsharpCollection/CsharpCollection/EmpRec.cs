using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollection
{
    internal class EmpRec
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public static void a6()
        {
            List<EmpRec> list = new List<EmpRec>()
            {
                new EmpRec() {Name="Jije", Designation="Project Manager"},
                new EmpRec() {Name="Prasath", Designation="Junior Programmer"},
                new EmpRec() {Name="J", Designation="Senior Programmer"},
                new EmpRec() {Name="P", Designation="Team Lead"},
                new EmpRec() {Name="Jijendiran", Designation="Program Manager"},
                new EmpRec() {Name="JP", Designation="Program Manager"},
                new EmpRec() {Name="EJ", Designation="Senior Programmer"},
                new EmpRec() {Name="PJ", Designation="Team Lead"},
                new EmpRec() {Name="JM", Designation="Junior Programmer"},
                new EmpRec() {Name="Jijendira Prasath M", Designation="Project Manager"},
            };
            string[] orders = { "Program Manager", "Project Manager", "Team Lead", "Senior Programmer", "Junior Programmer" };
            foreach(string order in orders)
            {
                Console.WriteLine("Employee with Designation {0}", order);
                foreach(EmpRec emp in list)
                {
                    if(emp.Designation==order)
                    {
                        Console.WriteLine(emp.Name);
                    }
                }
            }
        }
    }
}
