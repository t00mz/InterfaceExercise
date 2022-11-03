using System;
using System.Collections.Generic;

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
                  

            var myCar = new Car() 
            { 
                Name = "car",
                Trunk = true, 
                Sedan = true, 
                NumberOfWheels = 4, 
                Model = "5.50i", 
                Make = "BMW", 
                Year = 2015, 
                Logo = "BMW logo", 
                CompanyName = "Bayerische Motoren Werke GmbH"
            };

            var myTruck = new Truck() 
            {
                Name = "truck",
                BedSize = "6 ft", 
                FourWheelDrive = true, 
                NumberOfWheels = 6, 
                Model = "F-150", 
                Make = "Ford", 
                Year = 2018, 
                Logo = "Ford Logo", 
                CompanyName = "Ford Motor Company" 
            };

            var mySUV = new SUV() 
            {
                Name = "SUV",
                RowsOfSeating = 2, 
                CargoHoldSize = "3 ft", 
                NumberOfWheels = 4, 
                Model = "Escalade", 
                Make = "Cadillac", 
                Year = 2020, 
                Logo = "Cadilac Logo", 
                CompanyName = "General Motors" };

            var myVehicles = new List<IVehicle>() { myCar, myTruck, mySUV };

            //Creatively display and organize their values   

            foreach (var vehicle in myVehicles)
            {
               vehicle.PrintInfo();
               Console.WriteLine();
            }

        }
    }
}
