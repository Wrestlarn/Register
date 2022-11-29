using Xunit;
using Övning_5;
using Övning_5.Vehicles;
using Övning_5.Garage;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void FastSetup()
        {
            Övning_5.Garage.Garage<Vehicle> g = new(100, "FastSetup");
            GarageHandler.selectedGarage= g;
            Vehicle.GenerateMassiveAmountsOfVehicles();
            GarageHandler.garageList.Add(g);

            int expected = 100;
            int garagesize = GarageHandler.selectedGarage.getGarageCapacity();

            GarageHandler.selectedGarage.populateGarage();
            int numberofVehiclesExepcted = 1030;
            int numberofVehiclesActual = GarageHandler.selectedGarage.getNumberofPakedVehicles();

          

            Assert.Equal(expected, garagesize);
            
        }

        [Fact]
        public void populateGarage()
        {
            Övning_5.Garage.Garage<Vehicle> g = new(100, "FastSetup");
            GarageHandler.selectedGarage = g;
            Vehicle.GenerateMassiveAmountsOfVehicles();
            GarageHandler.garageList.Add(g);

            GarageHandler.selectedGarage.populateGarage();
            int numberofVehiclesExepcted = 100;
            int numberofVehiclesActual = GarageHandler.selectedGarage.getNumberofPakedVehicles();
            
            Assert.Equal(numberofVehiclesActual, numberofVehiclesExepcted);

        }

        [Fact]
        public void RemoveFromGarage()
        {
            Övning_5.Garage.Garage<Vehicle> g = new(100, "FastSetup");
            GarageHandler.selectedGarage = g;
            Vehicle.GenerateMassiveAmountsOfVehicles();
            GarageHandler.garageList.Add(g);
            GarageHandler.selectedGarage.populateGarage();

            int parkedVehicles = GarageHandler.selectedGarage.getNumberofPakedVehicles();

            GarageHandler.selectedGarage.removeCarFromGarage();

            int afterRemoval =  GarageHandler.selectedGarage.getNumberofPakedVehicles();


            Assert.Equal(afterRemoval + 1, parkedVehicles);
        }


    }

    

}