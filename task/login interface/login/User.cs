using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace login
{
    internal class User
    {
        public string UserName
        {
            get => _user_name;

            set
            {
                if (IsUserNameOrPasswordOk(value) && LengthIsOkay(value))
                    _user_name = value;
            }
        }

        public string Password
        {
            get => _password;

            set
            {
                if (IsUserNameOrPasswordOk(value) && LengthIsOkay(value))
                    _password = value;
            }
        }

        public User(string userName)
        {
        }

        public bool IsUserNameOrPasswordOk(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (HasDigit(input) && HasUpper(input) && HasLower(input))
                    return true;
            }
                return false;
        }

        public bool HasDigit(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                    return true;
            }
            Console.WriteLine("\nMinimum bir reqem daxil edin");

            return false;
        }

        public bool HasUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                    return true;
            }
            Console.WriteLine("\nMinimum 1 boyuk herf daxil edin");

            return false;
        }

        public bool HasLower(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                    return true;
            }
            Console.WriteLine("\nMinimum 1 kicik herf daxil edin");

            return false;
        }

        public bool LengthIsOkay(string input)
        {
            if ((input.Length >= 6 || input.Length >= 8) && input.Length <= 25)
                return true;

            Console.WriteLine("\nUsernamein uzunlugu 6 dan boyuk, parolun uzunlugu 8 den boyuk  25 den kicik olmalidir");

            return false;
        }

        private string _user_name;
        private string _password;
        public DateTime Time = DateTime.Now;
    }
}




