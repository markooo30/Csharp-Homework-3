using CAS_3_Homework.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CAS_3_Homework.Static_Validator
{
    public static class Validator
    {

        
        public static bool Validation(Vehicle vehicle)
        {
            if (vehicle.Id == 0 || vehicle.YearOfProduction == 0 || string.IsNullOrEmpty(vehicle.Type))
            {
                //Console.WriteLine("NOT VALID");
                return false;
            }
            else
            {
                //Console.WriteLine("VALID");
                return true;
            }
        }

    }
}
