using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck: IVehicle, ICompany
    {
        public string TruckType { get; set; }
        public bool HasBed { get; set; }
        public string Logo { get; set; }
        public int WarrantyLength { get; set; }
        public int NumberofDoors { get; set; }
        public int NumberofSeats { get; set; }
        public int MPG { get; set; }
        public string VehicleName { get; set; }
    }

}
