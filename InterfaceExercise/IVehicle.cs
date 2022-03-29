using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class IVehicle
    {
        public int WheelNum { get; set; } = 4;
        public int DoorNum { get; set; } = 4;
        public bool HasTrunk { get; set; } = true;
        public string Model { get; set; }
    }
    public class ICompany
    {
        public string Name { get; set; }
        public string TagLine   { get; set; }
    }
    public class Car : IVehicle
    {
        public int PassNum { get; set; }
        public int TrunkSize { get; set; }

    }
    public class Truck : IVehicle
    {
        public int BedSize { get; set; }    
        public int TowWeight    { get; set; }


    }
    public class SUV : IVehicle
    {
        public bool BikeRack { get; set; } = true;
        public int HatchSize { get; set; }  

    }
}
