using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructor
{
    internal class Q1
    {
        class Person
        {
            public string FName;
            public string LName;
            public string Email;
            public DateTime DOB;

            public Person(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth)
            {
                FName = FirstName;
                LName = LastName;
                Email = EmailAddress;
                DOB = DateOfBirth;
            }
        }

        public static void a1()
        {
            Person Male = new Person("Jijendira", "Prasath", "prasathjijendira@gmail.com", new DateTime(1999, 04, 09));
            Person Female = new Person("J", "P", "pj@gmail.com", new DateTime(2000, 01, 01));

            Console.WriteLine(Male.FName + " " + Male.LName + " " + Male.Email + " " + Male.DOB);
            Console.WriteLine(Female.FName + " " + Female.LName + " " + Female.Email + " " + Female.DOB);
            Console.ReadKey();

        }
    }
}
