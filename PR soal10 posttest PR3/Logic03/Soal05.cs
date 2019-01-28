using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic03
{
    class Soal05 : LogicBase
    {
        public Soal05(int n)
        {
            JmlBaris = n;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            FunctionBase.CetakArray(Array2D);
        }
        private void isiArray()
        {
            int[,] nomer5 = FunctionBase.nomor05(JmlBaris, JmlKolom);
            for (int b = 0; b < JmlBaris; b++)
            {
                for (int k = 0; k < JmlKolom; k++)
                {
                    Array2D[b, k] = nomer5[b, k].ToString();
                }
            }
        }
    }
}
