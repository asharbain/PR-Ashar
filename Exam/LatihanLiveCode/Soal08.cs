using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanLiveCode
{
    class Soal08: LogicBase
    {
        public Soal08(int n)
        {
            JmlBaris= n ;
            JmlKolom= n*2-1;
            Array2D=new string[JmlBaris,JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(JmlKolom);
            int[] tribo = FunctionBase.Tribonacci(JmlKolom);
            int angka1 = 1;
            int angka2 = 1;
            for (int b = 0; b < JmlBaris; b++)
            {
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (b==k)
                    {
                        Array2D[b, k] = fibo[b].ToString();
                        Array2D[b, JmlKolom - 1 - k] = fibo[b].ToString();
                    }
                    else if (b+k==JmlBaris-1)
                    {
                        Array2D[b, k] = tribo[k].ToString();
                        Array2D[b, JmlKolom - 1 - k] = tribo[k].ToString();
                    }
                    else if (b >= k && b + k <= JmlBaris - 1 && b - k != 1 && b + k != JmlBaris - 2)
                    {
                        Array2D[b, k] = "A";
                        Array2D[b, JmlKolom - 1 - k] = "A";
                    }
                }
            }
        }
    }
}
