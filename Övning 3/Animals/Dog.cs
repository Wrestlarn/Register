using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Dog : Animal
    {
        bool likesGoingOutinRain;

        public Dog() { }

        public override void doSound()
        {
            Console.WriteLine("Woff woff");
        }

        public override string Stats()
        {
            return $"Dog: {name} {age} {weight}";
        }

        public string testMyStringInLoop()
        {
            return "I like dogs";
        }

    }
}
