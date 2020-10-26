using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Csharp
{
    class Union_Find_유니온파인드_
    {
        // 특정 노드의 부모를 반환해주는 함수 GetParent = 부모 노드를 찾는 함수
        static int GetParent(int[] parent, int x)
        {
            // 해당 부모의 값과 동일하다면 x반환 -> 재귀 함수의 종료 부분
            if (parent[x] == x)
                return x;
            return parent[x] = GetParent(parent, parent[x]);
        }
        // 두 부모 노드를 합치는 함수 find함수
        // 부모를 가질 떄에는 더 작은 값을 부모로 가진다.
        static void UnionParent(int[] parent, int a, int b)
        {
            a = GetParent(parent, a);
            b = GetParent(parent, b);
            if (a < b)
                parent[b] = a;
            else
                parent[a] = b;
        }
        // 같은 부모를 가지는지 확인하는 함수
        static bool findParent(int[] parent, int a, int b)
        {
            a = GetParent(parent, a);
            b = GetParent(parent, b);
            if (a == b)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int[] parent = new int[11];
            for(int i=0; i<=10; i++)
            {
                parent[i] = i;
            }
            // 1-2-3-4 연결
            UnionParent(parent, 1, 2);
            UnionParent(parent, 2, 3);
            UnionParent(parent, 3, 4);

            // 5-6-7-8 연결
            UnionParent(parent, 5, 6);
            UnionParent(parent, 6, 7);
            UnionParent(parent, 7, 8);
            Console.WriteLine("1과 5는 연결되어 있나요?\n" + findParent(parent, 1, 5));
            UnionParent(parent, 1, 5);
            Console.WriteLine("1과 5는 연결되어 있나요?\n" + findParent(parent, 1, 5));
            Console.WriteLine("2과 8는 연결되어 있나요?\n" + findParent(parent, 2, 8));
        }
    }
}
