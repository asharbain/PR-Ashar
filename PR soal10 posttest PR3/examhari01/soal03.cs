using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari01
{
    class soal03
    {
        public soal03(int n)
        {
            //baris
            for (int b = 0; b < n; b++)
            {
                //kolom
                for (int k = 0; k < n; k++)
                {
                    if (b == k || b + k == n - 1)
                    //pindah kolom
                    {
                    //Console.Write("{0}|{1}\t", b, k);
                    Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                //pindah baris
                Console.WriteLine("\n");
            }
        }
    }
}
