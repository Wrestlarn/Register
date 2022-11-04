using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf.Besökare
{
    internal class Kund
    {

        private AgeSpan priskategori;
        private int cost;

        public Kund(AgeSpan priskategori) {
          
            this.priskategori = priskategori;
            
            if (priskategori == AgeSpan.Ungdom)
            {
                
                this.cost = 80;
            }

            if(this.priskategori == AgeSpan.Vuxen)
            {
                this.cost = 120;
            }

            if(this.priskategori == AgeSpan.Pensionär)
            {
                this.cost = 90;
            }

            if(this.priskategori == AgeSpan.Barn)
            {
                this.cost = 0;
            }

            if(this.priskategori == AgeSpan.Gamling)
            {
                this.cost = 0;
            }

            

            }

        
        public int getCost()
        {
            return this.cost;
        }

        public AgeSpan getMyspan()
        {
            return this.priskategori;
        }


    }

    public enum AgeSpan
    {
                Barn,
                Ungdom,
                Vuxen,
                Pensionär,
                Gamling
    }

   


}
