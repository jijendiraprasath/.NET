using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    internal class Accounts
    {
        static int n, m;
        static string b, c;
        static long a1;
        static long accountno;
        static string customer_name, account_type, transaction_type;
        public static void show_data(long a, string CN, string Atype)
        {
            accountno = a;
            customer_name = CN;
            account_type = Atype;
            Console.WriteLine("Account number= " + accountno);
            Console.WriteLine("Customer Name= " + customer_name);
            Console.WriteLine("Account type= " + Atype);
        }
        public void credit(int amount)
        {
            Console.Write("Enter the balance:");
            int balance = Convert.ToInt32(Console.ReadLine());
            if (balance >= 0 && amount >= 0)
            {
                balance = balance + amount;
                Console.WriteLine("Balance after deposit: " + balance);
            }
            else if (balance < 0 && amount >= balance)
            {
                balance = balance + amount;
                Console.WriteLine("Balance after deposit: " + balance);
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
            Console.ReadLine();
        }
        public void debit(int amount)
        {
            int balance = Convert.ToInt32(Console.ReadLine());
            if (balance >= 0 && amount < balance)
            {
                balance = balance - amount;
                Console.WriteLine(" Balance after withdrawl : " + balance);
            }
            else if (balance >= 0 && amount > balance)
            {

                Console.WriteLine("Cannot Withdraw");
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
            Console.ReadLine();
        }
        public static void a2(String[] args)
        {
            Console.Write("Enter the Account Number:");
            a1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the Customer Name:");
            b = Console.ReadLine();
            Console.Write("Enter the Account Type:");
            c = Console.ReadLine();
            show_data(a1, b, c);
            Console.Write("Enter the transaction type: ");
            transaction_type = Console.ReadLine();
            if (transaction_type == "deposit")
            {
                Accounts obj = new Accounts();
                Console.Write("Enter the deposit amount :");
                n = Convert.ToInt32(Console.ReadLine());
                obj.credit(n);
            }
            else if (transaction_type == "withdraw")
            {
                Accounts obj1 = new Accounts();
                Console.Write("Enter the withdrawl amount:");
                m = Convert.ToInt32(Console.ReadLine());
                obj1.debit(m);

            }
            else
            {
                Console.Write("Invalid");
            }
            Console.ReadKey();
        }
    }
}
