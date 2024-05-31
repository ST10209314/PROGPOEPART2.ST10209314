using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROGPOEPART2.ST10209314.Util;


namespace PROGPOEPART2.ST10209314.Exception


{

    // This class handles exceptions and errors related to the  input
    public class ExceptionHandler
    {
        // This method handles errors related to string input
        public static void HandleStringInputError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Constants.STRING_INPUT_ERROR_MESSAGE);
            Console.ForegroundColor = ConsoleColor.White;
        }

        // This method handles errors related to integer input
        public static void HandleIntegerInputError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Constants.INTEGER_INPUT_ERROR_MESSAGE);
            Console.ForegroundColor = ConsoleColor.White;
        }


        //This method handles errors related to double input
        public static void HandleDoubleInputError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Constants.DOUBLE_INPUT_ERROR_MESSAGE);
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}

