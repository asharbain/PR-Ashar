using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal05
{
    class soal05
    {
        public soal05()
        {
            //Console.WriteLine("Masukkan nilai n : ");
            //int n = int.Parse(Console.ReadLine());
            int n = 9;
            //baris
            for (int b = 0; b < n; b++)
            {
                //kolom
                for (int k = 0; k < n; k++)
                {
                    if (b == k || b + k == n - 1 || b == 0 || b == 8 || k == 0 || k == 8)
                    //pindah kolom
                    {

                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("tekan sembarang tombol");
            Console.ReadKey();
        }
    }
}
