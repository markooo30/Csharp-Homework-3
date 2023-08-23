using CAS_3_Homework.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
//Create a static class that serves as a DB, that has list of Vehicles.In this list put objects of type
//Car, Bike and Vehicle.
namespace CAS_3_Homework.Static_DB
{
    public static class Database {

        

        public static List<Vehicle> vehicles = new List<Vehicle>();

        public static void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        
        public static void AddCar (Car car)
        {
            vehicles.Add(car);
        }
        public static void AddBike(Bike bike)
        {
            vehicles.Add(bike);
        }

        public static List<Vehicle> GetVehicles()
        {
            return vehicles;
        }
    }

}

























    //{
    //    public class Vehicle
    //    {

    //        public string Typee { get; set; }
    //    }

    //    public static List<Vehicle> vehicles = new List<Vehicle>();

    //    public static void AddVehicle(Vehicle vehicle)
    //    {
    //        vehicles.Add(vehicle);
    //    }

    //    public static List<Vehicle> GetVehicle()
    //    {
    //        return vehicles;
    //    }






