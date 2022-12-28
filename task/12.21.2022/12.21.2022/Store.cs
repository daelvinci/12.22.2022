using _12._21._2022;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;

namespace _12._21._2022
{
    internal class Store
    {
        public Notebook[] notebooks = { };
        public string Name;

        public void AddNotebook(Notebook notbuk)
        {
            Array.Resize(ref notebooks, notebooks.Length + 1);
            notebooks[notebooks.Length - 1] = notbuk;
        }

        public Notebook[] SearchNotebooks()
        {
            string search;
            Notebook[] wantedNotebooks = { };
            
            do
            {
                Console.Write("\nAxtaris etmek istediyiniz notebookun adini daxil edin: ");
                search = Console.ReadLine();

            } while (!StringIsOkay(search));

            search.ToLower();

            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Name.ToLower().Contains(search))
                {
                    Array.Resize(ref wantedNotebooks, wantedNotebooks.Length + 1);
                    wantedNotebooks[wantedNotebooks.Length - 1] = notebooks[i];
                }
            }
            return wantedNotebooks;
        }

        public void ShowNotebooks(Notebook[] notbukArr)
        {
            for (int i = 0; i < notbukArr.Length; i++)
            {
                GetInfo(notbukArr[i]);
            }
        }
        public void GetInfo(Notebook notebook)
        {
            Console.WriteLine($"\nNotbukun adi: {notebook.Name} - Notbukun qiymeti: {notebook.Price} - Notbukun rami: {notebook.Ram}\n");
        }

        public void CreateNotebook()
        {
            bool priceExcp;
            bool ramExcp;
            string ad;
            int qiymet = 0;
            int ram = 0;

            do
            {
                Console.Write("\nNotebookun adini daxil edin: ");
                ad = Console.ReadLine();

            } while (!StringIsOkay(ad));

            do
            {
                priceExcp = false;

                try
                {
                    Console.Write("\nNotebookun qiymetini daxil edin: ");

                    qiymet = int.Parse(Console.ReadLine());

                    if (qiymet <= 0)
                    {
                        priceExcp = true;
                        throw new PriceIsNotOkay("\nQiymet menfi ve ya sifir ola bilmez!\n");

                    }
                }

                catch (System.FormatException e)
                {
                    priceExcp = true;
                    Console.WriteLine(e.Message, "\n");
                }

                catch (PriceIsNotOkay)
                {
                    priceExcp = true;
                }

            } while (priceExcp == true);

            do
            {
                ramExcp = false;
                try
                {
                    Console.Write("\nNotebookun ramini daxil edin: ");
                    ram = int.Parse(Console.ReadLine());

                    if (ram > 128 || ram <= 0)
                    {
                        ramExcp = true;
                        throw new PriceIsZeroOrMinus("\nRam 0/menfi ve ya 128 den boyuk ola bilmez!\n");
                    }
                }
                catch (System.FormatException e)
                {
                    ramExcp = true;
                    Console.WriteLine(e.Message, "\n");
                }
                catch (PriceIsZeroOrMinus)
                {
                    ramExcp = true;
                }

            } while (ramExcp == true);

            AddNotebook(new Notebook(ad, qiymet, ram));
        }

        public bool StringIsOkay(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("\nYalniz herf ve reqemlerden istifade oluna biler!\n");
                return false;
            }

            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLetterOrDigit(str[i]))
                        continue;

                    else
                    {
                        Console.WriteLine("\nYalniz herf ve reqemlerden istifade oluna biler!\n");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
//Store class
// -Notebooks array
//- Name
// - AddNotebook() - parametr olaraq 1 notebook obyekti qəbul edib notebook array-ə əlavə edən metod
// - SearchNotebooks() -parametr olaraq string qəbul edib adinda həmin string olan notebooklari yeni bir  arrayde qaytaran metod
// - ShowNotebooks() -Butun notebookların infolarını console-da göstərən metod
