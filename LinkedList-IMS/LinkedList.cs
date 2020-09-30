using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_IMS
{
  
    class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList()
        {
            Head = null;
        }

        public void InsertAlexander(Node node)
        {
            node.Next = Head;
            Head = node;
        }


        private Node GetLast()
        {
            Node node = Head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            return node;

        }

        public void InsertEli(Node node)
        {
            if (Head == null) Head = node;
            else GetLast().Next = node;
        }

        public void DeleteKevin(int data)
        {
            if (Head.Data != data)
            {
                Node temp = Head;
                while (temp.Next.Data != data)
                {
                    temp = temp.Next;
                }
                temp.Next = temp.Next.Next;
            }
            else Head = Head.Next;
        }

        public override string ToString()
        {
            string s= "LIST: ";
            Node node = Head;
            while (node != null)
            { 
                s += node.ToString() + " ";
                node = node.Next;
            }
            return s;
        }

    }
}
