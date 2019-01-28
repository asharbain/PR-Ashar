using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic06
{
    class Soal10: LogicBase
    {
        public Soal10(int n)
        {
            JmlBaris = n;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int b = 0; b < n; b++)
            {
                int stKol = b % 2 == 0 ? 0 : JmlBaris - 1 - b;
                int endKol = stKol + b;
                for (int k = stKol ; k <= endKol; k++)
                {
                    Array2D[b, k] = (b + 1).ToString();
                }
            }
        }
    }
}
