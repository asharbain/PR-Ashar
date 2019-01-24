using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 9;
            //int j = 3;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("\t{0}{1}", i, j);
            //}
            //Console.ReadKey();

            Console.Write("Msukkan nilai n : ");
            int val = int.Parse(Console.ReadLine());
            //soal01 soal1 = new soal01(val);
            //soal02 soal2 = new soal02(val);
            //soal03 soal3 = new soal03(val);
            //soal04 soal4 = new soal04(val);
            //soal05 soal5 = new soal05(val);
            //soal06 soal6 = new soal06(val);
            //soal07 soal7 = new soal07(val);
            //soal08 soal8 = new soal08(val);
            //soal09 soal9 = new soal09(val);
            Soal10 soal10 = new Soal10(val);
            //ganjalan
            Console.Write("tekan sembarang tombol");
            Console.ReadKey();
        }
    }
}
