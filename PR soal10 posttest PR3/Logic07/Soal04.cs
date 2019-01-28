using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic07
{
    class Soal04: LogicBase
    {
        public Soal04(int n)
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
                int endBrs = JmlBaris-1-(bgn*2) ;
                int stKol = bgn*2;
                for (int b = 0; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= tengah; k++)
                    {
                        if (b == endBrs || k == stKol)
                        {
                            Array2D[b, k] = "*";
                            Array2D[b, JmlKolom - 1 - k] = "*";
                        }
                    }
                }
            }
        }
    }
}
