using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpString
{
    internal class One
    {
        public static void a1()
        {
            Console.WriteLine("---------------C# STRING---------------");
            Console.WriteLine("The quick brown fox jumps over the lazy dog");
            string s = "The quick brown fox jumps over the lazy dog";
            char c = s[12];
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("(a) Print the character at the 12th index -- {0}", c);
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(b) Check whether the String contains the word “is”");
            if (s.Contains("is")==true)
            {
                Console.WriteLine("Yes the string contains the word 'is'");
            }
            else
            {
                Console.WriteLine("No, the string doesn't contain the word 'is'");
            }
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(c) Add the string “and killed it” to the existing string");
            s += " and killed it";
            Console.WriteLine("Updated string value\n{0}", s);
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(d) Check whether the String ends with the word “dogs”");
            bool endsWith = s.EndsWith("dogs");
            Console.WriteLine("{0}, the string doesn't ends with the word 'dogs'", endsWith);
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(e) Check whether the String is equal to “The quick brown Fox jumps over the lazy Dog”");
            Console.WriteLine(endsWith.Equals(s));
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            string uc = s.ToUpper();
            Console.WriteLine("(f) UPPER CASE");
            Console.WriteLine(s.Equals(uc));
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(g) Lenght of string");
            int len = s.Length;
            Console.WriteLine(len);
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(h) Check whether the String matches to “The quick brown Fox jumps over the lazy Dog”");
            if (uc == s)
            {
                Console.WriteLine("Yes, the string matches");
            }
            else
            {
                Console.WriteLine("No, the string doesn't matches");
            }
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(i) Replace the word “The” with the word “A”");
            string new_s = s.Replace("The", "A");
            Console.WriteLine("Updated String value: {0}", new_s);
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(j) Split the above string into two such that two animal names do not come together");
            string[] seperators = { " " };
            string[] strsplit = new_s.Split(seperators, StringSplitOptions.None);
            foreach (string str in strsplit)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(k) Print the animal names alone separately from the above string.");
            string a = s.Substring(16, 3);
            string b = s.Substring(40, 3);
            Console.WriteLine("{0}, {1}", a, b);
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(l) Print the above string in completely lower case");
            Console.WriteLine("Lower Case string: {0}", s.ToLower());
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(m) Print the above string in completely upper case");
            Console.WriteLine("Upper Case string: {0}", s.ToUpper());
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(n) Find the index position of the character “a”");
            Console.WriteLine("Index position of a is {0}", s.IndexOf('a'));
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(o) Find the last index position of the character “e”");
            Console.WriteLine("Last index position of e is {0}", s.LastIndexOf('e'));
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Console.WriteLine("(q) Write a C# code that has a constant string that represents poem lines");
            Console.WriteLine("\nI WANDER'D lonely as a cloud\r\nThat floats on high o'er vales and hills, \r\nWhen all at once I saw a crowd,\r\nA host, of golden daffodils;Beside the lake, beneath the trees,\r\nFluttering and dancing in the breeze.\r\n");
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }
    }
}
