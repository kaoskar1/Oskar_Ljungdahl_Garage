using Oskar_Ljungdahl_Garage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Oskar_Ljungdahl_Garage
{
    static class GarageHandler
    {
        static private Garage<Vehicle> mittGarage;

        internal static void init()
        {
             mittGarage  = new Garage<Vehicle>(10);// let user bestama
        }

        internal static void Add()
        {
            Console.WriteLine("Wheels?");
            int wheels = int.Parse(Console.ReadLine());
            Console.WriteLine("Top Speed?");
            int topSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Seats?");
            int seats = int.Parse(Console.ReadLine()); 
            Console.WriteLine("License plate");
            string numberPlate = (Console.ReadLine());
            ConsoleColor color = ConsoleColor.DarkBlue;
            Console.WriteLine("brand of car");
            string brand = (Console.ReadLine());
            Console.WriteLine("type of car");
            string typeOfCar = (Console.ReadLine());


            var bil = new Car(wheels, topSpeed, seats, numberPlate, color, brand, typeOfCar);
            mittGarage.Add(bil);
        }

        internal static void PrintList()
        {
            foreach (var item in mittGarage)
            {
                Console.WriteLine((item as Car).Wheels + "                              ");
                Console.WriteLine((item as Car).TypeOfCar + "                              ");
                Console.WriteLine((item as Car).NumberPlate + "                              ");
            }
        }



        //public static void LicensePlate()
        //{
        //    Random random = new Random();
        //    var x = random.Next(100, 999);

        //    int num = random.Next(0, 26);
        //    char let = (char)('a' + num);

        //     Console.WriteLine(fixedPlate);

        //    string lets = Path.GetRandomFileName();
        //    Console.WriteLine(lets);
        //    lets.Replace(".", "");


        //    lets.ToUpper();


        //    lets = lets.Remove(3);



        //    var fixedPlate = (lets) + (x);


        //    Console.WriteLine(fixedPlate);
        //    // return lets;
        //}
    }
}
