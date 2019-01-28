using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic03
{
    class Soal04: LogicBase
    {
        public Soal04(int n)
        {
            JmlBaris = 1;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            FunctionBase.CetakArray(Array2D);
        }
        private void isiArray()
        {
            int[] nomer4 = FunctionBase.nomor04(JmlKolom);
            for (int k = 0; k < JmlKolom; k++)
            {
                Array2D[0, k] = nomer4[k].ToString();
            }
        }
    }
}
