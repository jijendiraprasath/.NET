using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParameters
{
    internal class WordCount
    {
        public static void a2()
        {
            string sen;
            Console.WriteLine("\nEnter the word");
            sen = Console.ReadLine();
            var Value = sen.Split(' ');
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
            for (int i = 0; i < Value.Length; i++)
            {
                if (RepeatedWordCount.ContainsKey(Value[i]))
                {
                    int value = RepeatedWordCount[Value[i]];
                    RepeatedWordCount[Value[i]] = value + 1;
                }
                else
                {
                    RepeatedWordCount.Add(Value[i], 1);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Word Frequency");
            foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)
            {
                Console.WriteLine(kvp.Key + " occurs in " + kvp.Value + " position");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
