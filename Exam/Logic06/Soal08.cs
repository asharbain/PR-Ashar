using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic06
{
    class Soal08 : LogicBase
    {
        public Soal08(int n)
        {
            JmlBaris = n * n;
            JmlKolom = n * n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int stBrs = bb * n;
                        int stKol = bk * n;
                        int endBrs = stBrs + n - 1;
                        int endKol = stKol + n - 1;
                        for (int b = stBrs; b <= endBrs; b++)
                        {
                            int angka = (n - n / 2) * (bk + 1);
                            for (int k = stKol; k <= endKol; k++)
                            {
                                if ((b - stBrs) + (k - stKol) >= n / 2 && (k - stKol) - (b - stBrs) <= n / 2 && b - stBrs <= n / 2)
                                {
                                    Array2D[b, k] = angka.ToString();
                                    Array2D[endBrs - (b - stBrs), k] = k - stKol < n / 2 ? angka--.ToString() : angka++.ToString();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
