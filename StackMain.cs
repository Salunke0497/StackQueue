using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stack
{
    internal class StackMain
    {
        Node headtop;
        public StackMain()
        {
            this.headtop = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.headtop == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.headtop;
            }
            this.headtop = node;
            Console.WriteLine("added the stack value " + value);
        }
        public void Display()
        {
            Node temp = this.headtop;
            if (temp == null)
            {
                Console.WriteLine("stack list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if (this.headtop == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of stack", this.headtop.data);
        }
        internal void Pop()
        {
            if (this.headtop == null)
            {
                Console.WriteLine("Stack is empty,Deletion is not Possible");
                return;
            }
            Console.WriteLine("Value Poped is {0}", this.headtop.data);
            this.headtop = this.headtop.next;
        }
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.headtop == null)
            {
                this.headtop = node;
            }
            else
            {
                Node temp = headtop;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }
    }
}
