using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdeki_tasklar
{
    internal class Employee : Human
    {
        public int Salary;
        private string _position;

        public string Position
        {
            get => _position;
            set
            {
                if (ContainsOnlyLetters(value))
                    _position = value;
                else
                    throw new FormatException();
            }
        }

        public int Age2
        {
            get => _age;
            set
            {
                if (value >= 18)
                {
                    _age = value;
                }
                else
                {
                    throw new AgeException();
                }
            }
        }

    }

}

