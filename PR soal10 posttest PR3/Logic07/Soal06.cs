using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic07
{
    class Soal06: LogicBase
    {
        public Soal06(int n)
        {
            JmlBaris = n;
            JmlKolom = (n * n) + (n - 1);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stKol = bgn * (n + 1);
                int endKol = stKol+n-1;
                for (int b = 0; b < JmlBaris; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b == 0 || b == JmlBaris - 1 || k == stKol || k == endKol)
                            Array2D[b, k] = "*";
                    }
                }
            }
        }
    }
}
