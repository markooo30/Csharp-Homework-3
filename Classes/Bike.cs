using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_3_Homework.Classes
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public override void PrintVehicle()
        {
            Console.WriteLine($"ID{Id}, Color: {Color}");
        }
    }
}