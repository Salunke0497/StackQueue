using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StackMain stack = new StackMain();
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);

            //Console.WriteLine("enter\n1)Add\n2)Display\n3)peak\n4)pop\n5)Enqueue");
            //int x = Convert.ToInt32(Console.ReadLine());
            //switch (x)
            //{
            //    case 1:
            //        stack.Push(70);
            //        stack.Push(30);
            //        stack.Push(56);                    
            //        break;

            //    case 2:
            //        Console.WriteLine("Values are : ");
            //        stack.Display();
            //        break;

            //    case 3:
            //        stack.Peek();
            //        break;

            //    case 4:
            //        stack.Pop();
            //        break;

            //    default:
            //        break;
            //}

            //StackMain stack = new StackMain();
            //stack.Push(56);
            //stack.Push(30);
            //stack.Push(70);
            //Console.WriteLine("values are : ");
            //stack.Display();
            //Console.ReadLine();

            StackMain stack = new StackMain();
            stack.Enqueue(56);
            stack.Enqueue(30);
            stack.Enqueue(70);
            Console.WriteLine("\nQueue Sequence");
            stack.Dequeue();
            stack.Dequeue();
            stack.Dequeue();
            stack.Display();
            Console.ReadLine();
        }
    }
}
