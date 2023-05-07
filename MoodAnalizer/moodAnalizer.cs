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
                if (this.message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }

            }
            catch
            {
                return "happy";

            }
            
        }
    }
}
