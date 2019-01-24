using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanLiveCode
{
    class Soal02: LogicBase
    {
        public Soal02(int n)
        {
            JmlBaris= n ;
            JmlKolom= n;
            Array2D= new string[JmlBaris,JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo=FunctionBase.Fibonacci(n*n);
            int[] tribo=FunctionBase.Tribonacci(n*n);
            int angka = 0;
            int ascii = 65;
            for (int b = 0; b < JmlBaris; b++)
            {
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (b==JmlBaris/2)
                    {
                        Array2D[b,k]= ((char)ascii).ToString();
                        if (k < JmlBaris / 2)
                            ascii++;
                        else
                            ascii--;
                        angka = 0;
                    }
                    else if (b+k>=JmlBaris/2 && k-b<=JmlBaris/2 && b<JmlBaris/2)
                    {
                        Array2D[b, k] = fibo[angka++].ToString();                        
                    }
                    else if (b-k<=JmlBaris/2 && b+k<=JmlKolom/2 + JmlKolom-1 && b>JmlBaris/2)
                    {
                        Array2D[b, k] = tribo[angka++].ToString();
                    }
                }
            }
        }
    }
}
