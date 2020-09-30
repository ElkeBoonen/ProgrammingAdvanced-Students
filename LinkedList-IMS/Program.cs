using System;

namespace LinkedList_IMS
{
    class Program
    {
        static void Main(string[] args)
        {/*
            LinkedList list = new LinkedList();

            Node n1 = new Node(8);

            list.InsertAlexander(n1);
            Console.WriteLine(list.ToString());
            list.InsertAlexander(new Node(6));
            Console.WriteLine(list.ToString());
            list.InsertAlexander(new Node(4));
            Console.WriteLine(list.ToString());
            list.InsertEli(new Node(3));
            Console.WriteLine(list.ToString());
            list.InsertEli(new Node(34));
            Console.WriteLine(list.ToString());
            list.InsertAlexander(new Node(44));
            Console.WriteLine(list.ToString());
            //8 6 4
            //4 6 8

            Console.WriteLine(list.ToString());

            Console.WriteLine(list.Head);
            Console.WriteLine(list.Head.Next);
            Console.WriteLine(list.Head.Next.Next);
            Console.WriteLine(list.Head.Next.Next.Next);


            list.DeleteKevin(44);
            Console.WriteLine(list.ToString());
            */

            StackRuben stack = new StackRuben(3);
            stack.Pop();
            stack.Push(3);
            Console.WriteLine(stack.ToString());
            stack.Push(1);
            Console.WriteLine(stack.ToString());
            stack.Push(2);
            Console.WriteLine(stack.ToString());
            stack.Push(5);
            Console.WriteLine(stack.ToString());
            stack.Pop();
            Console.WriteLine(stack.ToString());
        }
    }
}
