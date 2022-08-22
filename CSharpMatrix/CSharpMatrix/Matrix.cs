using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMatrix
{
    internal class Matrix
    {
        public static void a2()
        {
            int[,] matrix = new int[3, 3];
            Console.Write("Enter the Numbers in the matrix : \n");
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    Console.Write("Location ({0},{1}) : ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("the matrix is :\n");
            {
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                        Console.Write("{0} ", matrix[i, j]);
                    Console.Write("\n");
                }
            }
        }
    }
}
