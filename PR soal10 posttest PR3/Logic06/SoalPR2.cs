using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic06
{
    class SoalPR2: LogicBase
    {
        public SoalPR2(int n)
        {
            JmlBaris = n + 2;
            JmlKolom = 3 * n + (n * (n - 1) / 2);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = n - bgn - 1;
                int stKol = JmlKolom-1-(bgn * 3 + (bgn * (bgn - 1) / 2))-(bgn+2) ;
                int endBrs = n + 1;
                int endKol = stKol + 2 + bgn;
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if ((b - stBrs) + (k - stKol) == endKol - stKol || b == stBrs || k == stKol)
                            Array2D[b, k] = (JmlKolom - k).ToString();
                    }
                }
            }
        }
    }
}
