using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsernameValidationException;

namespace UserApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user =null;
            try
            {
                user = new User();
                string username = "abcd";
                string status = "NotValid";
                user.validateUser(username,out status);

                if(status == "NotValid")
                {
                    throw new ValidateUserName("User name must be only a-z characters");
                }
                else
                {
                    Console.WriteLine("User is :{0}",status);
                }

            }
            catch(ValidateUserName vu) {
                Console.WriteLine(vu.Message1);
            }
            finally {
                //
                user = null;
            }

            if (user != null)
            {
                Console.WriteLine(user.ToString());
            }

            Console.ReadKey();  
        }
    }
}
