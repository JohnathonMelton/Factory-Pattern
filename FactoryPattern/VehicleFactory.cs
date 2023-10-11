using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            if (numberOfTires == 2)
            {
                return new Motorcycyle();
            }
            else if (numberOfTires == 4)
            {
                return new Truck();
            }
            else
            {
                throw new ArgumentException("Invalid number of tires");
            }
        }
    }
}
