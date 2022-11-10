using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Polymorfing
{
    internal class UpperCaseError : UserError

    {
        public override string UEmessage(string message)
        {
            if (!message.All(char.IsUpper))
            {
                return "Message is not in uppercase";
            }
            else return message;
        }
    }
}
