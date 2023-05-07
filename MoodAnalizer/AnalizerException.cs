using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalizer
{
    public class AnalizerException : Exception
    {
        public enum ExceptionType
        {
            Null_Message, Empty_Message,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_NOT_FOUND
        }

        private readonly ExceptionType type;

        public AnalizerException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
