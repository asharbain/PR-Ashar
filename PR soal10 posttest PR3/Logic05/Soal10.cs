﻿using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal10: LogicBase
    {
        public Soal10(int n)
        {
            JmlBaris = (n * n + n) / 2;
            JmlKolom = n * 2 - 1;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(JmlKolom*n);
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = (bgn * bgn + bgn) / 2;
                int stKol = ((n * 2 - 1) / 2) - bgn;
                int endBrs = stBrs + bgn;
                int endkol = stKol + (bgn * 2);
                int ganjil = 1;
                int angka = 0;
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endkol; k++)
                    {
                        if (b + k >= stKol + endBrs && k + endBrs <= b + endkol)
                        {
                            if ( bgn%2==0)
                            {
                                Array2D[b, k] = ganjil.ToString();
                                ganjil += 2;
                            }
                            else
                            {
                                Array2D[b, k] = fibo[angka++].ToString();
                            }
                        }                            
                    }
                }
            }
        }        
    }
}
