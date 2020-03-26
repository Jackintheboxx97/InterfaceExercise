using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int NumberofDoors { get; set; }
        public int NumberofSeats { get; set; }
        public int MPG { get; set; }
        public string VehicleName { get; set; }
    }
}
