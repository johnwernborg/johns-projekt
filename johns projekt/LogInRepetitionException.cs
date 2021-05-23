using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    public class LogInRepetitionException : Exception
    {
        public LogInRepetitionException()
        {

        }

        public LogInRepetitionException(string message)
            : base (message)
        {
            message = "It seems like you're trying to hack into someones account";
        }

        public LogInRepetitionException(string message, Exception inner)
            : base(message, inner)
        {
            message = "It seems like you're trying to hack into someones account";
        }
    }
}
