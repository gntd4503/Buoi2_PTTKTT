using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 5, 2, 4, 6, 1, 3 };
            int n = A.Length;

            MergeSort(A, 0, n - 1);

            Console.WriteLine("Mang sau khi sap xep Merge Sort:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }

            Console.ReadLine();
        }

        static void MergeSort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(A, left, mid);
                MergeSort(A, mid + 1, right);
                Merge(A, left, mid, right);
            }
        }

        static void Merge(int[] A, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1]; // Mảng tạm để lưu trữ dữ liệu khi trộn
            int i = left, j = mid + 1, k = 0;

            while (i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    temp[k++] = A[i++];
                }
                else
                {
                    temp[k++] = A[j++];
                }
            }

            while (i <= mid)
            {
                temp[k++] = A[i++];
            }

            while (j <= right)
            {
                temp[k++] = A[j++];
            }

            for (int index = left; index <= right; index++)
            {
                A[index] = temp[index - left];
            }
        }
    }
}
