using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Övning_3.Person
{
    internal class Person
    {
        private string firstName, lastName;
        private int age, height, weight;

        public Person(string firstName, string lastName, int age, int height, int weight)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
        
        public void setFirstName(string firstName)
        {
            
            try
            {
                firstName.Trim();

                if (!firstName.Any(char.IsWhiteSpace) && firstName.Length > 2 && firstName.Length <= 10)
                {
                    this.firstName = firstName;
                    return;
                } else throw new ArgumentException();
                
            }catch(ArgumentException)
            {
                Console.WriteLine("Ogitligt namn");
            }


        }

        public void setLastName(string lastName)
        {

            try
            {
                if (lastName.Any(char.IsWhiteSpace) || lastName.Length < 2 || lastName.Length > 10)
                {
                    throw new ArgumentException();
                }
                else this.lastName = lastName;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ogitligt namn");
            }
           
        }

        public void setAge(int age)
        {
            try
            {
                if (age < 0) throw new ArgumentException();
                else this.age = age;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("no negative numbers");
            }
        }

        public void setHeight(int height)
        {
            try
            {
                if (height < 0) throw new ArgumentException();
                else this.height = height;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("no negative numbers");
            }


        }
        
        public void setWeight(int weight)
        {

            try
            {
                if (weight < 0) throw new ArgumentException();
                else this.weight = weight;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("no negative numbers");
            }


        }

        public string getName()
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public int getAge()
        {
            return this.age;
        }
        public int getHeight()
        {
            return  this.height;
        }
        public int getWeight()
        {
            return this.weight;    
        }
        

        internal static class PersonHandler
        {
            public static void SetAge(Person pers, int age)
            {
                pers.setAge(age);
              
            }

            public static void setHeight(Person pers, int height)
            {
                if(height < 0)
                {
                    return;
                }else pers.setHeight(height); 
            }

            public static void setWeight(Person pers, int weight)
            {
                if (weight < 0)
                {
                    return;
                }
                else pers.setWeight(weight);
            }

            public static void setFirstName(Person pers, string name)
            {
                pers.setFirstName(name);
            }


            public static Person createPersonObject(string fname, string lname,int age,
                                                   int height, int weight)
            {
                Person p = new(fname,lname, age, height, weight);
                return p;
            }

            }


        }


    }

