using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic04
{
    class Soal09 : LogicBase
    {
        public Soal09(int n1, int n2)
        {
            JmlBaris = n1;
            JmlKolom = (n1 * n2) - (n2 - 1);
            Array2D = new string[JmlBaris, JmlKolom];
            IsiArray(n2);
            CetakArray();
        }

        private void IsiArray(int n2)
        {
            for (int bangun = 0; bangun < n2; bangun++)
            {
                for (int b = 0; b < JmlBaris; b++)
                {
                    int angka = 1;
                    for (int k = 0; k < JmlKolom; k++)
                    {
                        if (b + k >= (JmlBaris - 1) / 2 && k - b <= (JmlBaris - 1) / 2 && b <= JmlBaris / 2)
                        {
                            Array2D[b, k + (JmlBaris - 1) * bangun] = angka.ToString();
                            Array2D[JmlBaris - 1 - b, k + (JmlBaris - 1) * bangun] = angka.ToString();
                            if (k < JmlBaris / 2)
                            {
                                angka += 2;
                            }
                            else
                            {
                                angka -= 2;
                            }
                        }
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
