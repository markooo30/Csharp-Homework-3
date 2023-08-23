using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_3_Homework.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public string BatchNumber { get; set; }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"ID: {Id}, Type: {Type}, Year of Production: {YearOfProduction}");
        }
    }
}