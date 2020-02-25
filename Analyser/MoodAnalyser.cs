using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Analyser
{
    /// <summary>
    ///  This is MoodAnalyser class 
    /// </summary>
    public class MoodAnalyser
    {
        public static string msg;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyser"/> class.
        /// </summary>
        public MoodAnalyser()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyser"/> class.
        /// </summary>
        /// <param name="msg1">The MSG1.</param>
        public MoodAnalyser(string msg1)
        {
            msg = msg1;
        }

        /// <summary>
        /// Analyses the mood.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MoodAnalysisException">
        /// present Exception is:-" + Exception_type.Null_Exception
        /// or
        /// present Exception is:-" + Exception_type.Empty_Exception
        /// </exception>
        public string AnalyseMood()
        {
            try
            {
                if (msg == null)
                {
                    Console.WriteLine("value is null");
                    throw new MoodAnalysisException("present Exception is:-" + Exception_type.Null_Exception);

                }
                if (msg.Length==0)
                {
                    Console.WriteLine("value is empty");
                    throw new MoodAnalysisException( "present Exception is:-" + Exception_type.Empty_Exception);
                    

                }
                if (msg.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                
            }
            catch (MoodAnalysisException me)
            {

                return "HAPPY";
            }
            return "HAPPY";
        }

        /// <summary>
        /// Creates the mood analyser using reflection.
        /// </summary>
        /// <returns></returns>
        public static Object CreateMoodAnalyserUsingReflection(string classname)
        {
            Type type = Type.GetType(classname);
            return type.FullName;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (this.GetType().ToString().Equals(obj))
                return true;
            return false;
        }

    }
}
   
     
