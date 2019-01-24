using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class SoalPR01 : LogicBase
    {
        public SoalPR01(int n)
        {
            JmlBaris = (n * n + n) / 2;
            JmlKolom = (n * n);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(n * n);
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = (bgn * bgn + bgn) / 2 + (n - bgn) * bgn;
                int stKol = (n - 1 - bgn) * (n - 1 - bgn);
                int angka = 0;
                int endBrs = stBrs + (n - 1 - bgn);
                int endKol = stKol + ((n - 1 - bgn) * 2);
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b + k >= stKol + endBrs && k + endBrs <= b + endKol)
                        {
                            Array2D[b, k] = fibo[angka++].ToString();
                        }
                    }

                }
            }
        }
    }
    }
