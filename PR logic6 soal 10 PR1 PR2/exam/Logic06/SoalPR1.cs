using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic06
{
    class SoalPR1:LogicBase
    {
        public SoalPR1(int n)
        {
            JmlBaris = 3 * n + (n - 1);
            JmlKolom = JmlBaris;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int b = 0; b < JmlBaris; b++)
            {
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (b+k >= n+n-1&&k-b<=n+n-1&&b<n)
                    {
                        Array2D[b, k] = "*";
                        Array2D[JmlBaris - 1 - b, k] = "*";
                        Array2D[k, b] = "*";
                        Array2D[JmlKolom - 1 - k, JmlBaris - 1 - b] = "*";
                    }
                }
            }
        }
    }
}
