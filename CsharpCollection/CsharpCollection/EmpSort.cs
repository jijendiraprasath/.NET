using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollection
{
    internal class EmpSort
    {
        double EID;
        string EName;
        public static void a3()
        {

            List<EmpSort> EmpSortList = new List<EmpSort>()
            {
                new EmpSort { EID = 1001, EName = "Iron Man" },
                new EmpSort { EID = 1006, EName = "Spider Man" },
                new EmpSort { EID = 1002, EName = "Super Man" },
                new EmpSort { EID = 1005, EName = "Bat Man" },
                new EmpSort { EID = 1003, EName = "Joker" },
            };
            var result_set = EmpSortList.OrderBy(id => id.EID);
            foreach (EmpSort emp in result_set)
            {
                Console.WriteLine("Employee ID: {0} Employee Name: {1}", emp.EID, emp.EName);
            }
            Console.ReadKey();
        }
    }
}

