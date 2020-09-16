using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Heap_Sort_힙정렬_
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int[] heap = new int[temp.Length];
            for (int i = 0; i < heap.Length; i++)
            {
                heap[i] = int.Parse(temp[i]);
            }
            HeapSort(heap);
            foreach(int i in heap)
            {
                Console.Write(i + " ");
            }
        }
        static void HeapSort(int[] heap)
        {
            // 먼저 전체 트리 구조를 최대 힙 구조로 변경
            // 이 반복문은 트리 구조를 최대 힙 구조로 바꾸는 과정
            for (int i = 1; i < heap.Length; i++)
            {
                int child = i;
                do
                {
                    // 루트 : 자기 자신의 부모
                    int root = (child - 1) / 2;
                    // 부모의 값이 자식의 값보다 클 경우 스왑
                    if (heap[root] < heap[child])
                    {
                        Swap(ref heap[root], ref heap[child]);
                    }
                    child = root;
                } while (child != 0);
            }
            // 힙 생성 이후 반복적으로 크기를 줄여가며 힙을 구성
            // 가장 큰 값을 맨 뒤로 보내고 반복적으로 Heapify 실행
            for(int i = heap.Length-1; i>=0; i--)
            {
                Swap(ref heap[0], ref heap[i]);
                int root = 0;
                int child = 1;
                do
                {
                    child = 2 * root + 1;
                    // 자식중에 더 큰값을 찾는다.
                    // 왼쪽과 오른쪽 중 더 큰 값을 child에 담아준다.
                    if (child < i - 1 &&heap[child] < heap[child + 1])
                        child++;
                    // 루트보다 자식이 더 크면 교환
                    if (child < i && heap[root] < heap[child])
                        Swap(ref heap[root], ref heap[child]);
                    root = child;
                } while (child < i);
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
