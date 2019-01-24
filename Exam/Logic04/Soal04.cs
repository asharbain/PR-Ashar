using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic04
{
    class Soal04: LogicBase
    {
        public Soal04(int n)
        {
            JmlBaris = n;
            JmlKolom = n * 2 - 1;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray()
        {
            for (int b = 0; b < JmlBaris; b++)
            {
                int ascii = 65;
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (b + k >= JmlBaris - 1 && k - b <= JmlBaris - 1)
                    {
                        Array2D[b, k] = ((char)ascii++).ToString();
                    }
                }
            }
        }
    }
}
