using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_IMS
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
            Next = null;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
