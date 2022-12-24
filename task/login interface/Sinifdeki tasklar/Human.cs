using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdeki_tasklar
{
    internal class Human
    {
        private string _name;
        protected int _age;

        public string Name
        {
            get => _name;
            set
            {
                if (ContainsOnlyLetters(value))
                    _name = Name;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value > 0)
                    _age = value;

                else
                    throw new HumanAgeException();
            }
        }

        protected bool ContainsOnlyLetters(string ad)
        {
            if (!string.IsNullOrWhiteSpace(ad))
            {
                for (int i = 0; i < ad.Length; i++)
                {
                    if (!char.IsLetter(ad[i]))
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
