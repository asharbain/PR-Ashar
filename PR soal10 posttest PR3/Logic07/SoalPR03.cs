using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic07
{
    class SoalPR03: LogicBase
    {
        public SoalPR03(int n)
        {
            JmlBaris = n * 2 + 1;
            JmlKolom = n * 2 + (n * 2 - 1);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stKol = bgn * 2;
                int endBrs = JmlBaris - 1 - bgn * 2;
                int endKol = JmlKolom - 1 - stKol;
                int angka = 1;
                int nAngka = (endBrs) * 2 + (endKol - stKol) + 1;
                for (int b = 0; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b == endBrs || k == stKol)
                            Array2D[b, k] =angka++.ToString();
                        else if (k == endKol)
                        {
                            Array2D[b, k] =nAngka--.ToString();
                        }
                    }
                }
            }
        }
    }
}
