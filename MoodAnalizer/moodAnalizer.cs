using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalizer
{
    public class moodAnalizer
    {
        private string message;

        public moodAnalizer(string message)
        {
            this.message = message;
        }

        public string AnalizeMood()
        {
            try
            {
                if(this.message.Equals(string.Empty))
                {
                    throw new AnalizerException(AnalizerException.ExceptionType.Empty_Message, "message must not be empty");
                }
                if(this.message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch(NullReferenceException)
            {
                throw new AnalizerException(AnalizerException.ExceptionType.Null_Message, "message should not be null");
            }
            
        }
    }
}
