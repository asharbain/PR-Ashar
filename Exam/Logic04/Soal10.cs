﻿using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic04
{
    class Soal10 : LogicBase
    {
        public Soal10(int n1, int n2)
        {
            JmlBaris = n1;
            JmlKolom = (n2 * n1) - (n2 - 1);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n2);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n2)
        {
            for (int bangun = 0; bangun < n2; bangun++)
            {
                for (int b = 0; b < JmlBaris; b++)
                {
                    int ascii = 65;
                    for (int k = 0; k < JmlKolom; k++)
                    {
                        if (b + k >= (JmlBaris - 1) / 2 && k - b <= (JmlBaris - 1) / 2 && b <= JmlBaris / 2)
                        {
                            Array2D[b, k + (JmlBaris - 1) * bangun] = ((char)ascii).ToString();
                            Array2D[JmlBaris - 1 - b, k + (JmlBaris - 1) * bangun] = ((char)ascii).ToString();
                            if (k < JmlBaris / 2)
                            {
                                ascii++;
                            }
                            else
                            {
                                ascii--;
                            }
                        }
                    }
                }
            }
        }
    }
}
