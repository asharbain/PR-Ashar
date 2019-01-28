using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic03
{
    class Soal10: LogicBase
    {
        public Soal10(int n)
        {
            JmlBaris = n;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray()
        {
            int[] fibo = FunctionBase.Fibonacci(JmlBaris / 2);
            int ascii = 64;
            for (int b = 0; b <JmlBaris; b++)
            {
                for (int k = 0; k <JmlKolom; k++)
                {
                    //atas
                    if (b <= k && b + k <= JmlBaris - 1)
                    {
                        //if (b % 2 == 0)
                        //{
                        //    Array2D[b, k] = fibo[b / 2].ToString();
                        //    Array2D[JmlBaris - 1 - b, k] = fibo[b / 2].ToString();
                        //}
                        //else
                        //{
                        //    Array2D[b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        //    Array2D[JmlBaris - 1 - b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        //}
                        Array2D[b, k] =
                            b % 2 == 0 ? fibo[b / 2].ToString() :
                            ((char)(ascii + (b + 1) / 2)).ToString();
                        //mirror
                        Array2D[JmlBaris - 1 - b, k] =
                            b % 2 == 0 ? fibo[b / 2].ToString() :
                            ((char)(ascii + (b + 1) / 2)).ToString();
                    }
                    //kiri
                    else if (b >= k && b + k <= JmlBaris - 1)
                    {
                        //Array2D[b, k] = fibo[k / 2].ToString();
                        //Array2D[b, JmlKolom - 1 - k] = fibo[k / 2].ToString();
                        Array2D[b, k] =
                            k % 2 == 0 ? fibo[k / 2].ToString() :
                            ((char)(ascii + (k + 1) / 2)).ToString();
                        //mirror
                        Array2D[b, JmlKolom - 1 - k] =
                            k % 2 == 0 ? fibo[k / 2].ToString() :
                            ((char)(ascii + (k + 1) / 2)).ToString();
                    }
                }
            }
        }
    }
}
