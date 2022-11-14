using Biograf.Besökare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biograf.Besökarregister
{
    internal static class Register
    {
        private static List<Kund> kunder = new();


        public static void addCustomer(Kund k)
        {
            kunder.Add(k);
        }

       
        public static void registerNewCustomer()
        {
            uint? numberOfCustomers;

            while (true)
            {
                Console.WriteLine("Hur många i sällskapet?");
                try
                {
                    numberOfCustomers = uint.Parse(Console.ReadLine()!);
                    break;

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ange siffra");
                }
            }


            if(numberOfCustomers > 10)
            {
                return;
            }

            if (numberOfCustomers > 0)
            {
                registerVisit((uint)numberOfCustomers);
            }

        }


        public static void registerVisit(uint total)

        {
            int[] age = new int[total];
            for (int i = 0; i <age.Length;)
            {
                
                Console.WriteLine("Hej kund ange din ålder");

                try
                {
                    age[i] = int.Parse(Console.ReadLine()!);
                    i++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ange en siffra");

                    if (i == 0)
                    {
                        i = 0;
                    }
                    else --i;
                    
                }
            }

            registerCustomerFromAge(age);
        }
          
        public static void registerCustomerFromAge(int[] age)
        {
            for(int i = 0; i < age.Length; i++)
            {
                if (age[i] <= 5)
                {
                    Kund kund = new Kund(AgeSpan.Barn);
                    Console.WriteLine($"Denna kund är {kund.getMyspan()} och betalar {kund.getCost()}");
                    Register.addCustomer(kund);
                }

                if (age[i] > 5 && age[i] <= 20)
                {
                    Console.WriteLine("ungdom");
                    Kund kund = new Kund(AgeSpan.Ungdom);
                    Console.WriteLine($"Denna kund är {kund.getMyspan()} och betalar {kund.getCost()}");
                    Register.addCustomer(kund);
                }

                if (age[i] >20 && age[i] <= 64)
                {
                    Kund kund = new Kund(AgeSpan.Vuxen);
                    Console.WriteLine($"Denna kund är {kund.getMyspan()} och betalar {kund.getCost()}");
                    Register.addCustomer(kund);
                }

                if (age[i] > 64 && age[i] <= 100)
                {
                    Kund kund = new Kund(AgeSpan.Pensionär);
                    Console.WriteLine($"Denna kund är {kund.getMyspan()} och betalar {kund.getCost()}");
                    Register.addCustomer(kund);
                }

                if (age[i] > 100)
                {
                    Kund kund = new Kund(AgeSpan.Gamling);
                    Console.WriteLine($"Denna kund är {kund.getMyspan()} och betalar {kund.getCost()}");
                    Register.addCustomer(kund);
                }

               

            }
        }




        public static void checkCoutAndPrice()
        {
            int sum = 0;
            foreach (Kund k in kunder)
            {
                sum += k.getCost();
            }
            Console.WriteLine("Kostnaden för sällskapet blir " + sum);
           
        }
    }

}

    

