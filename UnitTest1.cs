using NUnit.Framework;
using Analyser;
namespace NUnitTestProject1
{
    public class Tests
    {
       
            [Test]
        public  void CheckSadMood_ShouldReturnSad()
        {
            MoodAnalyser obj = new MoodAnalyser("i am in sad mood");
            string expected = "SAD";
            Assert.AreEqual(expected, obj.analyseMood());

        }


        /// <summary>
        /// Checks the happy mood should return happy.
        /// </summary>
        [Test]
        public void CheckHappyMood_ShouldReturnHappy()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in happy mood");
            string expected1 = "HAPPY";
            Assert.AreEqual(obj.analyseMood(), expected1);

        }

   
     


    }
}
