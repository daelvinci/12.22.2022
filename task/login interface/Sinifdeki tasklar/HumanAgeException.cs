using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdeki_tasklar
{
    internal class HumanAgeException:Exception
    {
        public HumanAgeException()
        {
            Console.WriteLine("Yas 0-dan kicik ola bilmez!");
        }
    }
}
