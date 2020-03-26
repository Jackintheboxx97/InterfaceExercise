using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.AppleCarPlay = true;
            car.TrunkSize = 16;
            car.Logo = true;
            car.MPG = 19;
            car.NumberofDoors = 4;
            car.NumberofSeats = 5;
            car.VehicleName = "2020 Chrysler 300";
            car.WarrantyLength = "3 months"; 

                       
            var suv = new SUV();
            suv.SeatRows = 2;
            suv.NumberofCupHolders = 4;
            suv.Logo = true;
            suv.MPG = 24;
            suv.NumberofDoors = 4;
            suv.NumberofSeats = 5;
            suv.VehicleName = "2016 Mazda Cx-5";
            suv.WarrantyLength = "3 months";

            var truck = new Truck();
            truck.NumberofDoors = 2;
            truck.TruckType = "Pick-up";
            truck.HasBed = true;
            truck.Logo = true;
            truck.MPG = 15;
            truck.NumberofDoors = 2;
            truck.NumberofSeats = 5;
            truck.VehicleName = "2017 Ram 1500";

            




                  

        //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

        //DONECreate 2 Interfaces called IVehicle & ICompany

        //DONE Create 3 classes called Car , Truck , & SUV

        //In your IVehicle

        /* DONECreate 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */


        //In ICompany

        /*DONE Create 2 members that are specific to each every company
         * regardless of vehicle type.
         *
         *
         * Example: public string Logo { get; set; }
         */

        //In each of your car, truck, and suv classes

        /*DONECreate 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * DONEThen, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */

        //DONENow, create objects of your 3 classes and give their members values;
        //DONECreatively display and organize their values
    }
    }
}
