using NUnit.Framework;
using Analyser;
namespace NUnitTestProject1
{
    public class Tests
    {

        /// <summary>
        /// Analyses the mood when null value.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenNullValue()
        {
            MoodAnalyser obj = new MoodAnalyser(null);
            string expected2="HAPPY";
            Assert.AreEqual(expected2,obj.AnalyseMood());

        }


        /// <summary>
        /// Analyses the mood when empty value.
        /// </summary>
        [Test]
        public  void AnalyseMood_when_empty_value()
        {
            MoodAnalyser obj = new MoodAnalyser(" ");
            string expected1= "HAPPY";
            Assert.AreEqual(expected1,obj.AnalyseMood());
            
        }

        /// <summary>
        /// Analyses the mood when sad mood should returnsad.
        /// </summary>
/        [Test]
        public void AnalyseMood_WhenSadMoodShouldReturnsad()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in sad mood");
            string expected = "SAD";
            Assert.AreEqual(expected, obj.AnalyseMood());

        }
        /// <summary>
        /// Reflections the test.
        /// </summary>
        [Test]
        /public void ReflectionTest()
        {
            MoodAnalyser MoodObject = MoodAnalyserFactory.CreateMoodAnalyser();
            object obj = MoodAnalyser.CreateMoodAnalyserUsingReflection("Analyser.MoodAnalyser");
            bool actual = MoodObject.Equals(obj);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }






    }
}
