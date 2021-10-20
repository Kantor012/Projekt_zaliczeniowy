using System.Collections.Generic;

namespace Projekt_zaliczeniowy.Class
{
    public class Urzadzenia : Data
    {
        protected static int id { get; set; }
        protected static int ilosc { get; set; }
        public List<string> rodzaj_urz = new List<string>();
        //var przedmioty = rodzaj_urz.ToArray();
        public Urzadzenia()
        {
            id = 1;
            ilosc = 0;
           // System.Console.WriteLine("Pojemność: ", rodzaj_urz.Capacity);
        }

        public void dodaj()
        {
            ilosc++;
            id++;
            
        }

        public void usun()
        {
            ilosc--;
        }

        public void sprawdz_ilosc()
        {
            /*foreach(string rodzaj in rodzaj_urz)
            {
                System.Console.WriteLine("\n"+rodzaj);
            }*/
            //System.Console.WriteLine("Ilosc urzadzen na liscie: " + rodzaj_urz.Count + "\n\n");
            string[] przedmioty = rodzaj_urz.ToArray();
            //System.Console.WriteLine("Ilosc urzadzen w tablicy: "+ przedmioty.Length + "\n\n");
            System.Console.Clear();
            System.Console.WriteLine("Ilosc wpisanych przedmiotow: " +ilosc+"\n");
            foreach(string a in przedmioty)
            {
                System.Console.WriteLine(a);
            }
            
        }

        public void znajdz()
        {
            string[] przedmioty = rodzaj_urz.ToArray();
            foreach (string a in przedmioty)
                if (a.Contains("Marka: ") && a.Contains("Procesor: "))
                {
                    int koniec_id = a.IndexOf('|')-2;
                    int poczatek_id = a.IndexOf(' ')+1;
                    string sub_string = a.Substring(poczatek_id, koniec_id - poczatek_id + 1);
                    System.Console.WriteLine("Id przedmiotu z IT: " + sub_string);
                }
            //System.Console.WriteLine("ID: " + id + "    | Rodzaj: " + "Laptop");
        }
    }
}
