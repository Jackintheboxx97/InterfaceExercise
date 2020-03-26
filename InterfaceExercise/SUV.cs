using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV: IVehicle, ICompany
    {
        public int NumberofCupHolders  { get; set; }
        public int SeatRows { get; set; }
        public string Logo { get; set; }
        public int WarrantyLength { get; set; }
        public int NumberofDoors { get; set; }
        public int NumberofSeats { get; set; }
        public int MPG { get; set; }
        public string VehicleName { get; set; }
    }
}
