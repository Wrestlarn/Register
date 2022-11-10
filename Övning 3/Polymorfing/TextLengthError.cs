using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Polymorfing
{
    internal class TextLengthError : UserError
    {
        public override string UEmessage(string message)
        {
            if (message.Length < 4)
            {
                return "message is too short";
            }
            else return message;
        }
    }
}
