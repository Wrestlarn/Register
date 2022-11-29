using Övning_5.Garage;
using Övning_5.Vehicles;
using Övning_5.Vehicles.VehiclesCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.Menues
{
    internal static class WelcomeMenu
    {
        public static string WelcomeText = "Hej o Välkommen till Garage 1.0";
        public static string MainMeny = "1.Skapa nytt Garage +\n2.Autogenerera Garage med fordon \n3.Hantera Garage";

        public static void mainMeny()
        {
            int decider = 0;
            while (true)
            {
                Console.WriteLine("1.Skapa nytt Garage \n2.Autogenerera Garage med fordon \n3.GarageMeny");
                decider = UserInput.UserInputHandler.readNumber();

                switch (decider)
                {
                    case 1:
                        Garage.GarageHandler.createNewGarage();
                        break;
                    case 2:
                       Garage.GarageHandler.autoPrepareGarageAndVehicles();
                        break;

                    case 3:
                        Menues.GarageMenu.GarageSelectorMenu();
                        break;
                    

                }
            }
        }
    }
}
