using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic04
{
    class Soal03: LogicBase
    {
        public Soal03(int n)
        {
            JmlBaris = n;
            JmlKolom = n;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray()
        {
            for (int b = 0; b < JmlBaris; b++)
            {
                int angka = 1;
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (b + k >= JmlBaris / 2 && k-b<=JmlBaris/2 && b <= JmlBaris / 2)
                    {
                        Array2D[b,k] = angka.ToString();
                        Array2D[JmlBaris - 1 - b, k] = angka.ToString();
                        angka++;
                    }                    
                }                
            }
        }
    }
}
