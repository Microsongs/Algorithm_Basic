using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Csharp
{
    class Insertion_Sort_삽입_정렬_
    {
        static void Main(string[] args)
        {
            // Input Data
            string[] temp = Console.ReadLine().Split();
            int[] data = new int[temp.Length];
            for(int i=0; i<data.Length; i++)
            {
                data[i] = int.Parse(temp[i]);
            }

            for(int i=0; i<data.Length-1; i++)
            {
                int j = i;
                while(data[j] > data[j + 1])
                {
                    Swap(ref data[j], ref data[j + 1]);
                    j--;
                    if (j < 0)
                        break;
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
