using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.Garage
{
    internal interface IGarage
    {
        bool openGarageDoor();
        int getAvailableCapacity();

        void listParkedVehicles();

        void populateGarage();
    }
}
