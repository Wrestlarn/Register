using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4
{
    internal class Kosystem
    {
        public static Queue<string> myQueue= new Queue<string>();


        public static void addPersonToQueue(string name)
        {
            myQueue.Enqueue(name);  
        }

        public static void removeFromQueue()
        {
            if(myQueue.Count > 0)
            {
                myQueue.Dequeue();
            }
        }

        public static void showNamesInQueue()
        {
            foreach(string n in myQueue)
            {
                Console.WriteLine(n);
            }
        }


    }
}
