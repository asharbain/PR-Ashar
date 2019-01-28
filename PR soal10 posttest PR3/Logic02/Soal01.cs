using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic02
{
    class Soal01
    {
        public Soal01(int n)
        {
            CetakPola(n, n);
        }

        private void CetakPola(int jB, int jK)
        {            
            int ganjil = 1;
            //baris
            for (int b=0; b<jB; b++)
            {
                //kolom
                for (int k = 0; k<jK; k++)
                {
                    if (b==k)
                    {
                        Console.Write("{0}\t", ganjil);
                        ganjil += 2;
                    }
                    //prepare yg kosong
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
