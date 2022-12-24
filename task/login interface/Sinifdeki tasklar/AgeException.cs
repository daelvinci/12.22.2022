using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdeki_tasklar
{
    internal class AgeException:Exception
    {
        
        public AgeException()
        {
            Console.WriteLine("Yas 18-den kicik ola bilmez!"); 
        }
    }
}
