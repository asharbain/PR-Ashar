using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic03
{
    class Soal07: LogicBase
    {
        public Soal07(int n)
        {
            JmlBaris = n;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            CetakArray();
        }

        private void isiArray()
        {
            int[] fibo = FunctionBase.Fibonacci(JmlBaris);
            for (int b = 0; b < JmlBaris; b++)
            {
                for (int k = 0; k < JmlKolom; k++)
                {                    
                    if (b <= k && b + k <= JmlBaris - 1)
                    {
                        Array2D[b, k] = fibo[b].ToString();                        
                        Array2D[JmlBaris - 1 - b, k] = fibo[b].ToString();
                    }
                    else if (b >= k && b + k <= JmlBaris - 1)
                    {
                        Array2D[b, k] = fibo[k].ToString();
                        Array2D[b, JmlKolom - 1 - k] = fibo[k].ToString();
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
