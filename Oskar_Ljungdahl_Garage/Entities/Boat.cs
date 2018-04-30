using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oskar_Ljungdahl_Garage.Entities
{
    class Boat : Vehicle
    {
        public bool Sailing { get; set; }

        public Boat(int wheels, int topSpeed, int seats, string numberPlate, ConsoleColor color, bool sailing) : base(wheels, topSpeed, seats, numberPlate, color)
        {
            Sailing = sailing;
        }

    }
}
