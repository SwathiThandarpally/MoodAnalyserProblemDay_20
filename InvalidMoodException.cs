using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20MoodAnalyser
{
    public class InvalidMoodException:Exception 
    {
        public InvalidMoodException(string message) : base(message)
        {
            message = string.Empty;
            
        }
    }
}
