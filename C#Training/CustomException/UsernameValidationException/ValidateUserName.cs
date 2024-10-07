using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsernameValidationException
{
    //inherit class from base class ApplicationException
    public class ValidateUserName : ApplicationException
    {
        //step2 : declare private field of type string;
        string message;

        //step2 : define parameterised constructor
        public ValidateUserName(string msg)
        {
            message = msg;
                
        }

       //step 3: define real only property to read message
        public string Message1 { get => message; }
    }
}
