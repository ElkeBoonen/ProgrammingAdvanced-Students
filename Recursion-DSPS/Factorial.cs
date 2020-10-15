using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_DSPS
{
    class Factorial
    {
        public int Count { get; set; }

        public Factorial()
        {
            Count = 0;
        }

        public int Iterative(int number)
        {
            int output = 1;
            for (int i = 1; i <= number; i++)
            {
                output *= i;
            }
            return output;
        }

        public int Recursive(int number)
        {
            //Count++;
            //Console.WriteLine(Count);
            if (number == 0) return 1;
            return number * Recursive(number - 1);
        }

        public int WithStack(int number)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            for (int i = 1; i <= number; i++)
            {
                stack.Push(stack.Pop() * i);
            }
            return stack.Pop();
        }
    }
}
