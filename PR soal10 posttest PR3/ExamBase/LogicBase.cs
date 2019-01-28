using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBase
{
    public class LogicBase
    {
        public int JmlBaris { get; set; }
        public int JmlKolom { get; set; }
        public string[,] Array2D { get; set; }        
    }
    public class FunctionBase
    {
        public static int[] Fibonacci(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++ )
            {
                if (pos <= 1)
                    result[pos] = 1;
                else
                    result[pos] = result[pos - 1] + result[pos - 2];
            }
                return result;
        }
        public static int[] Tribonacci(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 2)
                    result[pos] = 1;
                else
                    result[pos] = result[pos - 1] + result[pos - 2] + result[pos - 3];
            }
            return result;
        }
        public static int[] nomor03(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                    result[pos] = 1;
                else if (pos <= n / 2)
                    result[pos] = result[pos - 1] + result[pos - 2];
                else if (pos >= n / 2)
                    result[pos] = result[n - 1 - pos];
            }
            return result;
        }
        public static int[] nomor04(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 2)
                    result[pos] = 1;
                else if (pos <= n / 2)
                    result[pos] = result[pos - 1] + result[pos - 2] + result[pos - 3];
                else if (pos >= n / 2)
                    result[pos] = result[n - 1 - pos];
            }
            return result;
        }
        public static int[,] nomor05(int jB, int jK)
        {
            int[,] result = new int[jB, jK];
            for (int b = 0; b < jB; b++)
            {
                for (int k=0; k<jK; k++)
                {
                    if (b<1)
                    {
                        if (k<=1)
                        {
                            result[b, k] = 1;
                        }
                        else if (k<= jK/2)
                        {
                            result[b, k] = result[b, k - 1] + result[b, k - 2];
                        }
                        else
                        {
                            result[b, k] = result[b, jK - 1 - k];
                        }
                    }
                    else
                    {
                        if (b<=k || b+k >=jB-1)
                        {
                            result[b, k] = result[0, k];
                        }
                    }
                }
            }
            return result;
        }
        public static int[] nomor09(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                    result[pos] = 1;
                else
                    result[pos] = result[pos - 1] + result[pos - 2];
            }
            return result;
        }
        public static void CetakArray(string[,] Array2D)
        {
            for (int b = 0; b < Array2D.GetLength(0); b++)
            {
                for (int k = 0; k < Array2D.GetLength(1); k++)
                {
                    Console.Write("{0}\t", Array2D[b, k]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
