
using Övning_5.Vehicles;
using Övning_5.Vehicles.VehiclesCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.Garage
{
    public class GarageHandler
    {
        public static Garage.Garage<Vehicle> selectedGarage;
        public static List<Garage.Garage<Vehicle>> garageList = new();
        public static Queue<Vehicle> vehicleQueue= new();
        public static List<Vehicle> vehicleList = new();
        public static void createNewGarage()
        {

            Console.WriteLine("Ange hur stort garaget skall vara");
            int i = UserInput.UserInputHandler.readNumber();
            string tempName = UserInput.UserInputHandler.readString();
            Garage.Garage<Vehicle> g = new Garage.Garage<Vehicle>(i,tempName);
            garageList.Add(g);
            Console.WriteLine("nytt garage upprättad");
        }
        
        public static void parkNewVehicleIntoMyGarage(Vehicle vehicle)
        {
        }
        public static void showSavedGarages()
        {
            if(garageList.Count > 0)
            {
                foreach(Garage.Garage<Vehicle> g in garageList)
                {
                    Console.WriteLine(g.stats());
                }
            }
        }
        public static void selectGarageToHandle()
        {
            string name;
            Console.WriteLine("Ange namn på det garage du vill hantera");
            name = UserInput.UserInputHandler.readString();

            foreach(Garage.Garage<Vehicle> g in garageList)
            {
                if (g.getName().Equals(name))
                {
                    selectedGarage = g;
                    Console.WriteLine(selectedGarage.getName() + " är nu vald");
                    
                }
            }

        }

        public static void autoPrepareGarageAndVehicles()
        {
            Garage.Garage<Vehicle> g = new(100,"FastSetup");
            selectedGarage = g;
            Vehicle.GenerateMassiveAmountsOfVehicles();
            Garage.GarageHandler.garageList.Add(g);
        }

    }
}
