using System.Collections.Generic;

namespace Projekt_zaliczeniowy.Class
{
    public class Urzadzenia
    {
        protected static int id { get; set; }
        protected static int ilosc { get; set; }
        public List<string> rodzaj_urz = new List<string>();
        //var przedmioty = rodzaj_urz.ToArray();
        public Urzadzenia()
        {
            id = 1;
            ilosc = 0;
            System.Console.WriteLine("Pojemność: ", rodzaj_urz.Capacity);
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
            System.Console.WriteLine("Ilosc urzadzen na liscie: " + rodzaj_urz.Count + "\n\n");
            string[] przedmioty = rodzaj_urz.ToArray();
            System.Console.WriteLine("Ilosc urzadzen w tablicy: "+ przedmioty.Length + "\n\n");
            System.Console.WriteLine("Ilosc wpisanych przedmiotow: " +ilosc);
            foreach(string a in przedmioty)
            {
                System.Console.WriteLine(a);
            }
            
        }

        public void znajdz(int i)
        {
            
            System.Console.WriteLine("ID: " + id + "    | Rodzaj: " + "Laptop");
        }
    }
}
