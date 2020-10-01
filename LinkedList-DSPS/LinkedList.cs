using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_DSPS
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void InsertDima(string data)
        {
            Node n = new Node(data);
            if (Head == null)
            {
                Head = n;
            }
            else
            {
                Tail.Next = n;
            }
            Tail = n;
        }

        public void DeleteNeil(string data)
        {
            Node temp = Head;
            if (temp.Data == data)
            {
                Head = Head.Next;
                return;
            }

            if (!Search(data)) return;

            while (temp.Next.Data != data)
            {
                temp = temp.Next;
            }
            temp.Next = temp.Next.Next;

        }

        /* public void DeleteJulian(string data)
         {
             Node temp = Head;

             if (temp.Data == data)
             {
                 Head = Head.Next;
                 return;
             }

             //with help of Neil


             while (temp != GetLast())
             {

             }
         }*/

        public bool Search(string data)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Data == data) return true;
                temp = temp.Next;
            }
            return false;
        }


        public override string ToString()
        {
            string s = "LINKED LIST: ";
            Node temp = Head;
            while (temp != null)
            {
                s += temp.ToString() + " ";
                temp = temp.Next;
            }
            return s;
        }

    }
}
