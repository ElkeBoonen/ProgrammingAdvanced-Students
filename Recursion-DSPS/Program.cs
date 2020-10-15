using System;
using TM.ProgrammingAdvanced;

namespace Recursion_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\vtr3vhylcmf
            //C:\ivhxaqjri5u
            /*string path = Data.Folders(@"C:\");

            Folders folders = new Folders(path);
            folders.Count = 0;
            Console.WriteLine("found at " + folders.Algorithm1() + " --> " + folders.Count);
            folders.Count = 0;
            Console.WriteLine("found at " + folders.Algorithm2(folders.Path) + " --> " + folders.Count);
            */

            Factorial factorial = new Factorial();
            Console.WriteLine("5! = " +  factorial.Iterative(5));
            Console.WriteLine("5! = " + factorial.Recursive(5));
            Console.WriteLine("5! = " + factorial.WithStack(5));


        }
    }
}
