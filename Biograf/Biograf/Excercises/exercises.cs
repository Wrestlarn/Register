using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf.Excercises
{
    public class exercises
    {
        public static void repeatString()
        {
            string onRepeat;

            Console.WriteLine("Ange text som ska upprepas");
            onRepeat = Console.ReadLine();

            for(int i = 1; i<= 10; i++)
            {
                Console.Write(onRepeat + "\t");
            }

            Console.WriteLine();

        }
    
        public static void splitMyString()
        {
            string[] words;
            string mening;
            Console.WriteLine("Skriv en mening");
            mening = Console.ReadLine();

            words = mening.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 2)
            {
                Console.WriteLine("Det tredje order var " + words[2]);
               
            }

           
        }


    }
}
