using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class For
    {
        public static int CycleFor1(int a, int b)
        {
            int prod = 1;
            for (int i = a; i <= b; i++)
            {
                prod *= i;
            }
            return prod;
        }

        public static double CycleFor2(double N)
        {
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += (1.0 / i);
            }
            return sum;
        }

        public static double CycleFor3(double A, int N)
        {
            double pow = 1;
            for (int i = 1; i <= N; i++)
            {
                pow *= A;
            }
            return pow;
        }

        public static double CycleFor4(int a, int b)
        {
           double sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += Math.Pow(i, 2);
            }
            return sum;
        }

        public static long CycleFor5(int N)
        {
            long sum = 0;
            for (int i = 1; i <= N; i++)
            {
                int factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            return sum;
        }
    }

    public class While
    {
        public static double CycleWhile1(int N)
        {
            int i = 1, j = N;
            double sum = 0;
            while (i <= N)
            {
                sum += Math.Pow(i, j);
                i++;
                j--;
            }
            return sum;
        }

        public static int CycleWhile2(int N)
        {
            int k = 1;
            while (Math.Pow(3, k) <= N)
            {
                k++;
            }
            return k;
        }

        public static double[] CycleWhile3(float P)
        {
            P /= 100;
            double S = 10;
            int days = 1;
            double sum = 10;
            while (sum <= 200)
            {
                days++;
                S *= (1 + P);
                sum += S;
            }
            double[] Arr = { days, Math.Round(sum, 1) };
            return Arr;
        }
    }    
}
