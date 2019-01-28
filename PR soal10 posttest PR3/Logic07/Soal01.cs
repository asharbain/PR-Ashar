using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic07
{
    class Soal01: LogicBase
    {
        public Soal01(int n)
        {
            JmlBaris= n*2 + (n * 2 - 1) ;
            JmlKolom = n * 2 + (n * 2 - 1);
            Array2D=new string[JmlBaris,JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int b = 0; b < JmlBaris; b++)
            {
                for (int k = 0; k < JmlKolom; k++)
                {
                    //atas
                    if (b+k>=n*2-1&&k-b<=n*2-1&b<=n-1)
                    {
                        Array2D[b, k] = "A";
                    }
                        //bawah
                    else if (b-k<=n*2-1&&b+k<=(n*2-1)+(n*3)+n-2&&b>=JmlBaris-n)
                    {
                        Array2D[b, k] = "B";
                    }
                        //kiri
                    else if (b+k>=n*2-1&&b-k<=n*2-1&&k<=n-1)
                    {
                        Array2D[b, k] = "C";
                    }
                    else if (k-b<=n*2-1 && b+k<=(n*2-1)+(n*3)+n-2 && k>=JmlKolom-n)
                    {
                        Array2D[b, k] = "D";
                    }
                }
            }
        }
    }
}
