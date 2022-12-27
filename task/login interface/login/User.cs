using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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
                if (IsUserNameIsOk(value))
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
            UserName = userName;
        }

        public bool IsPasswordOk(string input)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (HasUpper(input) && HasLower(input) && HasDigit(input))
                        return true;
                    else
                        return false;
                }

                throw new NullOrWhiteSpaceException("\nPassword bosluq veya teyin olunmamis ola bilmez!\n");
            }

            catch (NullOrWhiteSpaceException)
            {
                return false;
            }
        }

        public bool HasDigit(string input)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                        return true;
                }

                throw new HasNotDigitException("\nMinimum 1 reqem herf daxil edin!\n");
            }

            catch (HasNotDigitException)
            {
                return false;
            }
        }

        public bool HasUpper(string input)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsUpper(input[i]))
                        return true;
                }
                throw new HasNotUpperException("\nMinimum bir boyuk herf daxil edilmelidir!\n");
            }

            catch (HasNotUpperException)
            {
                return false;
            }
        }

        public bool HasLower(string input)
        {
            {
                try
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (char.IsLower(input[i]))
                            return true;
                    }
                    throw new HasNotLowerException("\nMinimum bir kicik herf daxil edilmelidir!\n");
                }

                catch (HasNotLowerException)
                {
                    return false;
                }
            }
        }

        public bool IsPasswordLengthIsOkay(string input)
        {
            try
            {
                if (input.Length >= 8 && input.Length <= 25)
                    return true;

                else
                    throw new PasswordLengthException("\nPasswordun uzulnugu minimum 8, maks 25 olmalidir\n");
            }
            catch (PasswordLengthException)
            {
                return false;
            }
        }

        public bool IsUserNameIsOk(string input)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(input))
                {
                    try
                    {
                        if (input.Length >= 6 && input.Length <= 25)
                            return true;

                        else
                            throw new UserNameLengthException("\nUsername'in uzunlugu minimum 6, maks 25 olmalidir\n");
                    }

                    catch (UserNameLengthException)
                    {
                        return false;
                    }
                }

                throw new NullOrWhiteSpaceException("\nPassword bosluq veya teyin olunmamis ola bilmez!\n");
            }
            catch (NullOrWhiteSpaceException)
            {
                return false;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"\nUsername: {UserName} -  Yaranma tarixi: {Time}");
        }

        private string _user_name;
        private string _password;
        public DateTime Time = DateTime.Now;
    }
}





