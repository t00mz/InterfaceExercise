using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    //In each of your car, truck, and suv classes

    /*Create 2 members that are specific to each class
     * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     * 
     */
    public class Car : IVehicle, ICompany
    {

        public string Name { get; set; }
        public bool Trunk { get; set; }
        public bool Sedan { get; set; }
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Type of vehicle: {Name}, Number of wheels: {NumberOfWheels}, Model: {Model}, Make: {Make}, Year: {Year}, Logo: {Logo}, Company Name {CompanyName}, Sedan {Sedan}, Trunk: {Trunk}");
        }
    }
}
    