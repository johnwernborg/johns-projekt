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
            
        }

        public LogInRepetitionException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
