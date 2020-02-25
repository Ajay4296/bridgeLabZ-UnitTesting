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
        public static Type CreateObjectUsingReflaction(string classname)
        {
            try
            {
                Type t = Type.GetType(classname);
                if (t == null)
                    throw new MoodAnalysisException("the exception present is :-" + Exception_type.No_such_Class_Exception);
                return t;
            }
            catch(MoodAnalysisException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
