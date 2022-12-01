using Övning_5.Garage;
using Övning_5.Vehicles.VehiclesCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Övning_5.Vehicles
{
    public abstract class Vehicle
    {
        protected int numberOfEngines;
        protected int numberOfSeats;
        protected FuelType fuelType;
        protected string regnr;
        protected Colors color;
        protected VehicleType vehicleType;

        public virtual void setColor(Colors color)
        {
            this.color = color;
        }
        public virtual void setNumberOfSeats(int seats)
        {
            this.numberOfSeats = seats;
        }
        public virtual void setFuelType(FuelType fueltype)
        {
            this.fuelType = fueltype;
        }
        public virtual void setRegnr(string regnr)
        {
            this.regnr = regnr;
        }

        public VehicleType getVehicleType()
        {
            return this.vehicleType;
        }


        public string getRegnr()
        {
            return this.regnr;
        }

        public int getNumberOfSeats()
        {
            return this.numberOfSeats;
        }
        public int getNumberOfEngines()
        {
            return this.numberOfEngines;
        }

        public Colors getColor()
        {
            return this.color;
        }

        public FuelType getFuelType()
        {
            return this.fuelType;
        }
        public static void GenerateMassiveAmountsOfVehicles()
        {
            Random ran = new Random();
            string regnr = "";
            for (int i = 0; i <= 500; i++)
            {
                Type type = typeof(VehicleType);
                Array values = type.GetEnumValues();
                int randomValue = ran.Next(values.Length);
                VehicleType vtype = (VehicleType)values.GetValue(randomValue);
                Console.WriteLine(vtype);
                type = typeof(Colors);
                values = type.GetEnumValues();
                randomValue = ran.Next(values.Length);
                Colors ctype = (Colors)values.GetValue(randomValue);
                Console.WriteLine(ctype);
                type = typeof(FuelType);
                values = type.GetEnumValues();
                randomValue = ran.Next(values.Length);
                FuelType ftype = (FuelType)values.GetValue(randomValue);
                Console.WriteLine(ftype);
                regnr = generateRegnr();

                if (vtype == VehicleType.Car)
                {
                    Vehicle v = new Car(1, regnr, 4, ftype, ctype, vtype);
                    GarageHandler.vehicleList.Add(v);
                }
                if (vtype == VehicleType.Boat)
                {
                    Vehicle v = new Boat(1, regnr, 4, ftype, ctype, vtype);
                    GarageHandler.vehicleList.Add(v);
                }
                if (vtype == VehicleType.Airplane)
                {
                    Vehicle v = new Airplane(1, regnr, 4, ftype, ctype, vtype);
                    GarageHandler.vehicleList.Add(v);
                }
                if (vtype == VehicleType.Bus)
                {
                    Vehicle v = new Bus(1, regnr, 4, ftype, ctype, vtype);
                    GarageHandler.vehicleList.Add(v);
                }
                if (vtype == VehicleType.Motorcycle)
                {
                    Vehicle v = new Motorcycle(1, regnr, 4, ftype, ctype, vtype);
                    GarageHandler.vehicleList.Add(v);
                }

            }

            foreach (Vehicle v in GarageHandler.vehicleList)
            {
                Garage.GarageHandler.vehicleQueue.Enqueue(v);
            }

        }

        public static string generateRegnr()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder("", 6);
            int nr;
            char c;
            for (int i = 0; i <= 2; i++)
            {
                nr = rnd.Next(65, 90);
                c = (char)nr;
                sb.Append(c);
            }
            for (int j = 0; j <= 2; j++)
            {
                nr = rnd.Next(48, 57);
                c = (char)nr;
                sb.Append(c);
            }

            Console.WriteLine(sb);
            return sb.ToString();
        }

        public abstract string Stats();

    }
    public enum FuelType
    {
        Diesel,
        Gasoline,
        Electric
    }
    public enum Colors
    {
        Blue,
        Red,
        Green,
        Yellow,
        White,
        Black,
        Grey
    }

    public enum VehicleType
    {
        Airplane,
        Car,
        Motorcycle,
        Bus,
        Boat
    }
}
