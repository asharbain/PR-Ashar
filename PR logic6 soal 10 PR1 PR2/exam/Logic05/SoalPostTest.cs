using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class SoalPostTest: LogicBase
    {
        public SoalPostTest(int n)
        {
            JmlBaris = n*2-1 ;
            JmlKolom = JmlBaris;
            Array2D= new string[JmlBaris,JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(JmlKolom * n + (n - 1));
            int angka = 0;
            bool kanan = true;
            for (int b = 0; b < JmlBaris; b++)
            {
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (b%2==0)
                    {
                        Array2D[b, kanan ? k : JmlKolom - 1 - k] = fibo[angka++].ToString();
                    }   
                    else if (b%2==1)
                    {
                        Array2D[b, kanan ? JmlKolom - 1 : 0] = fibo[angka].ToString();
                    }                     
                }
                if (b%2==1)
                {
                    angka++;
                    kanan = !kanan;
                }
            }
        }
    }
}
