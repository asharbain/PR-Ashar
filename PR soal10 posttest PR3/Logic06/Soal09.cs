using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic06
{
    class Soal09 : LogicBase
    {
        public Soal09(int n)
        {
            JmlBaris = n + 2;
            JmlKolom = (n * 3) + (n * (n - 1) / 2);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int angka = 1;
            int deret = 1;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = n - bgn - 1;
                int stKol = (bgn * 3) + (bgn * (bgn - 1) / 2);
                int endBrs = n + 1;
                int endKol = stKol + 2 + bgn;
                for (int b = stBrs; b <= endBrs; b++)
                {
                    angka = deret;
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b + k == stBrs + endKol || k == endKol || b == endBrs)

                        Array2D[b, k] = angka.ToString();
                        angka++;
                    }
                }
                deret = angka;
            }
        }
    }
}
