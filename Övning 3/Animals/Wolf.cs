using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
     public class Wolf : Animal
    {
        bool wereWolf;

        public Wolf() { }

        public override void doSound()
        {
            Console.WriteLine("Thriller ");
        }

        public override string Stats()
        {
            return $"Wolf: {name} {age} {weight}";
        }
    }
}
