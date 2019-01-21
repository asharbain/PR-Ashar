using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic04
{
    class Soal04: LogicBase
    {
        public Soal04(int n)
        {
            JmlBaris = n;
            JmlKolom = n * 2 - 1;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            CetakArray();
        }

        private void isiArray()
        {
            for (int b = 0; b < JmlBaris; b++)
            {
                int angka = 65;
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (b + k >= JmlBaris - 1 && k - b <= JmlBaris - 1)
                    {
                        Array2D[b, k] = ((char)angka++).ToString();
                    }
                }

            }
        }

        private void CetakArray()
        {
            for (int b = 0; b < Array2D.GetLength(0); b++)
            {
                for (int k = 0; k < Array2D.GetLength(1); k++)
                {
                    if (Array2D[b, k] == "0")
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write("{0}\t", Array2D[b, k]);
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
