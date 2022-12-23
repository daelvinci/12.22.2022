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
                if (HasDigit(input) && HasUpper(input) && HasLower(input))
                    return true;

                else
                    return false;

            return true;
        }

        public bool HasDigit(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                    return true;
            }
            Console.WriteLine("Minimum bir reqem daxil edin ");

            return false;
        }

        public bool HasUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                    return true;
            }
            Console.WriteLine("Minimum 1 boyuk herf daxil edin");

            return false;
        }

        public bool HasLower(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                    return true;
            }
            Console.WriteLine("Minimum 1 kicik herf daxil edin: ");

            return false;
        }

        public bool LengthIsOkay(string input)
        {
            if ((input.Length >= 6 || input.Length >= 8) && input.Length <= 25)
                return true;

            Console.WriteLine("Usernamein uzunlugu 6 dan boyuk, parolun uzunlugu 8 den boyuk  25 den kicik olmalidir");

            return false;
        }

        private string _user_name;
        private string _password;
        public DateTime Time = DateTime.Now;
    }

    // Layihə işə düşdükdə aşağıdaki menu pəncərəsi görünür:
    //- 1. User əlavə et username arrayi yaranir ve ora elave edilir.
    //- 2. Userlara bax (username adina gore axtarilir ve username ve datetime cixir)
    //- 3. Userlar üzrə axtarış et

    //UserName dəyərinin uzunluğu minimum 6, maksimum 25 ola bilər. sertler odenilene kimi tekrar istemelidi
    // password Password dəyərinin uzunluğu minimum 8 , maksimum 25 ola bilər və içərisində mütlər ən az 1 böyük, 1 kiçik hərf və 1 rəqəm olmalıdır.sertler odenilene kimi tekrar istemelidi
    //Datetime

    //user name UserName dəyəri təyin olunmamış User obyekti yaradıla bilinməməlidir.
}//User class: -(- HasDigit - parametr olaraq string dəyər qəbul edib o dəyərdə rəqəm varsa geriyə true yoxdusa false qaytaran metod
 //- HasUpper -  parametr olaraq string dəyər qəbul edib o dəyərdə uppercase varsa geriyə true yoxdursa false qaytaran metod
 //- HasLower - parametr olaraq string dəyər qəbul edib o dəyərdə lowercase varsa geriyə true yoxdursa false qaytaran metod





