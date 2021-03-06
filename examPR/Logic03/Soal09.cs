﻿using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic03
{
    class Soal09: LogicBase
    {
        public Soal09(int n)
        {
            JmlBaris = n;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            CetakArray();
        }

        private void isiArray()
        {
            int[] fibo = FunctionBase.nomor09(JmlBaris / 2);
                for (int b=0; b<JmlBaris; b++)
                {
                    for (int k=0; k<JmlKolom; k++)
                    {
                        //atas
                        if (b<=k && b+k<=JmlBaris-1&& b%2==0)
                        {
                            //GARIS BAWAH
                            Array2D[b,k]= fibo[b/2].ToString();
                            //GARIS BAWAH - MIRROR
                            Array2D[JmlBaris - 1 - b,k]= fibo[b/2].ToString();
                        }
                        else if (b >= k && b + k <= JmlBaris - 1 && k % 2 == 0)
                        {
                            //GARIS BAWAH
                            Array2D[b,k]= fibo[k/2].ToString();
                            //GARIS BAWAH - MIRROR
                            Array2D[b, JmlKolom - 1 - k]= fibo[k/2].ToString();
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
