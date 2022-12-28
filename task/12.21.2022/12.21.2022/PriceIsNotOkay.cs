using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace _12._21._2022
{
    internal class PriceIsNotOkay:Exception
    {
        public PriceIsNotOkay(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
