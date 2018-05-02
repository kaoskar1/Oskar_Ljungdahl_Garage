using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oskar_Ljungdahl_Garage.Entities
{
    internal class Car : Vehicle
    {
          
        public string Brand { get; set; }
        public string TypeOfCar { get; set; }
        

        public Car(int wheels, int topSpeed, int seats, string numberPlate, ConsoleColor color, string brand, string typeOfCar) : base(wheels, topSpeed, seats, numberPlate, color)
        {
  
            Brand = brand;
            TypeOfCar = typeOfCar;

        }
    }
}

