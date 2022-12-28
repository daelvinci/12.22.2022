using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace _12._21._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num;
            Store Soliton = new Store();

            do
            {
                Console.WriteLine("\n1. Notebooklar uzerinde axtaris et\n");
                Console.WriteLine("\n2. Yeni Notebook yarat\n");
                Console.WriteLine("\n3. Butun notbuklari goster\n");
                Console.WriteLine("\n0. Menudan cix\n");
                num = Console.ReadLine();

                if (num == "1")
                   Soliton.ShowNotebooks(Soliton.SearchNotebooks());

                else if (num == "2")
                    Soliton.CreateNotebook();

                else if (num == "3")
                    Soliton.ShowNotebooks(Soliton.notebooks);

            } while (num != "0");
        }
    }
}
