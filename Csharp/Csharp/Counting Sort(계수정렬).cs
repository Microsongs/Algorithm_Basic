using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Counting_Sort_계수정렬_
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int[] data = new int[temp.Length];

            // 1~100 사이의 수라고 가정
            int max = 100;
            int[] count = new int[max];

            for(int i=0; i < data.Length; i++)
            {
                data[i] = int.Parse(temp[i]);
            }

            // 각각의 데이터에 처리
            for(int i=0; i < data.Length; i++)
            {
                count[data[i]-1]++;
            }
            // 출력
            for(int i=0; i<max; i++)
            {
                if(count[i] != 0)
                {
                    for(int j=0; j<count[i]; j++)
                    {
                        Console.Write("{0} ", i+1);
                    }
                }
            }
        }
    }
}
