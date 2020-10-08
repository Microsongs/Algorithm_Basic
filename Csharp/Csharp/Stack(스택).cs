using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Stack_스택_
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(7);
            Print(stack);
            stack.Push(5);
            Print(stack);
            stack.Push(4);
            Print(stack);
            stack.Pop();
            Print(stack);
            stack.Push(6);
            Print(stack);
            stack.Pop();
            Print(stack);
        }
        static void Print(Stack<int> stack)
        {
            foreach (int data in stack)
                Console.Write(data + " ");
            Console.Write("\n");
        }
    }
}
