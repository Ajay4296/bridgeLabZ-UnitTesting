using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    /// <summary>
    /// factory class for MoodAnalyser object creation
    /// </summary>
    public class MoodAnalyserFactory
    {
        public static MoodAnalyser CreateMoodAnalyser()
        {
                 return new MoodAnalyser();
        }
        public static Object CreateObjectUsingReflaction()
        {
           
                Type t = Type.GetType("Analyser.MoodAnalyser");
                return t.FullName;
        }
    }
}
