using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Selection_Sort_선택정렬_
    {
        static void Main(string[] args)
        {
            int min, index = 0;
            Console.Write("정수 데이터 입력 : ");
            // 데이터 입력받기
            String[] tempData = Console.ReadLine().Split();
            int[] data = new int[tempData.Length];
            for(int i=0; i<data.Length; i++)
            {
                data[i] = int.Parse(tempData[i]);
            }
            // 데이터의 정렬
            for (int i = 0; i < data.Length; i++)
            {
                min = 2147483647;
                for(int j=i; j<data.Length; j++)
                {
                    // 현재 탐색하는 원소가 최소값보다 작다면 원소 교환
                    if(min > data[j])
                    {
                        min = data[j];
                        index = j;
                    }
                }
                // Swap
                Swap(ref data[i], ref data[index]);
            }

            // Print
            for(int i=0; i<data.Length; i++) 
            {
                Console.Write(data[i] + " ");
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
