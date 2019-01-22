using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic04
{
    class Soal07: LogicBase
    {
        public Soal07(int n)
        {
            JmlBaris = n;
            JmlKolom = n * 2 - 1;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray()
        {
            for (int b = 0; b < JmlBaris; b++)
            {
                int angka = 1;
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (b <= k && b + k <= JmlKolom - 1)
                    {
                        Array2D[b, k] = angka.ToString();
                        if (k < JmlKolom / 2)
                            angka += 2;
                        else
                            angka -= 2;
                    }
                }
            }
        }
    }
}
