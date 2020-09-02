using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class 기초정렬1_세숫자정렬
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int[] data = new int[temp.Length];
            for(int i=0; i<data.Length; i++)
            {
                data[i] = int.Parse(temp[i]);
            }
            quickSort(data, 0, data.Length - 1);

            foreach(int num in data){
                Console.Write("{0} ",num);
            }
        }
        static void quickSort(int[] arr, int start, int end)
        {
            if (start >= end)
                return;
            int left = start+1;
            int right = end;
            int pivot = start;
            // 엇갈릴 때까지
            while (left <= right)
            {
                // 왼쪽이 끝보다 작으면서 배열의 left값이 배열의 pivot값보다 작을 동안
                while (left <= end && arr[left] <= arr[pivot])
                    left++;
                // 오른쪽 값이 start보다 크면서 arr[right]값이 arr[pivot]보다 클 동안
                while (arr[right] >= arr[pivot] && right > start)
                    right--;

                // 엇갈린 경우
                if (left > right)
                    Swap(ref arr[right], ref arr[pivot]);
                // 스왑해야 할 경우
                else
                    Swap(ref arr[left], ref arr[right]);
            }
            // 왼쪽
            quickSort(arr, start, right-1);
            // 오른쪽
            quickSort(arr, right+1, end);
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
