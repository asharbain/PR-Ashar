using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Logic 07---");
            Console.Write("Masukkan Nilai n : ");
            int n = int.Parse(Console.ReadLine());

            //Soal01 soal01 = new Soal01(n);
            //Soal02 soal02 = new Soal02(n);
            //Soal03 soal03 = new Soal03(n);
            //Soal04 soal04 = new Soal04(n);
            //Soal05 soal05 = new Soal05(n);
            //Soal06 soal06 = new Soal06(n);
            //Soal07 soal07 = new Soal07(n);


            Console.Write("Masukkan Nilai n2 : ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nilai n3 : ");
            int n3 = int.Parse(Console.ReadLine());
            Soal08 soal08 = new Soal08(n,n2,n3);
            //Soal09 soal09 = new Soal09(n);
            //Soal10 soal10 = new Soal10(n);
            //SoalPostTest po = new SoalPostTest(n);
            //SoalPR03 pr03 = new SoalPR03(n);


            Console.Write("Tekan sembarang tombol...");
            Console.ReadKey();

        }
    }
}
