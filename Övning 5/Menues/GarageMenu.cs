using Övning_5.Garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Övning_5.Vehicles;

namespace Övning_5.Menues
{
    internal class GarageMenu
    {
        public static void GarageSelectorMenu()
        {
            while(true)
            {
                int decider = 0;
                Console.WriteLine("Hantera Garage här");
                Console.WriteLine("1.Visa Sparade Garage \n2.Välj Garage att hantera \n3.Hantera aktivt garage \n4.Generera Fordon" +
                    "\n5.Tillbaka");
                decider = UserInput.UserInputHandler.readNumber();

                switch (decider)
                {
                    case 1:
                        GarageHandler.showSavedGarages();
                        break;

                    case 2:
                        GarageHandler.selectGarageToHandle();
                       
                        break;
                        case 3:
                        Menues.ActiveGarageMenu.activeGarageMenu();
                        break;
                    case 4:
                        Vehicle.GenerateMassiveAmountsOfVehicles();
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
