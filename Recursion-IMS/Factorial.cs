using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_IMS
{
    class Factorial
    {
        public int Ruben(int n)
        {
            int uitkomst = 1;
            for (int i = n; i > 0; i--)
            {
                uitkomst *= i;
            }
            return uitkomst;
        }

        public int Jord(int n)
        {
            if (n > 1) return n * Jord(n - 1);
            return 1;
        }

        public int Jord2(int n)
        {
            if ((n == 0) || (n == 1)) return 1;
            else return n * Jord2(n - 1);
        }

        public void PrintStack(Stack<int> s)
        {
            if (s.Count == 0)
                return;

            int x = s.Peek();
            s.Pop();
            PrintStack(s);
            Console.Write(x + " ");
            s.Push(x);
        }

        public int Kevin(int n)
        {
            Stack<int> stack = new Stack<int>();
            bool IsGoingUp = true;

            int result = 1;
            do
            {
                if (IsGoingUp)
                {
                    stack.Push(n);
                    n--;
                    if (n == 1) IsGoingUp = false;
                }
                else result *= stack.Pop();

            } while (stack.Count > 0);
            return result;

        }

        public int Hicham(int n)
        {
            Stack<int> stack = new Stack<int>();
            int uitkomst = 1;
            while (n != 0)
            {
                stack.Push(n);
                n--;
            }

            while (stack.Count != 0)
            {
                uitkomst *= stack.Pop();
            }
            return uitkomst;
        }





        public int MetEenStack(int number)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);

            for (int i = 1; i <= number; ++i)
            {
                stack.Push(stack.Pop() * i);
            }
            return stack.Pop();
        }
    }
}
