using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace _12._21._2022
{
    internal class PriceIsZeroOrMinus:Exception
    {
        public PriceIsZeroOrMinus(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
