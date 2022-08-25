using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    internal class Bankaccount
    {
        static int n, m, d;
        static string a, c;
        static long b;
        static String NameoftheDepositor;
        static long AccountNumber;
        static string Typeofaccount;
        static int Balanceamount_in_the_account;

        void initialvalues(string name, long AccNo, string type, int balance)
        {
            NameoftheDepositor = name;
            Console.WriteLine("Name of the depositor is" + NameoftheDepositor);

            AccountNumber = AccNo;
            Console.WriteLine(" AccountNumber = {0}", AccNo);
            Typeofaccount = type;
            Console.WriteLine("Typeofaccount= {0}", type);
            Balanceamount_in_the_account = balance;
            Console.WriteLine("Balanceamount_in_the_account= {0}", balance);
            Console.ReadLine();

        }
        public void deposit(int amount)
        {
            if (amount > 0)
            {
                Balanceamount_in_the_account = Balanceamount_in_the_account + amount;
                Console.WriteLine("Balance after depositing = " + Balanceamount_in_the_account);
            }
            else
            {
                Console.WriteLine("Cannot deposit negative balance");
            }
            Console.ReadLine();
        }
        public void withdraw(int withdrawn_Amount)
        {
            if (Balanceamount_in_the_account <= 0 || withdrawn_Amount < 0)
            {
                Console.WriteLine("Invalid amount");
            }
            else
            {
                Balanceamount_in_the_account = Balanceamount_in_the_account - withdrawn_Amount;
                Console.WriteLine("Balance after withdrawl= " + Balanceamount_in_the_account);
            }
            Console.ReadLine();

        }
        public static void a6(string[] args)
        {
            Bankaccount obj = new Bankaccount();
            Console.Write("Enter the name of depositor: ");
            a = Console.ReadLine();
            Console.Write("Enter the account number: ");
            b = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the type of account: ");
            c = Console.ReadLine();
            Console.Write("Enter the balance: ");
            d = Convert.ToInt32(Console.ReadLine());
            obj.initialvalues(a, b, c, d);

            Bankaccount obj1 = new Bankaccount();
            Console.Write("Enter the value of deposit amount");
            n = Convert.ToInt32(Console.ReadLine());
            obj1.deposit(n);
            Console.WriteLine("Enter the value of withdrawn amount");
            m = Convert.ToInt32(Console.ReadLine());

            Bankaccount obj2 = new Bankaccount();
            obj2.withdraw(m);
            Console.ReadLine();
        }
    }
}
