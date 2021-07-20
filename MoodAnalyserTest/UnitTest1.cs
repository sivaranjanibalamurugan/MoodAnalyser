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
        // Returns the mood analyser object with reflection-> Equal
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
        
        // Returns the object with parameterized constructor.
      
        [TestMethod]
        public void ReturnObjectWithParameterizedConstructor()
        {
            object expected = new MoodAnalyze("I am happy");
            object actual = MoodAnalyseFactory.CreateObjectForMoodAnalyserParameterizedConstructor("MoodAnalyzer.MoodAnalyze", "MoodAnalyze", "I am happy");
            expected.Equals(actual);
        }
        
        // Returns the object with parameterized constructor-> Class Not found Exception
        
        [TestMethod]
        public void ReturnObjectWithParameterizedConstructor1()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyseFactory.CreateObjectForMoodAnalyserParameterizedConstructor("MoodAnalyzer.MoodAnalyzer", "MoodAnalyzer", "I am happy");
            }
            catch (CustomAnalyseException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        
        // Returns the object with parameterized constructor-> Constructor Not found Exception
        
        [TestMethod]
        public void ReturnObjectWithParameterizedConstructor2()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyseFactory.CreateObjectForMoodAnalyserParameterizedConstructor("MoodAnalyzer.MoodAnalyze", "MoodAnalyzer", "I am happy");
            }
            catch (CustomAnalyseException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        // Invokes the method using reflection->return happy
  
        [TestMethod]
        public void InvokeMethodUsingReflection()
        {
            string expected = "Happy";
            string actual = MoodAnalyseFactory.InvokeMoodAnalyser("I am happy", "AnalyseMood");
            expected.Equals(actual);

        }
      
        // Invokes the method using reflection->return happy
    
        [TestMethod]
        public void InvokeMethodUsingReflection1()
        {
            string expected = "No method found";
            try
            {
                string actual = MoodAnalyseFactory.InvokeMoodAnalyser("I am happy", "AnalyserMood");
                expected.Equals(actual);
            }
            catch (CustomAnalyseException me)
            {
                Assert.AreEqual(expected, me.Message);
            }

        }
        //  Change the message dynamically using reflection.
        
        [TestMethod]
        public void ChangeMessageDynamicallyUsingReflection()
        {
            string expected = "Happy";
            string actual = MoodAnalyserFactory.SetFeild("Happy", "message");
            expected.Equals(actual);
        }
      
        // Changes the message dynamically using reflection.
       
        [TestMethod]
        public void ChangeMessageDynamicallyUsingReflection1()
        {
            string expected = "Field is not found";
            try
            {
                string actual = MoodAnalyseFactory.SetFeild("Happy", "msg");
                expected.Equals(actual);
            }
            catch (CustomAnalyseException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
       
        // Changes the message dynamically using reflection.
       
        [TestMethod]
        public void ChangeMessageDynamicallyUsingReflection2()
        {
            string expected = "Message should not be null";
            try
            {
                string actual = MoodAnalyseFactory.SetFeild(null, "message");
                expected.Equals(actual);
            }
            catch (CustomAnalyseException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}