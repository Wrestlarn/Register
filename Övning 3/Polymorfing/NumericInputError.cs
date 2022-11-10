using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Polymorfing
{
    internal class NumericInputError : UserError
    {
      

        public override string UEmessage(string message)
        {

            if (message.Any(char.IsDigit))
            {
                return "You tried to use a numeric input in a text only field";

            }
            else return message;

        }
    }
}
