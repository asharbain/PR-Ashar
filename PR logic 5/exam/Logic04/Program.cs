using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Logic 04 ---");
            //while
            Console.Write("Masukkan Nilai n1 : ");
            int n1 = int.Parse(Console.ReadLine());
            //Console.Write("Masukkan Nilai n2: ");
            //int n2 = int.Parse(Console.ReadLine());
            //Soal01 soal01 = new Soal01(n1);
            //Soal02 soal02 = new Soal02(n1);
            //Soal03 soal03 = new Soal03(n1);
            Soal04 soal04 = new Soal04(n1);
            //Soal05 soal05 = new Soal05(n1);            
            //Soal06 soal06 = new Soal06(n1);
            //Soal07 soal07 = new Soal07(n1);
            //Soal08 soal08 = new Soal08(n1);
            //Soal09 soal09 = new Soal09(n1,n2);
            //Soal10 soal10 = new Soal10(n1, n2);
            Console.Write("Tekan sembarang tombol...");
            Console.ReadKey();
        }
    }
}
