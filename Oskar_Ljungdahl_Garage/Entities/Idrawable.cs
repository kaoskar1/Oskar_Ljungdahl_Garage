using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oskar_Ljungdahl_Garage.Entities
{
    internal interface IDrawable
    {
        int Wheels { get; set; }
        int TopSpeed { get; set; }
        int Seats { get; set; }
        string NumberPlate { get; set; }
        ConsoleColor Color { get; set; }

    }
}
