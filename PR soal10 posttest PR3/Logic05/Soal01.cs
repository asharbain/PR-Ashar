using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal01: LogicBase
    {
        public Soal01(int n)
        {
            JmlBaris = (n * n + n) / 2;
            JmlKolom = (n * n + n) / 2;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                //starting point
                int stBrs = (bgn*bgn+bgn)/2;
                int stKol = stBrs;
                //Ending Point
                int endBrs = stBrs + bgn;
                int endKol = endBrs;
                    
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        Array2D[b, k] = "*";                        
                    }
                }
            }
        }
    }
}
