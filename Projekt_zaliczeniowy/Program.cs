using System;
using System.Collections.Generic;
//
namespace Projekt_zaliczeniowy.Class

{
    public class Program
    {
        static Data baza = new Data();
        static Odkurzacz odkurzacze = new Odkurzacz();
        static Lodowka lodowki = new Lodowka();
        static Laptop laptopy = new Laptop();
        static Smartfon smartfony = new Smartfon();
        private static List<Opcje> opcje_start = new List<Opcje>
        {
            new Opcje("Dodaj przedmiot", () => dodawanie()),
            new Opcje("Usun przedmiot", () =>  baza.usun()),
            new Opcje("Wyswietl wszystkie przedmioty", () =>  baza.wyswietl()),
            new Opcje("Wyszukaj przedmiot", () => baza.znajdz()),
            new Opcje("Exit", () => exit()),
        };



        static void Main(string[] args)
        {
            baza.DataCreate();
            baza.wczytaj_plik();
            menu(opcje_start);
        }

        static void exit()
        {
            Console.ForegroundColor = ConsoleColor.White;
            baza.zapisz_plik();
            Environment.Exit(0);
        }

        static void WriteMenu(List<Opcje> opcje, Opcje zaznaczone)
        {
            Console.Clear();

            foreach (Opcje opcja in opcje)
            {
                if (opcja == zaznaczone)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("> ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  ");
                }
                Console.WriteLine(opcja.Nazwa);
            }
        }

        static void dodawanie()
        {
            List<string> dodaj = new List<string>()
            {
                "Laptop", "Smartfon", "Lodowka", "Odkurzacz", "Powrót"
            };
            Console.Clear();
            int zaznaczone_opcje = 0;
            bool done_opcje = false;
            int wybor = 0;
            while (!done_opcje)
            {
                Console.Clear();
                Console.WriteLine("Co chcesz dodac?");
                for (wybor = 0; wybor < dodaj.Count; wybor++)
                {
                    if (zaznaczone_opcje == wybor) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("> "); }
                    else { Console.ForegroundColor = ConsoleColor.White; Console.Write("  "); }
                    Console.WriteLine("{0} {1}",
                        wybor + 1,
                        dodaj[wybor]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        zaznaczone_opcje = Math.Max(0, zaznaczone_opcje - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        zaznaczone_opcje = Math.Min(dodaj.Count - 1, zaznaczone_opcje + 1);
                        break;
                    case ConsoleKey.Enter:
                        done_opcje = true;
                        break;
                }
                if (!done_opcje)
                    Console.CursorTop = Console.CursorTop - dodaj.Count;
                else
                {
                    Console.Clear();
                }
            }
            switch (zaznaczone_opcje+1)
            {
                case 1:
                    Console.Clear();
                    laptopy.dodaj();
                    break;
                case 2:
                    Console.Clear();
                    smartfony.dodaj();
                    break;
                case 3:
                    Console.Clear();
                    lodowki.dodaj();
                    break;
                case 4:
                    Console.Clear();
                    odkurzacze.dodaj();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Wciśnij dowolny przycisk...");
                    Console.ReadKey();
                    break;
                default: break;
            }
            
        }

        private static void menu(List<Opcje> opcje)
        {
            int index = 0;
            WriteMenu(opcje, opcje[index]);
            ConsoleKeyInfo klawisz;
            do
            {
                klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < opcje.Count)
                    {
                        index++;
                        WriteMenu(opcje, opcje[index]);
                    }
                }
                if (klawisz.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(opcje, opcje[index]);
                    }
                }
                if (klawisz.Key == ConsoleKey.Enter)
                {
                    opcje[index].Zaznaczona.Invoke();
                    index = 0;
                    Console.Clear();
                    WriteMenu(opcje, opcje[index]);
                }
            }
            while (klawisz.Key != ConsoleKey.X);
            Console.ReadKey();
        }
    }

    public class Opcje : Program
    {
        public string Nazwa { get; }
        public Action Zaznaczona { get; }

        public Opcje(string nazwa, Action zaznaczona)
        {
            Nazwa = nazwa;
            Zaznaczona = zaznaczona;
        }
    }
}
