using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLINQ
{
        public class order
        {

            public int Empolyee_ID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public long Phone { get; set; }
            public string Role { get; set; }

            public order()
            {

            }
            public order(int empolyee_ID, string name, string address, string email, long phone, string role)
            {
                Empolyee_ID = empolyee_ID;
                Name = name;
                Address = address;
                Email = email;
                Phone = phone;
                Role = role;
            }

            //List all empolyee
            public void ListAllEmpolyee()
            {
                Console.WriteLine("\n\t" + Empolyee_ID + "\t" + Name + "\t" + Email + "\t" + Phone + "\t" + Address + "\t" + Role);


            }

            //add new Empolyee
            public static List<order> Add_Employee(List<order> employee, order emp)
            {

                employee.Add(emp);
                return employee;

            }
        }
    
}
