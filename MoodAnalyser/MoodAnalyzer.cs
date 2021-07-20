using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyser;

namespace MoodAnalyzer
{
    // refactoring MoodAnalyze with parameterized constructure
    public class MoodAnalyze
    {
        //instance varriable
        string message;
        public MoodAnalyze()
        {

        }
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string message)
        {
            //handling exception using try and catch blocks
            try
            {
                message = message.ToLower();
                if (message.Equals(string.Empty))
                {
                    throw new CustomAnalyseException(CustomAnalyseException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");

                }
                if (message.Equals(null))
                {
                    throw new CustomAnalyseException(CustomAnalyseException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
                }
                if (message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }

            catch (NullReferenceException e)
            {
                return "happy";
            }

        }

    }
}