using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Csharp
{
    // 간선 정보를 담는 간선 클래스
    class Edge
    {
        // 변수 2개
        // 서로 연결된 노드 정보
        public int[] node = new int[2];
        // 노드의 거리 관련 정보
        public int distance;
        public Edge(int node1, int node2, int distance)
        {
            this.node[0] = node1;
            this.node[1] = node2;
            this.distance = distance;
        }
        
        public static bool operator <(Edge main, Edge edge)
        {
            if (main.distance < edge.distance)
                return false;
            else
                return true;
        }
        public static bool operator >(Edge main, Edge edge)
        {
            if (main.distance > edge.distance)
                return true;
            else
                return false;
        }
        
    }
    class Kruskal_Algorithm_크루스칼_알고리즘_
    {
        static void Main(string[] args)
        {
            // 노드 = 7, 간선 = 11
            int node = 7;
            int line = 11;
            List<Edge> myList = new List<Edge>();
            Edge temp = new Edge(1, 7, 12);
            myList.Add(temp);
            
            myList.Add(new Edge(1, 4, 28));
            myList.Add(new Edge(1, 2, 67));
            myList.Add(new Edge(1, 5, 17));
            myList.Add(new Edge(2, 4, 24));
            myList.Add(new Edge(2, 5, 62));
            myList.Add(new Edge(3, 5, 20));
            myList.Add(new Edge(3, 6, 37));
            myList.Add(new Edge(4, 7, 13));
            myList.Add(new Edge(5, 6, 45));
            myList.Add(new Edge(5, 7, 73));

            // 간선의 비용을 기준으로 오름차순 정렬
            myList = myList.OrderBy(x => x.distance).ToList();

            //Union Find 알고리즘을 그대로 적용
            int[] parent = new int[node];
            for(int i=0; i<node; i++)
                parent[i] = i;
            // 거리의 합
            int sum = 0;
            for(int i=0; i<myList.Count; i++)
            {
                // 사이클이 발생하지 않으면 그래프에 포함
                if(!findParent(parent, myList[i].node[0] - 1, myList[i].node[1] - 1))
                {
                    sum += myList[i].distance;
                    UnionParent(parent, myList[i].node[0] - 1, myList[i].node[1] - 1);
                }
                // 발생하면 무시
            }
            Console.Write("{0}", sum);
        }
        // 유니온 파인트(Union Find)
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
    }
}
