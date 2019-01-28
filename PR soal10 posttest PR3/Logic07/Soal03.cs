using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic07
{
    class Soal03: LogicBase
    {
        public Soal03(int n)
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
                int stBrs = bgn * 2;
                int stKol = stBrs;
                for (int b = stBrs; b < JmlBaris; b++)
                {
                    for (int k = stKol; k <= tengah; k++)
                    {
                        if (b==stBrs || k==stKol)
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
