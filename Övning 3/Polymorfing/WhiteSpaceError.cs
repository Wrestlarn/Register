using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Polymorfing
{
    internal class WhiteSpaceError : UserError
    {
        public override string UEmessage(string message)
        {
            if (message.Any(char.IsWhiteSpace))
            {
                return "Message contains whitespace";
            }else return message;

        }
    }
}
