using System;

namespace LinkedList_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*LinkedList list = new LinkedList();

            list.InsertDima("elke");
            list.InsertDima("Julian");
            list.InsertDima("Hugo");
            // elke julian hugo
            // hugo julian elke

            list.InsertDima("Dima");
            Console.WriteLine(list.ToString());
            
            //list.DeleteNeil("elke");
            Console.WriteLine(list.ToString());
            
            list.DeleteNeil("Dima");
            Console.WriteLine(list.ToString());
            
            list.DeleteNeil("Julian");
            Console.WriteLine(list.ToString());
            list.DeleteNeil("elke");
            Console.WriteLine(list.ToString());
            list.DeleteNeil("hugo");
            Console.WriteLine(list.ToString());
            */
            Stack stack = new Stack(5);
            stack.Push("lovro");
            Console.WriteLine(stack.ToString());
            stack.Push("elke");
            Console.WriteLine(stack.ToString());
            stack.Push("julian");
            Console.WriteLine(stack.ToString());
            stack.Push("dima");
            Console.WriteLine(stack.ToString());
            stack.Push("neil");
            Console.WriteLine(stack.ToString());
            stack.Push("hugo");
            Console.WriteLine(stack.ToString());
            stack.Pop();
            Console.WriteLine(stack.ToString());
            stack.Pop();
            Console.WriteLine(stack.ToString());
            stack.Pop();
            Console.WriteLine(stack.ToString());
            stack.Pop();
            Console.WriteLine(stack.ToString());
            stack.Pop();
            Console.WriteLine(stack.ToString());
            stack.Pop();
            Console.WriteLine(stack.ToString());
            stack.Pop();
            Console.WriteLine(stack.ToString());


        }
    }
}
