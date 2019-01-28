using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic07
{
    class Soal05: LogicBase
    {
        public Soal05(int n)
        {
            JmlBaris = n * 2 + 1;
            JmlKolom = n * 2 + (n * 2 - 1);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int tengah = JmlKolom / 2;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int angka = 1;
                int stBrs = bgn * 2;
                int stKol = stBrs;
                for (int b = stBrs; b < JmlBaris; b++)
                {
                    for (int k = stKol; k <= tengah; k++)
                    {
                        if ( k == stKol)
                        {
                            Array2D[b, k] = (JmlBaris-b).ToString();
                            Array2D[b, JmlKolom - 1 - k] = (JmlBaris - b).ToString();
                        }
                        else if (b == stBrs)
                        {
                            Array2D[b, k] = angka.ToString();
                            Array2D[b, JmlKolom - 1 - k] = angka.ToString();
                            angka++;
                        }
                    }
                }
            }
        }
    }
}
