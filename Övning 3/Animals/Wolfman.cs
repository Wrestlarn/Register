using Övning_3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
     public class Wolfman : Wolf, IPerson
    {

        public Wolfman() { }  

        

        public void Talk()
        {
            Console.WriteLine("Thriller night");
        }

        public override void doSound()
        {
            
        }

        public override string Stats()
        {
            return $"Wolfman: {name} {age} {weight}";
        }


    }


}
