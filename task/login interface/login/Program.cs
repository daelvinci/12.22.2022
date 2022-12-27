using System;
using System.Diagnostics;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string search;
            string numStr;
            User[] userArr = new User[0];

            do
            {
                Console.WriteLine("\nYalniz 1; 2; 3; 4; reqemleri daxil oluna biler\n");
                Console.WriteLine("\n1. User elave et\n ");
                Console.WriteLine("\n2. Userlara bax\n");
                Console.WriteLine("\n3. Userlar üzre axtarıs et\n");
                Console.WriteLine("\n4. Menudan cix\n");
                numStr = Console.ReadLine();

                if (numStr == "1")
                    InsertUser(ref userArr, CreateUser());

                else if (numStr == "2")
                    ShowUsers(userArr);

                else if (numStr == "3")
                {
                    if (userArr.Length != 0)
                    {
                        Console.Write("\nAxtaris etmek istediyiniz deyeri daxil edin:  ");
                        search = Console.ReadLine();
                        ShowSearch(userArr, search);

                    }
                    else
                        Console.WriteLine("\nHal hazirda movcud bir user yoxdur");
                }
            } while (numStr != "4");
        }

        static User[] InsertUser(ref User[] userArr, User user)
        {
            Array.Resize(ref userArr, userArr.Length + 1);
            userArr[userArr.Length - 1] = user;

            return userArr;
        }

        static User CreateUser()
        {
            User usr = new User("000000");
            do
            {
                Console.Write("\nUsername daxil edin: \n");
                usr.UserName = Console.ReadLine();

            } while (usr.UserName == null);

            do
            {
                Console.Write("\nParolu daxil edin: \n");
                usr.Password = Console.ReadLine();

            } while (usr.Password == null);

            return usr;
        }

        static void ShowUsers(User[] userArr)
        {
            if (userArr.Length != 0)
            {
                for (int i = 0; i < userArr.Length; i++)
                {
                    userArr[i].GetInfo();
                }                
            }
            else
                Console.WriteLine("\nHal hazirda movcud bir yoxdur");
        }

        static void ShowSearch(User[] userArr, string search)
        {
            bool hasUser = false;
            search = search.ToLower();

            for (int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i].UserName.ToLower().Contains(search))
                {
                    hasUser = true;
                    userArr[i].GetInfo();
                }
            }

            if (!hasUser)
                Console.WriteLine("\nAxtariginiz user tapilmadi!");
        }
    }
}


