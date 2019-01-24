using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanLiveCode
{
    class Soal04 : LogicBase
    {
        public Soal04(int n)
        {
            JmlBaris = (n * n + n) / 2;
            JmlKolom = (n * n + n) / 2;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int ganjil = 1;
            int genap = 2;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = (bgn * bgn + bgn) / 2;
                int stKol = JmlKolom - 1 - stBrs - bgn;
                int endBrs = stBrs + bgn;
                int endKol = stKol + bgn;

                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b==stBrs || b==endBrs || k==stKol || k==endKol )
                        //Array2D[b, k] = "*";
                        if (bgn % 2 == 0)
                        {
                            Array2D[b, k] = ganjil.ToString();
                            ganjil += 2;
                        }
                        else
                        {
                            Array2D[b, k] = genap.ToString();
                            genap += 2;
                        }
                    }
                }
            }
        }
    }
}
