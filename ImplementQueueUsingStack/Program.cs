using System;
using System.Collections;
using System.Collections.Generic;

namespace ImplementQueueUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

                Implement the MyQueue class:
                
                void push(int x) Pushes element x to the back of the queue.
                int pop() Removes the element from the front of the queue and returns it.
                int peek() Returns the element at the front of the queue.
                boolean empty() Returns true if the queue is empty, false otherwise.
                Notes:
                
                You must use only standard operations of a stack, which means only push to top, peek/pop from top, size, and    is     empty     operations are valid.
                Depending on your language, the stack may not be supported natively. You may simulate a stack using a list or     deque       (double-ended queue) as long as you use only a stack's standard operations.
                 
                
                Example 1:
                
                Input
                ["MyQueue", "push", "push", "peek", "pop", "empty"]
                [[], [1], [2], [], [], []]
                Output
                [null, null, null, 1, 1, false]
                
                Explanation
                MyQueue myQueue = new MyQueue();
                myQueue.push(1); // queue is: [1]
                myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
                myQueue.peek(); // return 1
                myQueue.pop(); // return 1, queue is [2]
                myQueue.empty(); // return false*/

            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                stack1.Push(random.Next(100));
            }
            PushForQuery(random.Next(100, 200));

            Console.Write("Elements of Query : ");
            foreach (var item in stack1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Peek of Query : " + PeekForQuery());
            Console.WriteLine("Pop of Query : " + PopForQuery());
            Console.WriteLine("Is query empty? : " + IsEmptyForQuery());


            void PushForQuery(int x)
            {
                stack2.Push(x);
            }

            int PopForQuery()
            {
                PeekForQuery();
                return stack1.Pop();
            }

            int PeekForQuery()
            {
                if (stack1.Count == 0)
                {
                    while (stack2.Count != 0)
                    {
                        stack1.Push(stack2.Pop());
                    }
                }
                return stack1.Count == 0 ? 0 : stack1.Peek();
            }

            bool IsEmptyForQuery()
            {
                PeekForQuery();
                return stack1.Count == 0;
            }
        }

    }
}
