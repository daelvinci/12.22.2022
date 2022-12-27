using System;
using System.Collections.Generic;
using System.Text;

namespace login
{
    internal class UserNameLengthException:Exception
    {
        public UserNameLengthException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
