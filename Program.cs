using System;
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
            StackMain stack = new StackMain();
            Console.WriteLine("enter\n1)Add\n");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
