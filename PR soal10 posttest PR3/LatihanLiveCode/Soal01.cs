using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanLiveCode
{
    class Soal01: LogicBase
    {
        public Soal01(int n)
        {
            JmlBaris = n;
            JmlKolom = n * 2 - 1;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(n * n);
            int angka = 0;
            for (int b = 0; b < JmlBaris; b++)
            {
                for (int k = 0; k < JmlKolom; k++)
                {
                    if(b+k>=JmlBaris-1 &&  k-b<=JmlBaris-1)
                    {
                        Array2D[b, k] = fibo[angka++].ToString();
                    }
                }
            }               
        }
    }
}
