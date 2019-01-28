using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic06
{
    class Soal01: LogicBase
    {
        public Soal01(int n)
        {
            JmlBaris= n*n;
            JmlKolom= (n*2-1)*2;
            Array2D= new string[JmlBaris, JmlKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs= n*bgn ;
                int stKol= bgn%2 * (n*2-1);
                int endBrs= stBrs + (n-1) ;
                int endKol=stKol+ 2*(n-1) ;
                for (int b = stBrs; b <= endBrs; b++)
                {
                    for (int k = stKol; k <= endKol; k++)
                    {
                        if(b + k >= stKol + endBrs && k + endBrs <= b + endKol )
                        Array2D[b,k]="*";
                    }
                } 
            }
        }
    }
}
