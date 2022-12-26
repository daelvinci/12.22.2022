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
                if (IsUsernameIsOk(value))
                    _user_name = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (IsPasswordOk(value) && IsPasswordLengthIsOkay(value))
                    _password = value;
            }
        }

        public User(string userName)
        {
        }

        public bool IsPasswordOk(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (HasUpper(input) && HasLower(input) && HasDigit(input))
                    return true;
            }

            else
                Console.WriteLine("\nPassword teyin olunmamis ve ya bosluq ola bilmez!");

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

        public bool IsPasswordLengthIsOkay(string input)
        {
            if (input.Length >= 8 && input.Length <= 25)
                return true;

            Console.WriteLine("\nParolun uzunlugu 8 den boyuk  25 den kicik olmalidir");

            return false;
        }

        public bool IsUsernameIsOk(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (input.Length >= 6 && input.Length <= 25)
                    return true;
                else
                    Console.WriteLine("\nUsername'in uzunlugu minimum 6, maksimum 25 ola biler!");

                return false;
            }

            Console.WriteLine("\n Username bosluq ve ya teyin olunmamis ola bilmez!");

            return false;
        }

        private string _user_name;
        private string _password;
        public DateTime Time = DateTime.Now;
    }
}




