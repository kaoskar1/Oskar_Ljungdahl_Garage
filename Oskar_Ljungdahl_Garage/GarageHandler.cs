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


        internal static void Remove()
        {


        }


        internal static void Search()
        { 
            Console.WriteLine("Serach for car by the License Plate");
            string searchForaPlate = Console.ReadLine();
        }

        internal static void Add()
        {
            Console.Clear();
            Console.WriteLine("what kid of vehicle?");
            //Console.WriteLine("Boats");
            //Console.WriteLine("Bus");
            //Console.WriteLine("Car");
            //Console.WriteLine("AirPlane");
            //Console.WriteLine("Bikes");
            //string kindOfVehicle = (Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Wheels?");
            int wheels = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Top Speed?");
            int topSpeed = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Seats?");
            int seats = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("License plate");
            string numberPlate = (Console.ReadLine());
            Console.Clear();
            ConsoleColor color = ConsoleColor.DarkBlue;
            Console.WriteLine("brand of car");
            string brand = (Console.ReadLine());
            Console.Clear();
            Console.WriteLine("type of car");
            string typeOfCar = (Console.ReadLine());


            var bil = new Car(wheels, topSpeed, seats, numberPlate, color, brand, typeOfCar);
            mittGarage.Add(bil);
            

            //var buss = new Bus(wheels, topSpeed, seats, numberPlate, color, length, articulated);
            //mittGarage.Add(buss);

            //var baut = new Boat(wheels, topSpeed, seats, numberPlate, color, sailing);
            //mittGarage.Add(baut);

            //var flygplan = new Airplanes(wheels, topSpeed, seats, numberPlate, color, weaponMode, miselCount);
            //mittGarage.Add(flygplan);

            //var bike = new Bikes(wheels, topSpeed, seats, numberPlate, color, motorDriven, typeOfBike);
            //mittGarage.Add(bike);
        }

        internal static void PrintList()
        {
            foreach (var item in mittGarage)
            {
                Console.WriteLine((item as Car).Wheels + "                              ");
                Console.WriteLine((item as Car).TypeOfCar + "                           ");
                Console.WriteLine((item as Car).NumberPlate + "                         ");
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
