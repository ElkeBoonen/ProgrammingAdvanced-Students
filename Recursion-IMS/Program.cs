using System;
using TM.ProgrammingAdvanced;

namespace Recursion_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Data.Folders(@"C:\");
            Folders folders = new Folders(path);
            Console.WriteLine("Gevonden - TOM: " + folders.Tom());
            folders.Count = 0;
            Console.WriteLine("Gevonden - STEF: " + folders.Stef() + " ---> "+folders.Count);
            folders.Count = 0;
            Console.WriteLine("Gevonden - KIRSTEN: " + folders.Kirsten(folders.Path) + " ---> " + folders.Count);
            

            Factorial fac = new Factorial();
            Console.WriteLine(fac.Ruben(8));
            Console.WriteLine(fac.Jord(8));
            Console.WriteLine(fac.Jord2(8));
            Console.WriteLine(fac.MetEenStack(8)) ;
            Console.WriteLine(fac.Kevin(8));
            Console.WriteLine(fac.Hicham(8));


        }
    }
}
