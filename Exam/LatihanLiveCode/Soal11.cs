using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanLiveCode
{
    class Soal11: LogicBase
    {
        public Soal11(int n)
        {
            JmlBaris = (n * n + n) / 2;
            JmlKolom = (n * n);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(n * n * 2);
            int[] tribo = FunctionBase.Tribonacci(n * n * 2);
            int fb = 0;
            int tb = 0;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = JmlBaris-1-(bgn*bgn+bgn)/2 -bgn;
                int stKol = JmlKolom-1-(bgn*bgn)-bgn*2 ;
                int endBrs = stBrs+bgn ;
                int endKol = stKol+bgn*2;
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stBrs; k <= endKol; k++)
                    {
                        if(b-stBrs <= k - stKol && (b-stBrs) + (k-stKol) <= endKol - stKol)
                            Array2D[b,k]= bgn%2==0 ? tribo[tb++].ToString() : fibo[fb++].ToString();
                    }
                }
            }
        }
    }
}
