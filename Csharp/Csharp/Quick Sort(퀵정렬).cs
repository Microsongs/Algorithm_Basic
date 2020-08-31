using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Csharp
{
    class Quick_Sort_퀵정렬_
    {
        static void Main(String[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int[] data = new int[temp.Length];
            for(int i=0; i<data.Length; i++)
            {
                data[i] = int.Parse(temp[i]);
            }
            QuickSort(data, 0, data.Length - 1);
            foreach(int num in data)
            {
                Console.Write(num + " ");
            }
        }
        static void QuickSort(int[] data, int start, int end)
        {
            // 원소가 1개일 경우 -> return
            if (start >= end)
                return;
            int pivot = start;
            int left = start + 1;
            int right = end;

            // 엇갈릴 때 까지 반복
            while(left <= right)
            {
                // pivot보다 큰 값일 때까지 반복
                // data[left]와 data[pivot]을 >= 로 data[right]와 data[pivot]을 <=로 바꾸면 내림차순
                while (left <= end && data[left] <= data[pivot])
                    left++;

                // pivot보다 작은 값일 떄 까지 반복, 시작 수보다 크지 않도록
                while (data[right] >= data[pivot] && right > start)
                    right--;

                // 엇갈렸을 경우 피벗 값과 교체
                if (left > right)
                    Swap(ref data[right], ref data[pivot]);
                // 엇갈리지 않았을 경우
                else
                    Swap(ref data[left], ref data[right]);
            }
            // 오른쪽 정렬
            QuickSort(data, start, right - 1);
            // 왼쪽 정렬
            QuickSort(data, right+1, end);
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
