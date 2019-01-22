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
            FunctionBase.CetakArray(Array2D);
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
    }
}
