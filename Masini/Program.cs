using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("viiin", "bmw", "320", 1999, "PH-10-BMW ca toti taranii");
            Repair repar = new Repair("viiin", "busita rau", 10000);

            DataSetCreator dsc = new DataSetCreator();
            dsc.FillVehiclesDataTable(car);
            dsc.PrintVehiclesDataTable();


          //  Console.WriteLine(aa.GetXml());
            Console.ReadKey();
        }
    }
}
