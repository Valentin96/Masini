using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini
{
    class Car
    {
        string VIN;
        string Make;
        string Model;
        int Year;
        string PlateNumber;

        public Car(string vIN, string make, string model, int year, string plateNumber)
        {
            VIN = vIN;
            Make = make;
            Model = model;
            Year = year;
            PlateNumber = plateNumber;
        }

       
    }
}
