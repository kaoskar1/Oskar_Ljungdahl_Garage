using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oskar_Ljungdahl_Garage.Entities
{
    class Bikes : Vehicle
    {
        public bool MotorDriven { get; set; }
        public string TypeOfBike { get; set; }

    public Bikes(int wheels, int topSpeed, int seats, string numberPlate, ConsoleColor color, bool motorDriven, string typeOfBike) : base(wheels, topSpeed, seats, numberPlate, color)
        {
 
            MotorDriven = motorDriven;
            TypeOfBike = typeOfBike;
        }

    }
}
