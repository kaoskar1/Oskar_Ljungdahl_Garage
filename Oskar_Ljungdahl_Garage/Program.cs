using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oskar_Ljungdahl_Garage
{
    class Program
    {
        static void Main(string[] args)
        {

            printMenu();
        }

        private static void printMenu()
        {
            Console.WriteLine("****GARAGE****");
            Console.WriteLine("*****(L)ist****");
            Console.WriteLine("List all the vehicle in the (G)arage");
            Console.WriteLine("List vehicle (T)ypes");
            Console.WriteLine("****(S)earch****");
            Console.WriteLine("Search on the (N)umber plate");
            Console.WriteLine("Search on an (A)ttribut");
            Console.WriteLine("****(E)dit****");
            Console.WriteLine("(A)dd A Vehicle");
            Console.WriteLine("(R)emove a Vehicle");
        }
    }
}
