using System;
using System.Collections.Generic;
namespace Projekt_zaliczeniowy.Class

{
    class Program
    {
        static void Main(string[] args)
        {
            Urzadzenia lista = new Urzadzenia();
            Odkurzacz odkurzacze = new Odkurzacz();
            Lodowka lodowki = new Lodowka();
            Laptop laptopy = new Laptop();
            Smartfon smartfony = new Smartfon();
            // System.Console.WriteLine(ale);
            // System.Console.WriteLine(ale1);
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("\nCo chcesz dodać?\n1. Laptop\n2. Smartfon\n3. Lodowka\n4. Odkurzacz");
                int wybor = Convert.ToInt32(Console.ReadLine());
                switch (wybor)
                {
                    case 1: 
                        laptopy.dodaj(); 
                        lista.rodzaj_urz.Add(laptopy.sb.ToString());
                        laptopy.sb.Clear();
                        break;
                    case 2: smartfony.dodaj(); lista.rodzaj_urz.Add("Smartfon"); break;
                    case 3: lodowki.dodaj(); lista.rodzaj_urz.Add("Lodowka"); break;
                    case 4: odkurzacze.dodaj(); lista.rodzaj_urz.Add("Odkurzacz"); break;
                    default: break;
                }
            }
            lista.sprawdz_ilosc();
            /*ale.dodaj();
            ale.dodaj();
            ale.dodaj();
            ale.dodaj();
            ale.usun();
            ale.sprawdz_ilosc();
                                                                        laptopy.rodzaj,
                                                                       laptopy.marka,
                                                                       laptopy.cpu,
                                                                       laptopy.gpu,
                                                                       laptopy.model,
                                                                       laptopy.ram,
                                                                       laptopy.przekatna_ekranu,
                                                                       laptopy.pojemnosc_dysk
             
             
             */


        }
    }
}
