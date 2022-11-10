using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Worm : Animal
    {
        bool earthWorm;
        public Worm() { }

        public override void doSound()
        {
            Console.WriteLine("Crawling in the dark, nothing to see here!");
        }

        public override string Stats()
        {
            return $"Worm: {name} {age} {weight}";
        }
    }
}
