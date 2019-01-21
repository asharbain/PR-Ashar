using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic03
{
    class Soal05: LogicBase
    {
        public Soal05(int n)
        {
            JmlBaris = n;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            CetakArray();
        }
        private void isiArray()
        {
            int[,] nomer5 = FunctionBase.nomor05(JmlBaris, JmlKolom);
                for (int b = 0 ; b < JmlBaris; b++)
                {
                    for (int k=0; k<JmlKolom; k++)
                    {
                    Array2D[b,k]= nomer5[b,k].ToString();
                    }
                }                
        }
        private void CetakArray()
        {
            for (int b = 0; b < Array2D.GetLength(0); b++)
            {
                for (int k = 0; k < Array2D.GetLength(1); k++)
                {
                    if (Array2D[b,k]== "0")
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
