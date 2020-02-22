using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    public class MoodAnalyser
    {
        public string msg;
        public MoodAnalyser(string msg1)
        {
                this.msg = msg1;   
        }
       public MoodAnalyser()
        {

        }


            public  string analyseMood()
            {
                if (msg.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                    return "HAPPY";
            }



        }
    }

