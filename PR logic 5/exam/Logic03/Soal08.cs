using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic03
{
    class Soal08: LogicBase
    {
        public Soal08(int n)
        {
            JmlBaris = n;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            CetakArray();
        }

        private void isiArray()
        {
            int[] fibo = FunctionBase.Fibonacci(JmlKolom/2);
            for (int b=0; b<JmlBaris; b++)
            {
                for (int k=0; k<JmlKolom; k++)
                {
                    if (b<=k && b+k<=JmlBaris-1 && b%2==0)
                    {
                        Array2D[b,k]= (b+1).ToString();
                        Array2D[JmlBaris-1-b,k]=(b+1).ToString();
                    }
                    else if (b>=k && b+k <=JmlBaris-1&& k%2==0)
                    {
                        Array2D[b,k]= (k+1).ToString();
                        Array2D[b, JmlKolom - 1 - k]=(k+1).ToString();
                    }
                }

            }
        }

        private void CetakArray()
        {
            for (int b = 0; b < Array2D.GetLength(0); b++)
            {
                for (int k = 0; k < Array2D.GetLength(1); k++)
                {
                    if (Array2D[b, k] == "0")
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write("{0}\t", Array2D[b, k]);
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
