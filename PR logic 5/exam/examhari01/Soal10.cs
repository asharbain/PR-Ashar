using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari01
{
    class Soal10
    {
        public Soal10(int n)
        {
            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if ((b <= k && b >= n / 2) || (b >= k && b <= n / 2))
                        Console.Write("*\t");
                    else
                        Console.Write("\t");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
