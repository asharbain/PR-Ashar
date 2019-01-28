using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal08:LogicBase
    {
        public Soal08(int n)
        {
            JmlBaris = (n * n + n) / 2;
            JmlKolom = (n * n + n) / 2;
            Array2D = new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
              
        }

        private void isiArray(int n)
        {
            //value
            int ganjil = 1;
            int genap = 2;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = (bgn * bgn + bgn) / 2;
                int stKol = stBrs;
                int endBrs = stBrs + bgn;
                int endKol = endBrs;

                //flow
                bool kanan = true;

                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        //Array2D[b, kanan ? k : endKol - k + stKol] = bgn % 2 == 0 ? ganjil.ToString() : genap.ToString();
                        //if (bgn % 2 == 0) ganjil += 2; else genap+=2;
                        if (kanan)
                        {
                            if (bgn % 2 == 0)
                                Array2D[b, k] = ganjil.ToString();
                            else
                                Array2D[b, k] = genap.ToString();
                        }
                        else
                        {
                            if (bgn % 2 == 0)
                                Array2D[b, endKol - k + stKol] = ganjil.ToString();
                            else
                                Array2D[b, endKol - k + stKol] = genap.ToString();
                        }
                        if (bgn % 2 == 0)
                            ganjil += 2;
                        else
                            genap += 2;
                    }
                    kanan = !kanan;
                }                
            }
        }
    }
}
