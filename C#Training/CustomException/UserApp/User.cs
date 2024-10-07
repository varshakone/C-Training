using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp
{
    internal class User
    {

        public void validateUser(string username,out string status)
        {
            status = "NotValid";
            if (username != string.Empty)
            {
                //var result = int.TryParse(username, out var value);
                var result= username.ToCharArray();
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] >=97 && result[i] <= 122)
                    {
                        status = "Valid User";
                    }
                    else if (result[i] >= 65 && result[i] <= 90)
                    {
                        status = "Valid User";
                    }
                    else
                    {
                        status = "NotValid";
                    }
                }
                

            }
        }
    }
}
