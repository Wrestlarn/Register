

namespace Register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decider = 0;

            while (true)
            {
                Console.WriteLine("Hej o välkommen till registrator");
                Console.WriteLine("1. Lägg till ny anställd  \n2. Visa anställda \n3.avlsluta");

                try
                {
                    decider = int.Parse(Console.ReadLine());
                }catch (FormatException e)
                {
                    Console.WriteLine("Ange ett gitligt svarsalternativ");
                }
                




                switch (decider)
                {
                    case 1:
                        Person.Person.createNewEmployee();
                            break;

                    case 2:
                        Person.Person.listMyEmployees();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                }


            
            }   



        }
    }
}