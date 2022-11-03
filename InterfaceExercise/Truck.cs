using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string Name { get; set; }
        public string BedSize { get; set; }
        public bool FourWheelDrive { get; set; }
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Type of vehicle: {Name}, Number of wheels: {NumberOfWheels}, Model: {Model}, Make: {Make}, Year: {Year}, Logo: {Logo}, Company Name {CompanyName}, Four wheel drive: {FourWheelDrive}, Bed size: {BedSize}");
        }


    }
}
