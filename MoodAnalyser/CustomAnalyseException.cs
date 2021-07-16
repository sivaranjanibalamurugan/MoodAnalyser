using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    class CustomAnalyseException :Exception
    {
        //create instance of custom exception type
        ExceptionType type;
        //enum for defining constants
        public enum ExceptionType
        {
            NULL_EXCEPTION,EMPTY_EXCEPTION
        }
        //parameterized constructor and also using base() method
        public CustomAnalyseException(ExceptionType type, string message): base(message)
        {
            this.type = type;
        }
    }
}
