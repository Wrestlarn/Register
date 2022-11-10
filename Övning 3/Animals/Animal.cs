using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    public abstract class Animal
    {
        protected string name {get; set; }
        protected int age { get; set; }
        protected int weight { get; set; }

        public Animal() { }

        public abstract void doSound();

        public abstract string Stats();
        

       

    }
}
