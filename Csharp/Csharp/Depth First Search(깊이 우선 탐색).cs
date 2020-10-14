using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Csharp
{
    class Depth_First_Search_깊이_우선_탐색_
    {
        static void Main(string[] args)
        {
            int num = 8;
            // 해당 숫자의 방문 여부
            bool[] visited = new bool[num];
            // 스택에서 낭
            List<int>[] arr = new List<int>[num];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = new List<int>();
            }

            // 1과 2를 연결
            arr[1].Add(2);
            arr[2].Add(1);
            // 1과 3을 연결
            arr[1].Add(3);
            arr[3].Add(1);
            // 2와 3을 연결
            arr[2].Add(3);
            arr[3].Add(2);
            // 2와 4를 연결
            arr[2].Add(4);
            arr[4].Add(2);
            // 2와 5를 연결
            arr[2].Add(5);
            arr[5].Add(2);
            // 3와 6을 연결
            arr[3].Add(6);
            arr[6].Add(3);
            // 3와 7을 연결
            arr[3].Add(7);
            arr[7].Add(3);
            // 4와 5를 연결
            arr[4].Add(5);
            arr[5].Add(4);
            // 6와 7을 연결
            arr[6].Add(7);
            arr[7].Add(6);

            dfs(visited, arr, 1);
        }
        static void dfs(bool[] visited, List<int>[] arr, int data)
        {
            // 이미 들어온 데이터였다면
            if (visited[data] == true)
                return;
            visited[data] = true;
            Console.Write("{0} ",data);
            // 해당 노드와 붙어있는 모든 노드를 하나씩 즉, 인접 노드를 하나씩 방문하면서 그 인접노드 대상으로 dfs 실행
            for(int i=0; i<arr[data].Count; i++)
            {
                // adjoin : 인접
                int adjoin = arr[data][i];
                dfs(visited, arr, adjoin);
            }
        }
    }
}
