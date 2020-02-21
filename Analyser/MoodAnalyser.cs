using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    public  class MoodAnalyser
    {
        public static string CheckSadMood(string str)
        {
            if (str.ToLower().Contains("sad"))
            {
                return "sad";
            }
            else
                return "Happy";
        }

        public static string CheckHappyMood(string str1)
        {
            if (str1.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
                return "sad";
        }



    }
}
