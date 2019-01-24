using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanLiveCode
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
        {
            JmlBaris = (n * n + n) / 2;
            JmlKolom = (n * n + n) / 2;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int angka = 1;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = (bgn * bgn + bgn) / 2;
                int stKol = JmlKolom - 1 - stBrs - bgn;
                int endBrs = stBrs + bgn;
                int endKol = stKol + bgn;
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b - stBrs <= k - stKol)
                            Array2D[b, k] = angka++.ToString();
                    }
                }
            }
        }
    }
}
