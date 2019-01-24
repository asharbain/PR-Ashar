using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanLiveCode
{
    class Soal05: LogicBase
    {
        public Soal05(int n)
        {
            JmlBaris=(n*n+n)/2 ;
            JmlKolom=n*n ;
            Array2D=new string[JmlBaris,JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci((n * n) * 2);
            int angka=0;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = (bgn * bgn + bgn) / 2;
                int stKol = JmlKolom - ((bgn + 1) * (bgn + 1));
                int endBrs = stBrs + bgn;
                int endKol = stKol + (bgn * 2);

                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b + k == stKol + endBrs || k + endBrs == b + endKol || b==endBrs)
                            Array2D[b, k] = fibo[angka++].ToString();
                    }
                }
            }
        }
    }
}
