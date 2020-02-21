using NUnit.Framework;
using Analyser;
namespace NUnitTestProject1
{
    public class Tests
    {
       
            [Test]
        public  void CheckSadMood_ShouldReturnSad()
        {
            string str = "I am in sad mood";
            string expected = "sad";

            string actual = MoodAnalyser.CheckSadMood(str);

            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Checks the happy mood should return happy.
        /// </summary>
        [Test]
        public void CheckHappyMood_ShouldReturnHappy()
        {

            string str1 = "I am in happy mood";
            string expected1 = "happy";

            string actual1 = MoodAnalyser.CheckHappyMood(str1);

            Assert.AreEqual(actual1, expected1);

        }

    }
}
