using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic07
{
    class Soal02: LogicBase
    {
        public Soal02(int n)
        {
            JmlBaris = n * 2 + (n * 2 - 1);
            JmlKolom = n * 2 + (n * 2 - 1);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[]fibo = FunctionBase.Fibonacci(n*n);
            int[] tribo = FunctionBase.Tribonacci(n * n);
            int fb = 0;
            int tb = 0;
            int ganjil = 1;
            for (int b = 0; b < JmlBaris; b++)
            {
                for (int k = 0; k < JmlKolom; k++)
                {
                    //atas
                    if (b + k >= n * 2 - 1 && k - b <= n * 2 - 1 & b <= n - 1 || 
                        b - k <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && b >= JmlBaris - n)
                    {
                        Array2D[b, k] = ganjil.ToString();
                        ganjil += 2;
                    }
                    //bawah
                    //else if (b - k <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && b >= JmlBaris - n)
                    //{
                    //    Array2D[b, k] = "B";
                    //}
                    //kiri
                    else if (b + k >= n * 2 - 1 && b - k <= n * 2 - 1 && k <= n - 1)
                    {
                        Array2D[b, k] = fibo[fb++].ToString();
                    }
                    else if (k - b <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && k >= JmlKolom - n)
                    {
                        Array2D[b, k] = tribo[tb++].ToString();
                    }
                }
            }
        }
    }
}
