using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Queue_큐_
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(7);
            Print(queue);
            queue.Enqueue(5);
            Print(queue);
            queue.Enqueue(4);
            Print(queue);
            queue.Dequeue();
            Print(queue);
            queue.Enqueue(6);
            Print(queue);
            queue.Dequeue();
            Print(queue);
        }
        static void Print(Queue<int> queue)
        {
            foreach (int data in queue)
                Console.Write(data + " ");
            Console.Write("\n");
        }
    }
}
