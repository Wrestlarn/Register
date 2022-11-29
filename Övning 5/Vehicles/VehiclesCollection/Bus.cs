using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.Vehicles.VehiclesCollection
{
    internal class Bus : Vehicle
    {
        public Bus(int numberOfEngines, string regnr, int nrofSeats, FuelType fueltype, Colors color,VehicleType vehicleType)
        {
            this.numberOfEngines = numberOfEngines;
            this.regnr = regnr;
            numberOfSeats = nrofSeats;
            fuelType = fueltype;
            this.color = color;
            this.vehicleType = vehicleType;
        }


        public override string Stats()
        {
            return $"Fordon: {regnr} {color} {vehicleType}";
        }

    }
}
