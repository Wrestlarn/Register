using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Polymorfing
{
    internal class TextInputError : UserError
    {
        public override string UEmessage(string message)
        {

            if (!message.All(char.IsDigit))
            {
                return "You tried to use a textinput in a numeric only field. This fired an error";

            }
            else return message;
        }
    }
}
