 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oskar_Ljungdahl_Garage.Entities
{
    class Airplanes: Vehicle
    {
        public bool WeaponMode { get; set; }
        public int MiselCount { get; set; }

        public Airplanes(int wheels, int topSpeed, int seats, string numberPlate, ConsoleColor color, bool weaponMode, int miselCount) : base(wheels, topSpeed, seats, numberPlate, color)
        {
            WeaponMode = weaponMode;
            MiselCount = miselCount;
        }

    }
}
