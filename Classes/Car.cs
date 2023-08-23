using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_3_Homework.Classes
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public string Countries { get; set; }

        public override void PrintVehicle()
        {
            Console.WriteLine($"ID{Id}, Type{Type}, Countries Produced In: {Countries}");
        }
    }
}