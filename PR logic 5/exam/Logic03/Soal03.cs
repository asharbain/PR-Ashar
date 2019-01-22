using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic03
{
    class Soal03: LogicBase
    {
        public Soal03(int n)
        {
            JmlBaris = 1;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            CetakArray();
        }
        private void isiArray()
        {
            int[] nomer3 = FunctionBase.nomor03(JmlKolom);
            for (int k = 0; k < JmlKolom; k++)
            {
                Array2D[0, k] = nomer3[k].ToString();
            }
        }
        private void CetakArray()
        {
            for (int b = 0; b < Array2D.GetLength(0); b++)
            {
                for (int k = 0; k < Array2D.GetLength(1); k++)
                {
                    Console.Write("{0}\t", Array2D[b, k]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
