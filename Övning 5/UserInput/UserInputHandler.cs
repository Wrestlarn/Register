using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.UserInput
{
    internal static class UserInputHandler
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
            string n = "";
            while (true)
            {
                Console.WriteLine("Ange text");
                n = Console.ReadLine();

                if (!string.IsNullOrEmpty(n))
                {
                    return n;
                }
            }
            }

    }
 }

    

