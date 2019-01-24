using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanLiveCode
{
    class Soal03 : LogicBase
    {
        public Soal03(int n1, int n2)
        {
            JmlBaris = n1;
            JmlKolom = (n1 * n2) - (n2 - 1);
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n2);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n2)
        {
            for (int bgn = 0; bgn < n2; bgn++)
            {
                for (int b = 0; b < JmlBaris; b++)
                {
                    for (int k = 0; k < JmlKolom; k++)
                    {
                        if ((b + k == JmlBaris / 2 || k - b == JmlBaris / 2) && b <= JmlBaris / 2)
                        {
                            Array2D[b, k + (JmlBaris - 1) * bgn] = "A";
                            Array2D[JmlBaris - 1 - b, k + (JmlBaris - 1) * bgn] = "A";
                        }
                    }
                }
            }
        }
    }
}
