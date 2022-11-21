using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4.ListaMeny
{
    internal class Kömeny
    {

        public static void showQueueMeny()
        {
            int decider = 0;

            while(true)
            {
                Console.WriteLine("Välkommen till kömenyn");
                Console.WriteLine("1.Lägg till till kö  \n2.Ta bort från kö" +
                    "\n3.visa kön \n4.Tillbaka till huvudmeny");

                decider = CW.readNumber();



                switch (decider)
                {
                    case 1:
                        addToQueue();
                        break;
                    case 2:
                        Kosystem.removeFromQueue();
                        break;
                    case 3:
                        Kosystem.showNamesInQueue();
                        break;
                    case 4:
                        return;
                        

                }



            }

        }



        public static void addToQueue()
        {
            string s = CW.readString();
            Kosystem.addPersonToQueue(s);

        }

        
        


    }
}
