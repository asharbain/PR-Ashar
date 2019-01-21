using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic04
{
    class Soal08: LogicBase
    {
        public Soal08(int n)
        {
            JmlBaris = n;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            CetakArray();
        }

        private void isiArray()
        {
            for (int b = 0; b < JmlBaris; b++)
            {
                int angka = 1;
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (b + k >= JmlBaris / 2 && k - b <= JmlBaris / 2 && b <= JmlBaris / 2)
                    {
                        Array2D[b, k] = angka.ToString();
                        Array2D[JmlBaris - 1 - b, k] = angka.ToString();                        
                        if (k < JmlKolom / 2)
                            angka += 2;
                        else
                            angka -= 2;                        
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
