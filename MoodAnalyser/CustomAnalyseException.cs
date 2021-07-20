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
            NULL_EXCEPTION,EMPTY_EXCEPTION, CLASS_NOT_FOUND, CONSTRUCTOR_NOT_FOUND,NO_METHOD_FOUND, NO_FEILD_EXIST
        }
        
        public CustomAnalyseException(ExceptionType type, string message): base(message)
        {
            this.type = type;
        }
    }
}
