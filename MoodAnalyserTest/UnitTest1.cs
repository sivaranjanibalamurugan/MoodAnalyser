using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void ReturnHappyTest()
        {
            //assign
            string expected = "happy";
            string message = "I am in Happy Mood";

            //act
            string actual = new MoodAnalyze(message).AnalyseMood();
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ReturnSadTest()
        {
            //assign
            string expected = "sad";
            string message = "I am in Sad Mood";
            //act
            string actual = new MoodAnalyze(message).AnalyseMood();
            //assert
            Assert.AreEqual(expected, actual);

        }
        //mood should not be null
        [TestMethod]
        public void NULLReferenceTest()
        {
            //assign
            string expected = "happy";
            string message = null;
            //act
            string actual = new MoodAnalyze(message).AnalyseMood("happy");
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ReturnCustomException()
        {
            string expected = "Mood should not be empty";
            try
            {
                string message = "";
                //act
                string actual = new MoodAnalyze(message).AnalyseMood();
            }
            catch (CustomAnalyseException ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message);
            }

        }
        [TestMethod]
        public void ReturnMoodShoulNotBeNull()
        {
            string expected = "Mood should not be null";
            try
            {
                string message = null;
                //act
                string actual = new MoodAnalyze(message).AnalyseMood();
            }
            catch (CustomAnalyseException ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message);
            }

        }
        /// <summary>
        /// T.C=4.1 Returns the mood analyser object with reflection-> Equal
        /// </summary>
        [TestMethod]
        public void ReturnMoodAnalyserObjectWithReflection()
        {
            object expected = new MoodAnalyze();
            object actual = MoodAnalyseFactory.CreateObjectForMoodAnalyser("MoodAnalyzer.MoodAnalyze", "MoodAnalyze");
            expected.Equals(actual);
        }
       
        // Returns the mood analyser object with reflection1 -> class not found
        
        [TestMethod]
        public void ReturnMoodAnalyserObjectWithReflection1()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyseFactory.CreateObjectForMoodAnalyser("MoodAnalyzer.MoodAnalyzer", "MoodAnalyzer");
            }
            catch (CustomAnalyseException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
       
        //Returns the mood analyser object with reflection1 -> constructor not found
        
        [TestMethod]
        public void ReturnMoodAnalyserObjectWithReflection2()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyseFactory.CreateObjectForMoodAnalyser("MoodAnalyzer.MoodAnalyze", "MoodAnalyzer");
            }
            catch (CustomAnalyseException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }


    }
}