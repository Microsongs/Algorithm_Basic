using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class 심화정렬_조금더복잡한정렬
    {
        static void Main(string[] args)
        {
            string[] arr;
            int n = int.Parse(Console.ReadLine());
            arr = new string[n];
            for(int i=0; i<n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Array.Sort(arr,compare);
            for(int i=0; i<n; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1])
                    continue;
                else
                    Console.Write(arr[i] + "\n");
            }
        }

        static int compare(string a, string b)
        {
            if (a.Length < b.Length)
                return -1;
            else if (a.Length > b.Length)
                return 1;
            else
            {
                int aSum = getSum(a);
                int bSum = getSum(b) ;
                if (aSum != bSum)
                    return aSum < bSum ? -1 : 1;
                else
                    return String.Compare(a, b);
            }
        }
        static int getSum(string a)
        {
            int length = a.Length;
            int sum = 0;
            for(int i=0; i<length; i++)
            {
                if(a[i] - '0' <= 9 && a[i] - '0' >= 0)
                {
                    sum += a[i] - '0';
                }
            }
            return sum;
        }
    }
}
