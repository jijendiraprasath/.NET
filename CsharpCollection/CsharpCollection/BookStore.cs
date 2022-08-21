using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CsharpCollection
{
    internal class BookStore
    {
        public static void a4()
        {
            Console.WriteLine("Book Details");
            Hashtable mytable = new Hashtable();
            mytable.Add("15467", "How to Code");
            mytable.Add("78945", "The Alchemist");
            mytable.Add("98567", "Wings of Fire");
            foreach (DictionaryEntry a in mytable)
            {
                Console.WriteLine("Book ID: {0} | Book Name: {1}", a.Key, a.Value);
            }
            Console.ReadKey();
        }
    }
}
