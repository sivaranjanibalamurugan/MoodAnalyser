using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyze moodAnalyzer;
        string message = "I am in happy mood";
        [TestInitialize]
        public void Setup()
        {
            moodAnalyzer = new MoodAnalyze(message);
        }

        [TestMethod]
        public void ReturnHappyTest()
        {
            //assign
            string expected = "happy";

            //act
            string actual = moodAnalyzer.AnalyseMood(message);
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ReturnSadTest()
        {
            //assign
            string expected = "sad";
            //act
            string actual = moodAnalyzer.AnalyseMood("I am in Sad mood");
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}