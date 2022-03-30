using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car Nissan = new Car()
            {
                PassNum = 4,
                DoorNum = 10,
                HasTrunk = true,
                Model = "Rogue",

                
            };
            Truck Toyota = new Truck();
            Toyota.DoorNum = 2;
            Toyota.Model = "Big";
            Toyota.BedSize = 12;

            SUV Buick = new SUV()
            {
                HatchSize = 14,
                BikeRack = true,
                WheelNum = 2,


            };
            ICompany Dellis = new Company();

            Dellis.Name = "Dellis";
            Dellis.TagLine = "Now that's the stuff";
            Console.WriteLine($"Our Company {Dellis.Name} has a new Toyota.");
            Console.WriteLine($"Our Toyota has {Toyota.DoorNum} doors and a {Toyota.BedSize} inch bed.");
            Console.WriteLine($"This truck is way better than our Nissan {Nissan.Model} with {Nissan.DoorNum} doors");
            Console.WriteLine($"Next will be the Buick with a hatch size of {Buick.HatchSize} inches.");


        }
    }
}
