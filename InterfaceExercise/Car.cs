using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car: IVehicle, ICompany
    {
        public int TrunkSize { get; set; }
        public bool AppleCarPlay { get; set; }
        public string Logo { get; set; }
        public int WarrantyLength { get; set; }
        public int NumberofDoors { get; set; }
        public int NumberofSeats { get; set; }
        public int MPG { get; set; }
        public string VehicleName { get; set; }

    }
}
