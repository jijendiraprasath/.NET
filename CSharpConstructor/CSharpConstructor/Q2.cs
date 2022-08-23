using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructor
{
    internal class Q2
    {
        public class Building
        {

            public string type;
            public string capacity;
            public int flatNo;
            public string dimension;
            public string dateOfCompletion;

            public Building(string type, string capacity, int flatNo, string dimension, string dateOfCompletion)
            {
                this.type = type;
                this.capacity = capacity;
                this.flatNo = flatNo;
                this.dimension = dimension;
                this.dateOfCompletion = dateOfCompletion;
            }



            public void ShowData()
            {
                Console.WriteLine("\nType: " + type);
                Console.WriteLine("Capacity: " + capacity);
                Console.WriteLine("Flat Number: " + flatNo);
                Console.WriteLine("Flat Dimensions: " + dimension);
                Console.WriteLine("DateOfCompletion: " + dateOfCompletion);

            }

        }

        public static void a2()
        {
            Building buildingObj = new Building("Flat", "3BHK", 200, "20*30*, 60*40, 30*40", "31-12-2030");
            buildingObj.ShowData();
            Console.ReadKey();
        }
    }
}
