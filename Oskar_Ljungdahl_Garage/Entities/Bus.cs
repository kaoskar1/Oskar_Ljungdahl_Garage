﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oskar_Ljungdahl_Garage.Entities
{
    class Bus : Vehicle
    {

        public int Length { get; set; }
        public bool Articulated { get; set; }
       

        public Bus(int wheels, int topSpeed, int seats, string numberPlate, ConsoleColor color, int length, bool articulated):base(wheels, topSpeed, seats, numberPlate, color)
        {
            Length = length;
            Articulated = articulated;
        }
    }
}
