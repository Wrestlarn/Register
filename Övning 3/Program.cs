using Övning_3.Animals;
using Övning_3.Interface;
using Övning_3.Person;
using Övning_3.Polymorfing;

namespace Övning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person.Person p = Person.Person.PersonHandler.createPersonObject("Kalle", "Alfred", 22, 166, 75);

            Console.WriteLine(p.getAge());

            Person.Person.PersonHandler.SetAge(p, 300);
            Console.WriteLine(p.getAge());

            Person.Person.PersonHandler.setFirstName(p, "K");
            Console.WriteLine(p.getName());
            Person.Person.PersonHandler.SetAge(p,-5);
           


            List<UserError> errors = new();
            TextInputError textError = new();
            UserError numberError = new NumericInputError();
            UserError whiteSpaceError = new WhiteSpaceError();
            UserError textLengthError = new TextLengthError();
            UserError upperCaseError = new UpperCaseError();

            Console.WriteLine(numberError.UEmessage("23kt34"));
            Console.WriteLine(numberError.UEmessage("Mjau"));
            Console.WriteLine(textError.UEmessage("Kall33"));
            Console.WriteLine(textError.UEmessage("124213"));
            Console.WriteLine(whiteSpaceError.UEmessage("Hej mjau"));
            Console.WriteLine(whiteSpaceError.UEmessage("Hejmjau"));
            Console.WriteLine(textLengthError.UEmessage("hej"));
            Console.WriteLine(textLengthError.UEmessage("hejhh"));
            Console.WriteLine(upperCaseError.UEmessage("ffDf"));
            Console.WriteLine(upperCaseError.UEmessage("HELLO"));

            
            

            Animal birdy = new Bird();
            Animal dog = new Dog();
            Animal horse = new Horse();
            Animal hedgehog = new Hedgehog();
            Animal dog1 = new Dog();
            Animal dog2 = new Dog();
            Animal worm = new Worm();
            Animal wolf = new Wolf();
            Animal MJ = new Wolfman();

            List<Animal> djurlista = new();
            djurlista.Add(birdy);
            djurlista.Add(dog);
            djurlista.Add(horse);
            djurlista.Add(hedgehog);
            djurlista.Add(worm);
            djurlista.Add(wolf);
            djurlista.Add(MJ);
            djurlista.Add(dog1);
            djurlista.Add(dog2);

            foreach(Animal djur in djurlista)
            {
                if(djur is IPerson)
                {
                    ((IPerson)djur).Talk();
                    
                }

                djur.doSound();
                Console.WriteLine(djur.Stats());
            }

            foreach(Animal dogs in djurlista)
            {
               if(dogs is Dog)
                {
                    
                    Console.WriteLine(((Dog)dogs).testMyStringInLoop());
                    
                }
            }
            



            // 9 : Listan tar emot typen Dog
            // 10: Listan måste lagra typen Animal
            // 13 : I Bird klassen
            // 14 : I animal klassen
            // 17 : Variabeln i forloopen är en referens av typen animal och måste castas till dog 


        }
    }
}