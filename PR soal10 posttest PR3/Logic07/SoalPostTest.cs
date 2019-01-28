using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic07
{
    class SoalPostTest: LogicBase
    {
        public SoalPostTest(int n)
        {
            JmlBaris = n*n;
            JmlKolom = n*n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(n * n);
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int angka = 0;
                        int nAngka = n * 2 + (n - 2) * 2 - 1;
                        int stBrs = bb * n;
                        int stKol = bk * n;
                        int endBrs = stBrs + n - 1;
                        int endKol = stKol + n - 1;
                        for (int b = stBrs; b <= endBrs; b++)
                        {
                            for (int k = stKol; k <= endKol; k++)
                            {
                                if (b == stBrs || k == endKol)
                                    Array2D[b, k] = fibo[angka++].ToString();
                                else if (b == endBrs || k == stKol)
                                    Array2D[b, k] = fibo[nAngka--].ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}
