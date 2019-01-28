using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic07
{
    class Soal07: LogicBase
    {
        public Soal07(int n)
        {
            JmlBaris = n;
            JmlKolom = n * n + (n - 1);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int angka = 1;
                int nAngka = (n - 1) * 4;
                int stKol = (n + 1) * bgn;
                int endKol = stKol + n - 1;
                for (int b = 0; b < n; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b == 0 || k == endKol)
                            Array2D[b, k] = angka++.ToString();
                        else if (k == stKol || b == JmlBaris - 1)
                            Array2D[b, k] = nAngka--.ToString();
                    }
                }
            }
        }
    }
}
