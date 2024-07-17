using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Bai1
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            int n = A.Length;
            int key = 23;

            int result = BinarySearch(A, n, key);

            if (result != -1)
            {
                Console.WriteLine("Tim thay key {0} tai vi tri {1}", key, result);
            }
            else
            {
                Console.WriteLine("Khong tim thay key {0} trong mang", key);
            }

            Console.ReadLine();
        }

        static int BinarySearch(int[] A, int n, int key)
        {
            int left = 0;
            int right = n - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (A[mid] == key)
                    return mid;

                if (key < A[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1;
        }

    }
}
