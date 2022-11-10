using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Övning_3.Animals
{
    internal class Bird : Animal
    {
        public Bird() { }   
        public override void doSound()
        {
            Console.WriteLine("Tweet tweetilidoo");
        }

        public override string Stats()
        {
            return $"Bird: {name} {age} {weight}";
        }

      


    }
}
