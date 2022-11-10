using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Hedgehog : Animal
    {

        bool SonicTheHedgehog;
        public Hedgehog() { }   
        public override void doSound()
        {
            Console.WriteLine("Funky mega drive bass");
        }

        public override string Stats()
        {
            return $"Hedgehog: {name} {age} {weight}";

        }
    }
}
