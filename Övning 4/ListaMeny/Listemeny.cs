using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Övning_4.Namnlista;

namespace Övning_4.ListaMeny
{
     public class Listemeny
    {
        static public void ExamineList()
        {
            int decider = 0;
            while (true)
            {
                Console.WriteLine("1.Lägg till till lista \n2.Visa listans innehåll \n3.Ta Bort element" +
                    "\n4.Tillbaka till huvudmeny");
                decider = CW.readNumber();

                switch (decider)
                {
                    case 1:
                        addUser();
                        break;
                    case 2:
                        checkListSize();
                        break;

                    case 3:
                        removeUser();
                        break;
                    case 4:
                        return;

                }
            }



        }

        static void addUser()
        {
            string name = CW.readString();

            namnlista.Add(name);
            checkifListGrew();
        }

        static void removeUser(string name)
        {
            namnlista.Remove(name);

        }

        static void checkifListGrew()
        {
            bool didListCapacityIncrease = false;

            int difference = namnlista.Capacity - listCapacity;

            if (listlength != namnlista.Count)
            {
                listlength = namnlista.Count;
                Console.WriteLine("listan ökade i storlek");
                Console.WriteLine(namnlista.Count);
            }

            if (listCapacity != namnlista.Capacity)

            {
                listCapacity = namnlista.Capacity;
                Console.WriteLine("Listans kapacitet ökade med " + difference);
                didListCapacityIncrease = true;
            }

            if (didListCapacityIncrease)
            {
                removeElementAndCheckCapacity();
            }

        }

        static void checkListSize()
        {
            int j = namnlista.Capacity;
            int i = namnlista.Count();


            foreach (String s in namnlista)
            {
                Console.Write(s + "\t");
            }
            Console.WriteLine("det finnes " + i);
            Console.WriteLine("Listans kapacitet är" + j);
        }

        static void removeElementAndCheckCapacity()
        {
            namnlista.Clear();

            if (namnlista.Capacity != listCapacity)
            {
                Console.WriteLine("kapaciteten minskade");
            }
            else Console.WriteLine("kapaciteten oförändrad");
        }

        static void removeUser()
        {
            string s = CW.readString();
            if (namnlista.Contains(s))
            {
                namnlista.Remove(s);
                Console.WriteLine(s + "borttagen");
            } else
            {
                Console.WriteLine($"{s} fanns inte i listan");
            }
        }
    }
}
