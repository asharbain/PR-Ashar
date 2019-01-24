using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari01
{
    class soal04
    {
        public soal04(int n)
        {
            //Console.Write("Masukan nilai n : ");

            //int n = int.Parse(Console.ReadLine());
            //int n = 9;
            //baris
            for (int b = 0; b < n; b++)
            {
                //kolom
                for (int k = 0; k < n; k++)
                {
                    if (b == k || b + k == n - 1 || b == 4 || k == 4)
                    //pindah kolom
                    {
                        //Console.Write("{0}|{1}\t", b, k);
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    //Console.Write("\t*");
                }
                //pindah baris
                Console.WriteLine("\n");
            }
        }
    }
}
