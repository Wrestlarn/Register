using Övning_4.ListaMeny;
using static Övning_4.Namnlista;
namespace Övning_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int decider = 0;
            while (true)
            {
                Console.WriteLine(
                    "\n1. Examine a List"
                   + "\n2. Examine a Queue"
                   + "\n3. Examine a Stack"
                   + "\n4. CheckParanthesis"
                   + "\n0. Exit the application");
                decider = CW.readNumber();    
                switch (decider)
                {
                    case 1:
                        ListaMeny.Listemeny.ExamineList();
                        break;
                    case 2:
                        Kömeny.showQueueMeny();
                        break;
                    case 3:
                        StackMeny.showStackMeny();
                        break;
                    case 4:
                        Excercises.checkParantheses(); 
                        break;
                }
            }
        }

        /* 1.I stacken staplas metoder med tillhörande variabler och referenser
         * Heapen lagrar typer dynamiskt och finns så länge de har pekare
         * 2. Olika datatyper sparas som antingen value eller referens.
         * 3.int är value type och myint är ett objekt som ändras via referens
        */
    }
}