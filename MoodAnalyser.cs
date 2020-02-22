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
      


            public  string analyseMood()
            {
            try
            {
                if (msg.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                    return "Happy";
            }
            catch(NullReferenceException ne)
            {
                return "Happy";
                throw new NullReferenceException("happy mind");

            }
                    
            }



        }
    }

