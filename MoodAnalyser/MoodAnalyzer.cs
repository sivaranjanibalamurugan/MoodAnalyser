using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyze
    {
        //instance varriable
        string message;
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string message)
        {
         
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}