using System;

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
                Console.WriteLine("1. User elave et ");
                Console.WriteLine("2. Userlara bax");
                Console.WriteLine("3. Userlar üzre axtarıs et");
                Console.WriteLine("4. Menudan cix");
                Console.WriteLine("");
                numStr = Console.ReadLine();

                if (numStr == "1")
                {
                    InsertUser(ref userArr, CreateUser());
                }

                else if (numStr == "2")
                {
                    ShowUsers(userArr);
                }

                else if (numStr == "3")
                {
                    Console.Write("Axtaris etmek istediyiniz deyeri daxil edin!");
                    search = Console.ReadLine();
                    ShowSearch(userArr, search);
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
            User usr = new User(null);

            do
            {
                Console.Write("Userin adini daxil edin: ");
                usr.UserName = (Console.ReadLine());
                Console.WriteLine("");

            } while (usr.UserName == null);

            do
            {
                Console.Write("Userin parolunu daxil edin: ");
                usr.Password = Console.ReadLine();
                Console.WriteLine("");

            } while (usr.Password == null);

            return usr;
        }
        static void ShowUsers(User[] userArr)
        {
            for (int i = 0; i < userArr.Length; i++)
            {
                Console.WriteLine($"Username: {userArr[i].UserName} -  Yaranma tarixi: {userArr[i].Time}");
            }
        }
        static void ShowSearch(User[] userArr, string search)
        {
            for (int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i].UserName.ToLower().Contains(search.ToLower()))
                {
                    Console.WriteLine($"Username: {userArr[i].UserName} -  Yaranma tarixi: {userArr[i].Time}");
                }
            }
        }

    }
}


