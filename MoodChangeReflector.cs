using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20MoodAnalyser
{
    public class MoodChangeReflector
    {
        public MoodChangeReflector()
        {
        }

        public MoodChangeReflector(string Happy)
        {
            if(Happy == null)
            {
                try
                {
                    Console.WriteLine("Happy");
                }
                catch
                {
                    Console.WriteLine("Sad");
                }
            }
          

        }
    }
}
