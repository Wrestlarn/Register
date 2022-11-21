using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4
{
    internal class Namnlista
    {
        static public List<string> namnlista = new();
        static public int listlength = namnlista.Count;
        static public int listCapacity = namnlista.Capacity;

    }
}
