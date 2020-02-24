using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    public class MoodAnalyser
    {
        public static string msg;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string msg1)
        {
            msg = msg1;
        }

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

    }
}
   
     
