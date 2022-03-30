using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int WheelNum { get; set; } 
        public int DoorNum { get; set; } 
        public bool HasTrunk { get; set; } 
        public string Model { get; set; }
    }
   
    public class Car : IVehicle
    {
        public int WheelNum { get; set; } = 4;
        public int DoorNum { get; set; } = 4;
        public bool HasTrunk { get; set; } = true;
        public string Model { get; set; }
        public int PassNum { get; set; }
        public int TrunkSize { get; set; }

    }
    public class Truck : IVehicle
    {
        public int WheelNum { get; set; } = 4;
        public int DoorNum { get; set; } = 4;
        public bool HasTrunk { get; set; } = true;
        public string Model { get; set; }
        public int BedSize { get; set; }    
        public int TowWeight    { get; set; }


    }
    public class SUV : IVehicle
    {
        public int WheelNum { get; set; } = 4;
        public int DoorNum { get; set; } = 4;
        public bool HasTrunk { get; set; } = true;
        public string Model { get; set; }
        public bool BikeRack { get; set; } = true;
        public int HatchSize { get; set; }  

    }
}
