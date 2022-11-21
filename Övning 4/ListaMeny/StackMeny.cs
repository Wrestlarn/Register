using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4.ListaMeny
{
    internal class StackMeny
    {

        public static void showStackMeny()
        {
            int decider = 0;

            while (true)
            {
                Console.WriteLine("Välkommen till stackmenyn");
                Console.WriteLine("1.Lägg till till stack  \n2.Ta bort från stack" +
                    "\n3.visa kön \n4.Omvänd sträng \n5.Tillbaka till huvudmeny");

                decider = CW.readNumber();



                switch (decider)
                {
                    case 1:
                        Stacks.inStack();
                        break;
                    case 2:
                        Stacks.outStack();
                        break;
                    case 3:
                        Stacks.listStack();
                        break;
                        case 4:
                        Stacks.reverseString();
                        break;
                    case 5:
                        return;


                }



            }

        }

    }
}
