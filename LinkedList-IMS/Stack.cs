using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_IMS
{
    class StackRuben
    {
        public int Size { get; set; }
        public Node Top { get; set; }

        private LinkedList _list { get; set; }
        private int _count { get; set; }

        public StackRuben(int size)
        {
            Size = size;
            _list = new LinkedList();
            Top = _list.Head;
            _count = 0;
        }
        public void Pop() {
            if (_count > 0)
            {
                _list.DeleteKevin(Top.Data);
                _count--;
            }
            else Console.WriteLine("UNDERFLOW");
        }
        public void Push(int data) {
            if (_count < Size)
            {
                _list.InsertAlexander(new Node(data));
                Top = _list.Head;
                _count++;
            }
            else Console.WriteLine("OVERFLOW");
        }

        public override string ToString()
        {
            return _list.ToString();
        }

    }
}
