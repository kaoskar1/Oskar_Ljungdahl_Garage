using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oskar_Ljungdahl_Garage.Entities
{
    internal abstract class Vehicle : IDrawable
    {

        public int Wheels { get; set; }
        public int TopSpeed { get; set; }
        public int Seats { get; set; }
        public string NumberPlate { get; set; }
        public virtual ConsoleColor Color { get; set; }


        public Vehicle(int wheels, int topSpeed, int seats, string numberPlate, ConsoleColor color)
        {
            Wheels = wheels;
            TopSpeed = topSpeed;
            Seats = seats;
            NumberPlate = numberPlate;
            Color = color;
        }

     


    }
}
