using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class 심화정렬_숫자정렬하기3
    {
        static void Main(String[] args)
        {
            // 계수정렬 사용
            int[] arr = new int[10001];
            int n = int.Parse(Console.ReadLine());
            int inputNum;
            for(int i=0; i<n; i++)
            {
                inputNum = int.Parse(Console.ReadLine());
                arr[inputNum]++;
            }
            
            for(int i=0; i<10001; i++)
            {
                while(arr[i]-- != 0)
                {
                    Console.Write(i + "\n");
                }
            }
        }
    }
}
