using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanLiveCode
{
    class Soal07: LogicBase
    {
        public Soal07(int n)
        {
            JmlBaris= (n*n+n)/2 ;
            JmlKolom= n*2-1 ;
            Array2D=new string[JmlBaris,JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {

            int[] fibo = FunctionBase.Fibonacci(JmlKolom * n);
            int[] tribo = FunctionBase.Tribonacci(JmlKolom * n);
            int angka1 = 0;
            int angka2 = 0;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = (bgn * bgn + bgn) / 2;
                int stKol = ((n * 2 - 1) / 2) - bgn;
                int endBrs = stBrs + bgn;
                int endkol = stKol + (bgn * 2);                
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endkol; k++)
                    {
                        if (b + k == stKol + endBrs || k + endBrs == b + endkol || b==endBrs)
                        {                            
                            if (bgn % 2 == 0)
                            {
                                Array2D[b, k] = fibo[angka1++].ToString();                                
                            }
                            else
                            {
                                Array2D[b, k] = tribo[angka2++].ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}
