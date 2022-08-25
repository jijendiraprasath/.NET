using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
        public class Furniture
        {
            public int OrderId;
            public string OrderDate;
            public int TotalQnty;
            public double TotalAmt;
            public string PaymentMode;
            public string FurnitureType;

            public void GetData()
            {
                OrderId = 23;
                OrderDate = "05-11-2000";
                FurnitureType = "Chair";
                TotalQnty = 3;
                TotalAmt = 1200;
                PaymentMode = "debit";

            }
            public void ShowData()
            {
                Console.WriteLine("Order ID:{0}" +
                    "\nDate:{1}" +
                    "\nFurniture type:{2}" +
                    "\nQuantity:{3}" +
                    "\nTotal Amount:{4}" +
                    "\nPayment mode:{5}", OrderId, OrderDate, FurnitureType, TotalQnty, TotalAmt, PaymentMode);
            }
        }
        public class Chair : Furniture
        {
            string chairtype, purpose;
            public double rate;


            public void GetChairData()
            {
                GetData();
                chairtype = "steel";
                purpose = "home";
                rate = 100;

            }
            public void ShowChairData()
            {
                ShowData();
                Console.WriteLine("Chair type:{0}" +
                    "\nPurpose:{1}" +
                    "\nRate:{2}", chairtype, purpose, rate);
                if (chairtype == "wood")
                    Console.WriteLine("Wood Type would be Teak Wood/Rose Wood\n");
                else if (chairtype == "steel")
                    Console.WriteLine("It would be Gray Steel/Green Steel/Brown Steel\n");
                else if (chairtype == "plastic")
                    Console.WriteLine("Plastic Color would be Green/Red/Blue/White\n");
            }

        }
        public class Cot : Furniture
        {
            string cottype, capacity;
            public double rate;

            public void GetCotData()
            {
                GetData();
                cottype = "wood";
                capacity = "Single";
                rate = 1000;

            }
            public void ShowCotData()
            {
                ShowData();
                Console.WriteLine("Cot type:{0}\nCapacity:{1}\nRate:{2}", cottype, capacity, rate);
                if (cottype == "wood")
                    Console.WriteLine("Wood Type would be Teak Wood/Rose Wood");
                else if (cottype == "steel")
                    Console.WriteLine("It would be Gray Steel/Green Steel/Brown Steel");
            }
        }
        internal class Program
        {
            private static void Main(string[] args)
            {
                Chair obj = new Chair();
                obj.GetChairData();
                obj.ShowChairData();

                Cot obj2 = new Cot();
                obj2.GetCotData();
                obj2.ShowCotData();

            }
        }
}
