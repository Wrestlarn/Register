using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Person
{
    public class Person
    {

        static public List<Person> myEmployees = new List<Person>();

        int age;
        int salary;
        string name;

        public Person(int age, int salary, string name)
        {
            this.age = age;
            this.salary = salary;
            this.name = name;
        }


        public static void createNewEmployee()
        {
            String name = "";
            int age = 0;
            int salary = 0;


            try
            {
                Console.WriteLine("Ange namnet för den anställda");

                name = Console.ReadLine();

                Console.WriteLine("Ange månadslönen för " + name);
                salary = int.Parse(Console.ReadLine());

                Console.WriteLine("Ange ålder för " + name);
                age = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("något gick fel, startar om!");
                createNewEmployee();
            }





            if (age > 0 && salary > 0 && !name.Equals(""))
            {
                Person p = new Person(age, salary, name);
                myEmployees.Add(p);
                Console.WriteLine("Employee saved");

            }
            else
            {
                Console.WriteLine("något gick fel");
                return;
            }



        }

        public static void listMyEmployees()
        {

            if (myEmployees.Count > 0)
            {
                foreach (Person p in myEmployees)
                {
                    Console.WriteLine($"Employee \n{p.name} \nAge: {p.age} \nSalary: {p.salary} \n=====================");
                }

            }
            else Console.WriteLine("listan är tom");


        }

        

    }
}
