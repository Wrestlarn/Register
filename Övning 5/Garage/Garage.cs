
using Microsoft.VisualBasic;
using Övning_5.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Övning_5.Garage
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private string name;
        private T[] garageCapacity;
        private bool garageDoorOpen;
        int numberofParkedVehicles;

        public Garage(int capacity, string name)
        {
            this.garageCapacity = new T[capacity];
            this.garageDoorOpen = true;
            this.name = name;

        }

        public int getNumberofPakedVehicles()
        {
            return this.numberofParkedVehicles;
        }

        public int getGarageCapacity()
        {
            return this.garageCapacity.Length;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public T[] getList()
        {
            return this.garageCapacity;
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void listVehicles()
        {

            if (numberofParkedVehicles == 0)
            {
                return;
            }
            foreach (T t in garageCapacity)
            {
                if (t != null)
                {
                    Console.WriteLine(t.Stats());

                }

            }
            Console.WriteLine($"Det finns {this.numberofParkedVehicles} parkerade fordon");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public string stats()
        {
            return $"Garage: {name} {garageDoorOpen} {numberofParkedVehicles}";
        }

        public void populateGarage()
        {
            Vehicle.GenerateMassiveAmountsOfVehicles();



            for (int i = 0; i < this.garageCapacity.Length; i++)
            {
                if (GarageHandler.selectedGarage.garageCapacity[i] == null)
                {
                    try
                    {
                        this.garageCapacity[i] = (T)Garage.GarageHandler.vehicleQueue.Dequeue();
                        numberofParkedVehicles++;

                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("kön är tom");
                        break;
                    }


                }
            }

        }

        public void searchVehcilebyRegistryNumber()
        {
            if (GarageHandler.selectedGarage.numberofParkedVehicles == 0)
            {
                return;
            }

            Console.WriteLine("Ange registreringsnummer för sökning");
            string s = UserInput.UserInputHandler.readString();

            var query = (from v in GarageHandler.selectedGarage.garageCapacity
                         where String.Equals(v?.getRegnr(), s, StringComparison.OrdinalIgnoreCase)
                         select v);

            if (query.Any())
            {
                Console.WriteLine(query.ElementAt(0).Stats());
            }
            else Console.WriteLine("Hittade ingen bil med rgnmr");
        }

        public void searchByProperty()
        {
            if (GarageHandler.selectedGarage.numberofParkedVehicles == 0)
            {
                return;
            }

            string vehicletype, color, fueltype;

            foreach (int value in Enum.GetValues(typeof(VehicleType)))
            {
                Console.WriteLine(((VehicleType)value).ToString());
            }
            Console.WriteLine("ange vilken fodrontyp du vill söka på");
            vehicletype = UserInput.UserInputHandler.readString();

            foreach (int value in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(((Colors)value).ToString());
            }

            Console.WriteLine("ange vilken färg du vill söka på");
            color = UserInput.UserInputHandler.readString();

            foreach (int value in Enum.GetValues(typeof(FuelType)))
            {
                Console.WriteLine(((FuelType)value).ToString());
            }

            Console.WriteLine("ange vilken bränsletyp du vill söka på");
            fueltype = UserInput.UserInputHandler.readString();

            var query = from v in GarageHandler.selectedGarage.garageCapacity
                        where String.Equals(v?.getVehicleType().ToString(), vehicletype, StringComparison.OrdinalIgnoreCase)
                        where String.Equals(v?.getColor().ToString(), color, StringComparison.OrdinalIgnoreCase)
                        where String.Equals(v?.getFuelType().ToString(), fueltype, StringComparison.OrdinalIgnoreCase)
                        orderby v.getRegnr() descending
                        select v;


            if (query.Any())
            {
                foreach (Vehicle v in query)
                {
                    Console.WriteLine(v.Stats());
                }
            }
            else
            {
                Console.WriteLine("hittade inga fordon med sökattribut");
            }
        }

        public void removeCarFromGarage()
        {
            Vehicle v;
            Random random = new Random();
            int i;

            i = random.Next(this.garageCapacity.Length);

            if (this.garageCapacity[i] != null)
            {
                v = this.garageCapacity[i];
                Console.WriteLine(v.Stats() + "Lämnar garaget");
                this.garageCapacity[i] = null;
                this.numberofParkedVehicles--;
            }
            else
            {
                Console.WriteLine("Fanns ingen parkerad på denna plats");
            }




        }
    }
}
