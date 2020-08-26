using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Bubble_Sort_버블정렬_
    {
        static void Main(string[] args)
        {
            // 데이터의 입력 Input Data
            string[] temp = Console.ReadLine().Split();
            int[] data = new int[temp.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = int.Parse(temp[i]);
            }

            // Bubble Sort
            for (int i = 0; i < data.Length; i++)
            {
                // 길이-i-1인 이유 -> 10개 ->9회 9개->8회...
                for (int j = 0; j < data.Length - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])
                        Swap(ref data[j], ref data[j + 1]);
                }
            }
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
