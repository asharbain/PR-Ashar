using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanLiveCode
{
    class Soal06 : LogicBase
    {
        public Soal06(int n)
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
                int stKol = (bgn * bgn + bgn) / 2;
                int endKol = stKol + bgn;
                int stBrs = JmlBaris - stKol - 1 - bgn;
                int endBrs = stBrs + bgn;
                bool kanan = true;
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (kanan)
                        {
                            Array2D[b, k] = angka++.ToString();
                        }
                        else
                        {
                            Array2D[b, endKol - k + stKol] = angka++.ToString();
                        }
                    }
                    kanan = !kanan;
                }
            }
        }
    }
}
