using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    class MoodAnalyseFactory
    {
        public static object CreateObjectForMoodAnalyser(string className, string constructorName)
        {
            //create the pattern and checks whether constructor name and class name are equal
            string pattern = @"." + constructorName + "";
            Match result = Regex.Match(className, pattern);
            //if yes create the object
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                //if no class found then then throw class not found exception
                catch (ArgumentNullException)
                {
                    throw new CustomAnalyseException(CustomAnalyseException.ExceptionType.CLASS_NOT_FOUND, "Class not found");
                }
            }
            //if constructor name not equal to class name then throw constructor not found exception
            else
            {
                throw new CustomAnalyseException(CustomAnalyseException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor not found");
            }

        }
    }
}
