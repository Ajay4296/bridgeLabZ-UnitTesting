using NUnit.Framework;
using Analyser;
using System.Reflection;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {

        /// <summary>
        /// test cas
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
        /// 
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
       [Test]
        public void AnalyseMood_WhenSadMoodShouldReturnsad()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in sad mood");
            string expected = "SAD";
            Assert.AreEqual(expected, obj.AnalyseMood());

        }

        /// <summary>
        /// Test_Case_4.2
        /// Reflections the test.
        /// </summary>
        [Test]
        public void ReflectionTest()
        {
            string classname = "Analyser.MoodAnalyser";                
            MoodAnalyser MoodObject = MoodAnalyserFactory.CreateMoodAnalyser();
            Type type = MoodAnalyserFactory.CreateObjectUsingReflaction(classname);
            bool actual = MoodObject.Equals(type);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void ReflectionTestUsingConstructer()
        {
            string classname = "Analyser.MoodAnalyser";
            MoodAnalyser MoodObject = MoodAnalyserFactory.CreateMoodAnalyser("happyhours");
            Type type = MoodAnalyserFactory.CreateObjectUsingReflaction(classname);
            bool actual = MoodObject.Equals(type);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }

    }
}
