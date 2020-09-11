using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Merge_Sort_병합정렬_
    {
        // 정렬 배열을 전역 변수로 만드는 이유 : 불필요한 메모리 낭비를 막기 위해
        static int[] sorted;
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int[] data = new int[temp.Length];
            for(int i=0; i<temp.Length; i++)
            {
                data[i] = int.Parse(temp[i]);
            }
            sorted = new int[data.Length];

            MergeSort(data, 0, data.Length-1);
            foreach(int num in data)
            {
                Console.Write(num + " ");
            }
        }
        static void MergeSort(int[] arr, int front, int rear) {
            if(front < rear)
            {
                int middle = (front + rear) / 2;
                MergeSort(arr, front, middle);
                MergeSort(arr, middle + 1, rear);
                Merge(arr, front, middle, rear);
            }
        }

        // front : 시작 middle 중간 rear 뒤
        static void Merge(int[] arr, int front, int middle, int rear)
        {
            // 앞 배열의 맨 앞수
            int i = front;
            // 뒷 배열의 맨 앞수
            int j = middle + 1;
            // 합쳐질 배열의 맨 앞수
            int k = front;
            // 작은 순서대로 배열에 삽입 | i는 중간까지 / j는 끝까지
            while(i <= middle && j <= rear)
            {
                if(arr[i] <= arr[j])
                {
                    sorted[k++] = arr[i++];
                }
                else
                {
                    sorted[k++] = arr[j++];
                }
            }
            // 만약 i가 꽉차면 남은 j를 넣어주어야 함
            if(i > middle)
            {
                for(int t = j; t<=rear; t++)
                {
                    sorted[k++] = arr[t];
                }
            }
            // 만약 j가 꽉차면 남은 i를 넣어주어야 함
            else
            {
                for(int t = i; i<=middle; i++)
                {
                    sorted[k++] = arr[t];
                }
            }
            // 실제 배열로 옮기는 과정
            for(int t = front; t<=rear; t++)
            {
                arr[t] = sorted[t];
            }
        }
    }
}
