using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {

        public int RowsOfSeating { get; set; }
        public string CargoHoldSize { get; set; }


        public string Name { get; set; }
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Type of vehicle: {Name}, Number of wheels: {NumberOfWheels}, Model: {Model}, Make: {Make}, Year: {Year}, Logo: {Logo}, Company Name {CompanyName}, Rows of seating: {RowsOfSeating}, Cargo hold size: {CargoHoldSize}");
        }

    }
}

