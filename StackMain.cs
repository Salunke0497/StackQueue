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
    }
}
