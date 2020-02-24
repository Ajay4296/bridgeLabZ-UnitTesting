using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    public enum Exception_type
    {
        Null_Exception,
        Empty_Exception,
        Invalid_exception,
    }
    public  class MoodAnalysisException: Exception
    {
        public MoodAnalysisException(string message) : base(message)
        {

        }
    }
}
