using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_DSPS
{
    class Stack
    {
        public int Size { get; set; }
        public Node Top { get; set; }
        private int _count { get; set; }

        public Stack(int size)
        {
            Size = size;
            Top = null;
            _count = 0;
        }

        public void Push(string data)
        {
            if (_count < Size)
            {
                Node n = new Node(data);
                n.Next = Top;
                Top = n;
                _count++;
            }
            else Console.WriteLine("OVERFLOW");
        }

        public void Pop()
        {
            if (_count > 0)
            {
                Top = Top.Next;
                _count--;
            }
            else Console.WriteLine("UNDERFLOW");
        }

        public override string ToString()
        {
            string s = "STACK: ";
            Node temp = Top;
            while (temp != null)
            {
                s += temp.ToString() + " ";
                temp = temp.Next;
            }
            return s;
        }
    }
}
