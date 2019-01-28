using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari01
{
    class soal09
    {
        public soal09(int n)
        {
            for (int b = 0; b < n; b++)
            {
                for (int k =0; k<n; k++)
                {
                    if ((b>=k && b+k<=n-1)||(b<=k && b+k>=n-1))
                    {                        
                        Console.Write("*\t");
                    }
                    else
                    {
                    Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
