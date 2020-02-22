using NUnit.Framework;
using Analyser;
namespace NUnitTestProject1
{
    public class Tests
    {
       
            [Test]
        public  void CheckSadMood_ShouldReturnSad()
        {
            MoodAnalyser obj = new MoodAnalyser();
            string expected = "Happy";
            Assert.AreEqual(expected, obj.analyseMood());
            
        }


        
        

   
     


    }
}
