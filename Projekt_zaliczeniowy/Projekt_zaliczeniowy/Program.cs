using System;
using System.Collections.Generic;
using System.Data;
namespace Projekt_zaliczeniowy.Class

{
    class Program
    {
        static Data baza = new Data();
        static Urzadzenia lista = new Urzadzenia();
        static Odkurzacz odkurzacze = new Odkurzacz();
        static Lodowka lodowki = new Lodowka();
        static Laptop laptopy = new Laptop();
        static Smartfon smartfony = new Smartfon();
        int temp = 0;
        static void Main(string[] args)
        {
            var wybor1 = 1;
            baza.DataCreate();
            baza.wczytaj_plik();
            do
            {
                Console.Clear();
                Console.WriteLine("Co mam dla Ciebie zrobić?" +
                                "\n1.Dodaj nowy przedmiot" +
                                "\n2. Usun przedmiot z bazy danych" +
                                "\n3. Wyswietl wszystkie przedmioty" +
                                "\n4. Wyswietl wybrany przedmiot" +
                                "\nWyjście - dowolny inny przycisk");
                wybor1= Convert.ToInt32(Console.ReadLine());
                switch(wybor1)
                {
                    case 1: { dodawanie(); baza.zapisz_plik(); break; }
                    case 2: { /*baza.usun();*/ baza.zapisz_plik(); break; }
                    case 3: { baza.wyswietl(); Console.ReadLine(); break; }
                    case 4: { baza.znajdz(); break; }
                    default: { wybor1 = 0; break; }
                }
                Console.WriteLine("\n\n\n");

                
                //baza.zapisz1();
                //lista.znajdz();
            } while (wybor1 != 0);


        }
        static void dodawanie()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\nCo chcesz dodać?\n1. Laptop\n2. Smartfon\n3. Lodowka\n4. Odkurzacz\n");
                int wybor = Convert.ToInt32(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        laptopy.dodaj();
                        lista.rodzaj_urz.Add(laptopy.sb.ToString());
                        laptopy.sb.Clear();
                        break;
                    case 2:
                        smartfony.dodaj();
                        lista.rodzaj_urz.Add(smartfony.sb.ToString());
                        laptopy.sb.Clear();
                        break;
                    case 3:
                        lodowki.dodaj();
                        lista.rodzaj_urz.Add(lodowki.sb.ToString());
                        laptopy.sb.Clear();
                        break;
                    case 4:
                        odkurzacze.dodaj();
                        lista.rodzaj_urz.Add(odkurzacze.sb.ToString());
                        laptopy.sb.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}
