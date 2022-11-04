using Biograf.Besökarregister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf.Meny
{
    public class MenyInfo
    {
       public static void menuChoise()
        {
            int decider = 0;
            while (true)
              
            {
                Console.WriteLine("Hej o Välkommen till Filmstaden");
                Console.WriteLine("1.Registrera Besökare \n2.Visa pris för biobesöket " +
                    "\n3.Upprepa Sträng  \n4.Hitta tredje ordet \n5.Avsluta");
                try
                {
                    decider = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Ange svarsalternativ");
                }


                switch (decider)
                {
                    case 1:
                        Register.registerNewCustomer();
                        break;

                        case 2:
                        Register.checkCoutAndPrice();
                        break;

                    case 3:
                        Excercises.exercises.repeatString();
                        break;

                    case 4:
                        Excercises.exercises.splitMyString();
                        break;


                    case 5:
                        Environment.Exit(0);
                        break;


                }

            }



        }



    }
}
