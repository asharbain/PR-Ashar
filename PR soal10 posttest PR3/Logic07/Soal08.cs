using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Logic07
{
    class Soal08: LogicBase
    {
        public Soal08(int n, int n2, int n3)
        {
            JmlBaris = n;
            JmlKolom = n2*n3+n3-1;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n, n2, n3);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n, int n2, int n3)
        {
            for (int bgn = 0; bgn < n3; bgn++)
            {
                int stKol = (n2 + 1) * bgn;
                int endKol = stKol + n2 - 1;
                int angka = 1;
                int nAngka = n * 4 + (n2 - 2) * 4 - 1;

                for (int b = 0; b < JmlBaris; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if (b == 0 || k == endKol)
                        {
                            Array2D[b, k] = angka.ToString();
                            angka += 2;
                        }
                        else if (b == JmlBaris - 1 || k == stKol)
                        {
                            Array2D[b, k] = nAngka.ToString();
                            nAngka -= 2;
                        }
                    }
                }
            }
        }
    }
}
