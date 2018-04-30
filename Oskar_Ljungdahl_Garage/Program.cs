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
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.WriteLine("****GARAGE****");
            Console.WriteLine("****(L)ist****");
            //Console.WriteLine("List all the vehicle in the (G)arage");
            //Console.WriteLine("List vehicle (T)ypes");
            Console.WriteLine("****(S)earch****");
            //Console.WriteLine("Search on the (N)umber plate");
            //Console.WriteLine("Search on (P)roperties");
            Console.WriteLine("****(E)dit****");
            //Console.WriteLine("(A)dd A Vehicle");
            //Console.WriteLine("(R)emove a Vehicle");
            Console.WriteLine("    (B)ack   ");
            Console.WriteLine("    (Q)uit");

            var menuMode = true;
            do {

                var key = Console.ReadKey(intercept: true).Key;
                switch (key)
                {

                    case ConsoleKey.L:
                        menuMode = true;
                        Console.WriteLine("L preesed");
                        break;

                    case ConsoleKey.G:
                        menuMode = true;
                        Console.WriteLine("G preesed");
                        break;

                    case ConsoleKey.T:
                        menuMode = true;
                        Console.WriteLine("T preesed");
                        break;

                    case ConsoleKey.S:
                        menuMode = true;
                        Console.WriteLine("S preesed");
                        break;

                    case ConsoleKey.N:
                        menuMode = true;
                        Console.WriteLine("N preesed");
                        break;

                    case ConsoleKey.P:
                        menuMode = true;
                        Console.WriteLine("P preesed");
                        break;

                    case ConsoleKey.E:
                        menuMode = true;
                        Console.WriteLine("E preesed");
                        break;

                    case ConsoleKey.A:
                        menuMode = true;
                        Console.WriteLine("A preesed");
                        break;

                    case ConsoleKey.R:
                        menuMode = true;
                        Console.WriteLine("R preesed");
                        break;

                    case ConsoleKey.B:
                        menuMode = true;
                        Console.WriteLine("B preesed");
                        break;

                    case ConsoleKey.Q:
                        menuMode = true;
                        Console.WriteLine("Q preesed");
                        break;

                }
            } while (menuMode);

        }
    }
}
