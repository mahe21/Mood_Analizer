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
            if(this.message.Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
        }
    }
}
