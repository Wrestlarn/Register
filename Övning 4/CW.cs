using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4
{
    internal static class CW
    {
       

        static public int readNumber()
        {
            int number = 0;
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    return number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ange siffra");
                }
            }
            
        }

        static public string readString() 
        {
            string name;
            while (true)
            {
                Console.WriteLine("Ange Text");
                try
                {
                    name = Console.ReadLine();
                    if (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("fältet var tom");
                    }
                    else return name;
                }
                catch (Exception)
                {
                    throw new Exception("Invalid name");
                }
            }
            
        }


    }
}
