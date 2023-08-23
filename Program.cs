using CAS_3_Homework.Classes;
using CAS_3_Homework.Static_DB;
//using System.ComponentModel.DataAnnotations;
using CAS_3_Homework.Static_Validator;
namespace CAS_3_Homework
{

    // Create a class Vehicle with properties Id, Type, YearOfProduction, BatchNumber.
    // Create two classes Car and Bike that inherit from Vehicle.Car has property FuelTank (int) and
    //Countries in which it is produced and Bike has property Color.
    // Class Vehicle has method PrintVehicle that prints Id, Type and YearOfProduction.
    // Class Car also has method PrintVehicle that prints the Type and the Countries in which it is
    //produced.
    // Class Bike also has method PrintVehicle that Prints the YearOfProduction and the Color.

    // Create a static class that serves as a DB, that has list of Vehicles.In this list put objects of type
    //Car, Bike and Vehicle.

    // In the main program call PrintVehicle for each object in the list in the db.

    // Create a static class called Validator, that contains a method Validate, that receives a Vehicle and
    //validates is Id is not 0, that Type is not empty and YearOfProduction is not 0.
    // Call Validate from main Program with a couple of objects.
    public class Program
    {
        static void Main(string[] args)
        {

            Vehicle Vozilo = new Vehicle()
            {
                Id = 1,
                YearOfProduction = 2022,
                BatchNumber = "WAUZZ1234",
                Type = "Car"   
            };
            Car Kola = new Car()
            {

                Id = 2,
                Type = " BMW",      
                Countries = "Germany"

            };
            Bike Bicikl = new Bike()
            {

                Id = 3,
                Color = "Red"

            };

            //Database.AddVehicle(Vozilo);
            //Database.AddCar(Kola);
            //Database.AddBike(Bicikl);

            Database.AddVehicle(Vozilo);
            Database.AddVehicle(Kola);
            Database.AddVehicle(Bicikl);

            var vehicleList = Database.GetVehicles();
            foreach (var vehicle in vehicleList)
            {
                vehicle.PrintVehicle();
            }

            Console.WriteLine("");



            Console.WriteLine(Validator.Validation(Vozilo) ? "Vehicle is valid." : "Vehicle is not valid.");
            Console.WriteLine(Validator.Validation(Kola) ? "Car is valid." : "Car is not valid.");
            Console.WriteLine(Validator.Validation(Bicikl) ? "Bike is valid." : "Bike is not valid.");


        }


    }
    }

