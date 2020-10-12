using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp
{
    class Breadth_First_Search_너비_우선_탐색_
    {
        static void Main(string[] args)
        {
            // 강의에서 a
            List<int>[] outQueue = new List<int>[8];
            for(int i=0; i<8; i++)
            {
                outQueue[i] = new List<int>();
            }
            // 강의에서 c
            bool[] arr = new bool[8];
            // 1과 2를 연결
            outQueue[1].Add(2);
            outQueue[2].Add(1);
            // 1과 3을 연결
            outQueue[1].Add(3);
            outQueue[3].Add(1);
            // 2와 3을 연결
            outQueue[2].Add(3);
            outQueue[3].Add(2);
            // 2와 4를 연결
            outQueue[2].Add(4);
            outQueue[4].Add(2);
            // 2와 5를 연결
            outQueue[2].Add(5);
            outQueue[5].Add(2);
            // 3와 6을 연결
            outQueue[3].Add(6);
            outQueue[6].Add(3);
            // 3와 7을 연결
            outQueue[3].Add(7);
            outQueue[7].Add(3);
            // 4와 5를 연결
            outQueue[4].Add(5);
            outQueue[5].Add(4);
            // 6와 7을 연결
            outQueue[6].Add(7);
            outQueue[7].Add(6);

            bfs(1, arr, outQueue);
        }
        static void bfs(int start, bool[] arr, List<int>[] outQueue)
        {
            Queue<int> queue = new  Queue<int>();
            queue.Enqueue(start);
            arr[start] = true;
            while(queue.Count != 0)
            {
                int x = queue.First();
                queue.Dequeue();
                Console.Write("{0} ", x);
                for(int i=0; i<outQueue[x].Count; i++)
                {
                    int y = outQueue[x][i];
                    if(arr[y] == false)
                    {
                        queue.Enqueue(y);
                        arr[y] = true;
                    }
                }
            }
        }
    }
}
