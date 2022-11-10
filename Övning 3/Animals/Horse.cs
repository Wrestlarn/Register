using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Horse : Animal
    {
        private string color;
        public override void doSound()
        {
            Console.WriteLine("what do i sound like?");
        }

        public override string Stats()
        {
            return $"Horse: {name} {age} {weight}";
        }
    }
}
