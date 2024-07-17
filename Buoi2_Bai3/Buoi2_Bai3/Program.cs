using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Buoi2_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger X = BigInteger.Parse("1234567891011121314");
            BigInteger Y = BigInteger.Parse("98765432112345678910");
            int n = Math.Max(X.ToString().Length, Y.ToString().Length);

            BigInteger result = Big_Number_Multi(X, Y, n);
            Console.WriteLine("Ket qua nhan: " + result);

            Console.ReadLine();
        }

        static BigInteger Big_Number_Multi(BigInteger X, BigInteger Y, int n)
        {
            int s = (X.Sign * Y.Sign);
            X = BigInteger.Abs(X);
            Y = BigInteger.Abs(Y);

            if (n == 1)
                return X * Y * s;

            int halfN = n / 2;
            BigInteger A = Left(X, halfN);
            BigInteger B = Right(X, halfN);
            BigInteger C = Left(Y, halfN);
            BigInteger D = Right(Y, halfN);

            BigInteger m1 = Big_Number_Multi(A, C, halfN);
            BigInteger m2 = Big_Number_Multi(A - B, D - C, halfN);
            BigInteger m3 = Big_Number_Multi(B, D, halfN);

            BigInteger result = s * (m1 * BigInteger.Pow(10, n) + (m1 + m2 + m3) * BigInteger.Pow(10, n / 2) + m3);
            return result;
        }

        static BigInteger Left(BigInteger num, int digits)
        {
            string numStr = num.ToString();
            int len = numStr.Length;
            if (len <= digits)
                return num;
            return BigInteger.Parse(numStr.Substring(0, len - digits));
        }

        static BigInteger Right(BigInteger num, int digits)
        {
            string numStr = num.ToString();
            int len = numStr.Length;
            if (len <= digits)
                return num;
            return BigInteger.Parse(numStr.Substring(len - digits));
        }
    }

}
