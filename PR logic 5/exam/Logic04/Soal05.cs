using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic04
{
    class Soal05: LogicBase
    {
        public Soal05(int n)
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
                int angka = 65;
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (b <= k && b + k <= JmlKolom - 1)
                    {
                        Array2D[b, k] = ((char)angka++).ToString();
                    }
                }
            }
        }
    }
}
