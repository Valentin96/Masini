using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini
{
    class DataSetCreator
    {
        //DataTable Vehicles = new DataTable("Vehicles");
        //DataTable Repairs = new DataTable("Repairs");
        
        public DataSet CreateSchema()
        {


            DataTable Vehicles= new DataTable("Vehicles");
            DataTable Repairs = new DataTable ("Repairs");
            Vehicles.PrimaryKey = new DataColumn[] { Vehicles.Columns["VIN"] };
            Vehicles.Columns.Add("VIN", typeof(String));
            Vehicles.Columns.Add("Make", typeof(String));
            Vehicles.Columns.Add("Model", typeof(String));
            Vehicles.Columns.Add("Year", typeof(int));
            Vehicles.Columns.Add("PlateNumber", typeof(String));
            Repairs.PrimaryKey = new DataColumn[] {Repairs.Columns["ID"]};
            DataColumn idColumn=  Repairs.Columns.Add("ID",typeof(int));
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 0;
            idColumn.AutoIncrementStep = 1;

            
            Repairs.Columns.Add("VIN", typeof(String));
            Repairs.Columns.Add("Description", typeof(String));
            Repairs.Columns.Add("Cost", typeof(float));
            Repairs.Columns.Add("Timestamp", typeof(DateTime));


            DataSet VehicleRepairs = new DataSet("VehicleRepairs");
            VehicleRepairs.Tables.Add(Vehicles);
            VehicleRepairs.Tables.Add(Repairs);
           
            return VehicleRepairs;
           // Console.WriteLine(VehicleRepairs.GetXml());


        }

        public void FillVehiclesDataTable(Car masina)
        {
            DataSetCreator d = new DataSetCreator();
            DataSet q = d.CreateSchema();
            DataTable tabel = q.Tables["Vehicles"];
            tabel.Rows.Add(masina);
        }

        public void FillRepairsDataTable(Repair reparatie)
        {
            DataSetCreator d = new DataSetCreator();
            DataSet q = d.CreateSchema();
            DataTable tabel = q.Tables["Repairs"];
            tabel.Rows.Add(reparatie);
        }
       //sadasdasewqeq sadasdas

            public void aolo()
        {

        }

        public void PrintVehiclesDataTable()
        {
            DataSetCreator d = new DataSetCreator();
            DataSet q = d.CreateSchema();
            DataTable tabel = q.Tables["Vehicles"];
            foreach (DataRow dataRow in tabel.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PrintRepairsDataTable()
        {
            DataSetCreator d = new DataSetCreator();
            DataSet q = d.CreateSchema();
            DataTable tabel = q.Tables["Repairs"];
            foreach (DataRow dataRow in tabel.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }






































        //public void FillVehiclesDataTable(Car masina)
        //{
        //    DataSetCreator d = new DataSetCreator();
        //    DataSet q = d.CreateSchema();
        //    DataTable tabel = q.Tables["Vehicles"];
        //    tabel.Rows.Add(masina);


        //}
        //public void FillRepairsDataTable(Repair reparatie)
        //{
        //    DataSetCreator d = new DataSetCreator();
        //    DataSet q = d.CreateSchema();
        //    DataTable tabel = q.Tables["Repairs"];
        //    tabel.Rows.Add(reparatie);
        //}
        //public void PrintVehiclesDataTable()
        //{
        //    DataSetCreator d = new DataSetCreator();
        //    DataSet q = d.CreateSchema();
        //    DataTable tabel = q.Tables["Vehicles"];

        //    //foreach (DataRow item in tabel.Rows)
        //    //{
        //    //    string VIN = item["VIN"].ToString();
        //    //    string Make = item["Make"].ToString();
        //    //    string Model = item["Model "].ToString();
        //    //    string Year = item["Year"].ToString();
        //    //    string PlateNumber = item["PlateNumber"].ToString();


        //    //}
        //    foreach (DataRow row in tabel.Rows)
        //    {
        //        Console.WriteLine();
        //        for (int x = 0; x < tabel.Columns.Count; x++)
        //        {
        //            Console.Write(row[x].ToString() + " ");
        //        }
        //    }

        //}

        //public void PrintRepairsDataTable()
        //{
        //    DataSetCreator d = new DataSetCreator();
        //    DataSet q = d.CreateSchema();
        //    DataTable tabel = q.Tables["Repairs"];
        //    foreach (DataRow row in tabel.Rows)
        //    {
        //        Console.WriteLine();
        //        for (int x = 0; x < tabel.Columns.Count; x++)
        //        {
        //            Console.Write(row[x].ToString() + " ");
        //        }
        //    }
        //}

    }
}
