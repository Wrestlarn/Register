using Övning_5.Garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.Menues
{
    internal class ActiveGarageMenu
    {
       public static void activeGarageMenu()
        {

            int decider = 0;
            while (true)
            {
                if (GarageHandler.selectedGarage == null)
                {
                    return;
                }

                Console.WriteLine("1.Visa Parkerade fordon \n2.Kör ut fordon från garage \n3.Fyll garaget \n4.Sök fordon" +
                    "\n5.Sök med egenskaper \n6.Tillbaka");
                decider = UserInput.UserInputHandler.readNumber();

                switch(decider)
                {
                    case 1:
                        GarageHandler.selectedGarage.listVehicles();
                        break;
                    case 2:
                        GarageHandler.selectedGarage.removeCarFromGarage();
                        break;
                    case 3:
                        GarageHandler.selectedGarage.populateGarage();
                        break;
                    case 4:
                        GarageHandler.selectedGarage.searchVehcilebyRegistryNumber();
                        break;

                    case 5:
                        GarageHandler.selectedGarage.searchByProperty();
                        break;
                    case 6:
                        return;

                }
            
            }

        }

    }
}
