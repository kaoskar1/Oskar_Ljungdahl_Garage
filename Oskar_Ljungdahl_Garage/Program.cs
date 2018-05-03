using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace Oskar_Ljungdahl_Garage
{
    internal class Program
    {

        private static int index = 0;
        private static void Main(string[] args)
        {
            makeTheMenu();
            
        }

        private static void makeTheMenu()
        {
            List<String> menuItems = new List<string>()
        {
            "List all The Vehicle",
            "Edit",
            "Search",
            "Add"
             // gör en klass 

        };

            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuItem = printMenu(menuItems);
                if (selectedMenuItem == "List all The Vehicle")
                {
                    Console.Clear();
                    GarageHandler.PrintList();
                    Console.WriteLine("List all The Vehicle"); Console.Read();
                }
                if (selectedMenuItem == "Add")
                {
                    Console.Clear();
                    GarageHandler.init();
                    GarageHandler.Add();
                    Console.WriteLine("*"); Console.Read();
                    GarageHandler.PrintList();

                }

                if (selectedMenuItem == "Search")
                {
                    Console.Clear();

                    GarageHandler.Search();
                    //Console.WriteLine("*"); Console.Read();
                    //GarageHandler.PrintList();

                }


                else if (selectedMenuItem == "Exit")
                {
                    Environment.Exit(0);

                }
            }
        }


        private static string
            printMenu(List<string> items)
        {


            for (int i = 0; i < items.Count; i++)
            {

                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {

                if (index == items.Count - 1)
                {
                    //    index = 0;
                }
                else
                { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = items.Count - 1;
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {

                return "";
            }

            Console.Clear();
            return "";
        }
    }

}

//    var menuMode = true;
//    do {

//        Console.SetCursorPosition(0, 0);
//        Console.CursorVisible = false;
//        Console.WriteLine("****GARAGE****");
//        Console.WriteLine("****(L)ist****");
//        GarageHandler.PrintList();

//        //Console.WriteLine("List all the vehicle in the (G)arage");
//        //Console.WriteLine("List vehicle (T)ypes");
//        Console.WriteLine("****(S)earch****");
//        //Console.WriteLine("Search on the (N)umber plate");
//        //Console.WriteLine("Search on (P)roperties");
//        Console.WriteLine("****(E)dit****");
//        Console.WriteLine("(A)dd A Vehicle");
//        Console.WriteLine("(R)emove a Vehicle");
//        Console.WriteLine("    (B)ack   ");
//        Console.WriteLine("    (Q)uit");

//        var key = Console.ReadKey(intercept: true).Key;
//        switch (key)
//        {

//            case ConsoleKey.L:
//                menuMode = true;
//                Console.WriteLine("L preesed");
//                //LicensePlate();
//                break;

//            case ConsoleKey.G:
//                menuMode = true;
//                Console.WriteLine("G preesed");
//                break;

//            case ConsoleKey.T:
//                menuMode = true;
//                Console.WriteLine("T preesed");
//                break;

//            case ConsoleKey.S:
//                menuMode = true;
//                Console.WriteLine("S preesed");
//                break;

//            case ConsoleKey.N:
//                menuMode = true;
//                Console.WriteLine("N preesed");
//                break;

//            case ConsoleKey.P:
//                menuMode = true;
//                Console.WriteLine("P preesed");
//                break;

//            case ConsoleKey.E:
//                menuMode = true;
//                Console.WriteLine("E preesed");
//                break;

//            case ConsoleKey.A:
//                menuMode = true;
//                GarageHandler.Add();
//                menuMode = false;
//                break;

//            case ConsoleKey.R:
//                menuMode = true;
//                Console.WriteLine("R preesed");
//                break;

//            case ConsoleKey.B:
//                menuMode = true;
//                Console.WriteLine("B preesed");
//                break;

//            case ConsoleKey.Q:
//                menuMode = true;
//                Console.WriteLine("Q preesed");
//                break;

//        }
//    } while (menuMode);
//    printMenu();

//}


