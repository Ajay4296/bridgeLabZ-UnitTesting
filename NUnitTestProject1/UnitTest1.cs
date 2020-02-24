using NUnit.Framework;
using Analyser;
namespace NUnitTestProject1
{
    public class Tests
    {

        [Test]
        public void AnalyseMood_WhenNullValue()
        {
            MoodAnalyser obj = new MoodAnalyser(null);
            string expected2="HAPPY";
            Assert.AreEqual(expected2,obj.AnalyseMood());

        }



        [Test]
        public  void AnalyseMood_when_empty_value()
        {
            MoodAnalyser obj = new MoodAnalyser(" ");
            string expected1= "HAPPY";
            Assert.AreEqual(expected1,obj.AnalyseMood());
            
        }

        [Test]
        public void AnalyseMood_WhenSadMoodShouldReturnsad()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in sad mood");
            string expected = "SAD";
            Assert.AreEqual(expected, obj.AnalyseMood());

        }







    }
}
